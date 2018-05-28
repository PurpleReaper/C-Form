using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCaro
{
    // Biến người chiến thắng
    public enum Winner
    {
        Player1,
        Player2,
        COM,
        Hoa
    }

    class CaroChess
    {
        public static Pen pen;
        private BanCo _BanCo;
        private OCo[,] _MangOCo;
        private int _LuotDi;
        private static SolidBrush sbwhite;
        private static SolidBrush sbblack;
        private static SolidBrush sbback;
        private Stack<OCo> stk_NuocDaDi;
        private Stack<OCo> stk_Undo;
        private bool _SanSang;
        private Winner _winner;
        private int _CheDoChoi;
        private Image image_O;
        private Image image_X;
        private int _Score;




        public CaroChess ()
        {
            pen = new Pen(Color.Black);
            _BanCo = new BanCo(20, 20);
            _MangOCo = new OCo[_BanCo.SoDong, _BanCo.SoCot];
            _LuotDi = 1;
            sbblack = new SolidBrush(Color.Black);
            sbwhite = new SolidBrush(Color.White);
            TaoMangOCo();
            stk_NuocDaDi = new Stack<OCo>();
            stk_Undo = new Stack<OCo>();
            sbback = new SolidBrush(Color.Khaki);
            image_O = new Bitmap(Properties.Resources.o);
            image_X = new Bitmap(Properties.Resources.x);
            _Score = 0;
        }

        #region Getter - Setter

        public Winner winner
        {
            get { return _winner; }
        }
        public int Score
        {
            get { return _Score; }
            set { _Score = value; }
        }
        public bool SanSang
        {
            get { return _SanSang; }
            set { _SanSang = value; }
        }
        public int CheDoChoi
        {
            get { return _CheDoChoi; }
        }
        #endregion

        #region Các hàm trong trong bàn cờ
        // Hàm vẽ bàn cờ
        public void VeBanCo(Graphics g)
        {
            _BanCo.VeBanCo(g);
        }

        // Hàm tạo ra các ô cờ trên bàn cờ
        public void TaoMangOCo()
        {
            for (int i = 0; i < _BanCo.SoDong; i++)
                for (int j = 0; j < _BanCo.SoCot; j++)
                    _MangOCo[i, j] = new OCo(i, j, new Point(j * OCo._DoDai, i * OCo._DoDai), 0);
        }

        // Hàm đánh cờ 
        public bool DanhCo(Graphics g, int MouseX, int MouseY)
        {
            if (MouseX % OCo._DoDai == 0 || MouseY % OCo._DoDai == 0)
                return false;
            int Cot = MouseX / OCo._DoDai;
            int Dong = MouseY / OCo._DoDai;
            if (_MangOCo[Dong, Cot].SoHuu != 0)
                return false;

            switch (_LuotDi)
            {
                case 1:
                    _MangOCo[Dong, Cot].SoHuu = 1;
                    _BanCo.VeQuanCo(g, image_O, _MangOCo[Dong, Cot].ViTri);
                    _LuotDi = 2;
                    break;
                case 2:
                    _MangOCo[Dong, Cot].SoHuu = 2;
                    _BanCo.VeQuanCo(g, image_X, _MangOCo[Dong, Cot].ViTri);
                    _LuotDi = 1;
                    break;
            }
            stk_Undo = new Stack<OCo>();
            OCo oco = new OCo(_MangOCo[Dong, Cot].Dong, _MangOCo[Dong, Cot].Cot, _MangOCo[Dong, Cot].ViTri, _MangOCo[Dong, Cot].SoHuu);
            stk_NuocDaDi.Push(oco);
            return true;
        }

        // Hàm vẻ lại quân cờ (repaint)
        public void VeLaiQuanCo(Graphics g)
        {
            foreach(OCo oco in stk_NuocDaDi)
            {
                if (oco.SoHuu == 1)
                    _BanCo.VeQuanCo(g, image_O, oco.ViTri);
                else if (oco.SoHuu == 2)
                    _BanCo.VeQuanCo(g, image_X, oco.ViTri);
            }
        }
        #endregion

        #region Các chế độ chơi
        public void StartPvsP(Graphics g)
        {
            _SanSang = true;
            _CheDoChoi = 1;
            stk_NuocDaDi = new Stack<OCo>();
            stk_Undo = new Stack<OCo>();
            TaoMangOCo();
            VeBanCo(g);
            _LuotDi = 1;
        }
        public void StartPvsC(Graphics g)
        {
            _SanSang = true;
            _CheDoChoi = 2;
            stk_NuocDaDi = new Stack<OCo>();
            stk_Undo = new Stack<OCo>();
            TaoMangOCo();
            VeBanCo(g);
            _LuotDi = 1;
            KhoiDongMay(g);
        }

        #endregion

        #region Undo Redo
        public void Undo(Graphics g)
        {
            if (!_SanSang)
                return;
            // Khi chơi với người
            if(_CheDoChoi == 1)
            {
                if (stk_NuocDaDi.Count != 0)
                {
                    OCo oco = stk_NuocDaDi.Pop();
                    stk_Undo.Push(new OCo(oco.Dong, oco.Cot, oco.ViTri, oco.SoHuu));
                    _MangOCo[oco.Dong, oco.Cot].SoHuu = 0;
                    _BanCo.XoaQuanCo(g, oco.ViTri, sbback);
                    if (_LuotDi == 1)
                        _LuotDi = 2;
                    else
                        _LuotDi = 1;
                }
            }
            // Khi chơi với máy
            else          
            {
                if (stk_NuocDaDi.Count > 1)
                {
                    // Xóa nước đi của máy
                    OCo oco = stk_NuocDaDi.Pop();
                    _BanCo.XoaQuanCo(g, oco.ViTri, sbback);
                    _MangOCo[oco.Dong, oco.Cot].SoHuu = 0;
                    // Xóa nước đi của người chơi
                    oco = stk_NuocDaDi.Pop();
                    stk_Undo.Push(new OCo(oco.Dong, oco.Cot, oco.ViTri, oco.SoHuu));
                    _MangOCo[oco.Dong, oco.Cot].SoHuu = 0;
                    _BanCo.XoaQuanCo(g, oco.ViTri, sbback);
                    
                }
            }
            _SanSang = true;
            
        }
        public void Redo(Graphics g)
        {
            // Khi chơi với người
            if(_CheDoChoi == 1)
            {
                if (stk_Undo.Count != 0)
                {
                    OCo oco = stk_Undo.Pop();
                    stk_NuocDaDi.Push(new OCo(oco.Dong, oco.Cot, oco.ViTri, oco.SoHuu));
                    _MangOCo[oco.Dong, oco.Cot].SoHuu = oco.SoHuu;
                    _BanCo.VeQuanCo(g, oco.SoHuu == 1 ? image_O : image_X, oco.ViTri);
                    
                }
             
            }
            // Không đc Redo khi chơi với máy
            
          

        }
        #endregion

        #region GiaiThuat

        // Hàm kiểm tra xem ai là người chiến thắng
        public bool CheckWin()
        {
            if(stk_NuocDaDi.Count == _BanCo.SoCot * _BanCo.SoDong)
            {
                _winner = Winner.Hoa;   
                return true;
            }
            foreach(OCo oco in stk_NuocDaDi)
            {
                if(_CheDoChoi == 1)
                {
                    if (CheckDoc(oco.Dong, oco.Cot, oco.SoHuu) || CheckNgang(oco.Dong, oco.Cot, oco.SoHuu)
                    || CheckCheoXuoi(oco.Dong, oco.Cot, oco.SoHuu) || CheckCheoNguoc(oco.Dong, oco.Cot, oco.SoHuu))
                    {
                        _winner = oco.SoHuu == 1 ? Winner.Player1 : Winner.Player2;
                        return true;
                    }
                }
                else
                {
                    if (CheckDoc(oco.Dong, oco.Cot, oco.SoHuu) || CheckNgang(oco.Dong, oco.Cot, oco.SoHuu)
                    || CheckCheoXuoi(oco.Dong, oco.Cot, oco.SoHuu) || CheckCheoNguoc(oco.Dong, oco.Cot, oco.SoHuu))
                    {
                        _winner = oco.SoHuu == 1 ? Winner.COM : Winner.Player1;
                        return true;
                    }
                }
            }


            return false;
        }

        // Hàm kiểm tra theo hàng dọc
        private bool CheckDoc(int currDong, int currCot, int currSoHuu)
        {
            if (currDong > _BanCo.SoDong - 5)
                return false;
            int count;
            for (count = 1; count < 5; count++)
            {
                if (_MangOCo[currDong + count, currCot].SoHuu != currSoHuu)
                    return false;
            }
            if (currDong == 0 || currDong + count == _BanCo.SoDong)
                return true;
            if (_MangOCo[currDong - 1, currCot].SoHuu == 0 || _MangOCo[currDong + count, currCot].SoHuu == 0)
                return true;
            return false; 
        }

        // Hàm kiểm tra theo hàng ngang
        private bool CheckNgang(int currDong, int currCot, int currSoHuu)
        {
            if (currCot > _BanCo.SoCot - 5)
                return false;
            int count;
            for(count = 1; count < 5; count++)
            {
                if (_MangOCo[currDong, currCot + count].SoHuu != currSoHuu)
                    return false;
            }
            if (currCot == 0 || currCot + count == _BanCo.SoCot)
                return true;
            if (_MangOCo[currDong, currCot - 1].SoHuu == 0 || _MangOCo[currDong, currCot + count].SoHuu == 0)
                return true;
            return false;
        }

        // Hàm kiểm tra chéo xuôi (dấu huyền)
        private bool CheckCheoXuoi(int currDong, int currCot, int currSoHuu)
        {
            if (currDong > _BanCo.SoDong - 5 || currCot > _BanCo.SoCot - 5)
                return false;
            int count;
            for (count = 1; count < 5; count++)
            {
                if (_MangOCo[currDong + count, currCot + count].SoHuu != currSoHuu)
                    return false;
            }
            if (currDong == 0 || currDong + count == _BanCo.SoDong || currCot == 0 || currCot + count == _BanCo.SoCot)
                return true;
            if (_MangOCo[currDong - 1, currCot - 1].SoHuu == 0 || _MangOCo[currDong + count, currCot + count].SoHuu == 0)
                return true;
            return false;
        }

        // Hàm kiểm tra chéo ngược (dấu sắc)
        private bool CheckCheoNguoc(int currDong, int currCot, int currSoHuu)
        {
            if (currDong < 4 ||  currCot > _BanCo.SoCot - 5)
                return false;
            int count;
            for (count = 1; count < 5; count++)
            {
                if (_MangOCo[currDong - count, currCot + count].SoHuu != currSoHuu)
                    return false;
            }
            if (currDong == 4 || currDong == _BanCo.SoDong - 1 || currCot == 0 || currCot + count == _BanCo.SoCot)
                return true;
            if (_MangOCo[currDong + 1, currCot - 1].SoHuu == 0 || _MangOCo[currDong - count, currCot + count].SoHuu == 0)
                return true;
            return false;
        }

        // Hàm in ra người chiến thắng
        public void EndGame()
        {
            switch(_winner)
            {
                case Winner.Hoa:
                    MessageBox.Show("Hòa rồi!!!");
                    break;
                case Winner.Player1:
                    MessageBox.Show("Người chơi 1 thắng!!!");
                    break;
                case Winner.Player2:
                    MessageBox.Show("Người chơi 2 thắng!!!");
                    break;
                case Winner.COM:
                    MessageBox.Show("Computer thắng!!!");
                    break;
            }
            //String query = string.Empty;
            //try
            //{
            //    conn.Open();
            //    query = "Update"
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message + ex.StackTrace);
            //}
            
            
            _SanSang = false;
        }


        #endregion
  
        #region AI
        // Mảng tính điểm tấn công
        private long[] arrDiemTancong = new long[7] { 0, 3, 24, 192, 1536, 12288, 98304 };
        // Mảng tính điểm phòng thủ
        private long[] arrDiemPhongNgu = new long[7] { 0, 2, 18, 162, 1458, 13122, 118098 };


        // Hàm đánh cờ của máy
        public void KhoiDongMay (Graphics g)
        {
            if (stk_NuocDaDi.Count == 0)
                DanhCo(g, _BanCo.SoCot / 2 * OCo._DoDai + 1, _BanCo.SoDong / 2 * OCo._DoDai + 1);
            else
            {
                OCo oco = TimNuocDi();
                DanhCo(g, oco.ViTri.X + 1, oco.ViTri.Y + 1);
            }
        }

        // Hàm tìm nước đi tối ưu của máy
        private OCo TimNuocDi()
        {
            OCo oCoResult = new OCo();
            long DiemLonNhat = 0;  
            for(int i = 0; i < _BanCo.SoDong; i++)
                for(int j = 0; j < _BanCo.SoCot; j++)
                {
                    if(_MangOCo[i, j].SoHuu == 0)
                    {
                        long DiemTanCong = DiemTC_DuyetDoc(i, j) + DiemTC_DuyetNgang(i, j) + DiemTC_DuyetCheoXuoi(i, j) + DiemTC_DuyetCheoNguoc(i, j);
                        long DiemPhongNgu = DiemPN_DuyetDoc(i, j) + DiemPN_DuyetNgang(i, j) + DiemPN_DuyetCheoXuoi(i, j) + DiemPN_DuyetCheoNguoc(i, j);
                        long Temp = DiemTanCong > DiemPhongNgu ? DiemTanCong : DiemPhongNgu;
                        if (Temp > DiemLonNhat)
                        {
                            DiemLonNhat = Temp;
                            oCoResult = new OCo(_MangOCo[i, j].Dong, _MangOCo[i, j].Cot, _MangOCo[i, j].ViTri, _MangOCo[i, j].SoHuu);
                        }
                    }
                }


            return oCoResult;
        }

        #region Điểm tấn công duyệt theo chiều
        private long DiemTC_DuyetDoc(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for(int count = 1; count < 6 && currDong + count < _BanCo.SoDong; count++)
            {
                if (_MangOCo[currDong + count, currCot].SoHuu == 1)
                    SoQuanTa++;
                else if (_MangOCo[currDong + count, currCot].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                    break;
            }

            for (int count = 1; count < 6 && currDong - count >= 0; count++)
            {
                if (_MangOCo[currDong - count, currCot].SoHuu == 1)
                    SoQuanTa++;
                else if (_MangOCo[currDong - count, currCot].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                    break;
            }
            if (SoQuanDich == 2)
                return 0;
            DiemTong -= arrDiemPhongNgu[SoQuanDich + 1];
            DiemTong += arrDiemTancong[SoQuanTa];

            return DiemTong;
        }
        private long DiemTC_DuyetNgang(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int count = 1; count < 6 && currCot + count < _BanCo.SoCot; count++)
            {
                if (_MangOCo[currDong, currCot + count].SoHuu == 1)
                    SoQuanTa++;
                else if (_MangOCo[currDong, currCot + count].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                    break;
            }

            for (int count = 1; count < 6 && currCot - count >= 0; count++)
            {
                if (_MangOCo[currDong, currCot - count].SoHuu == 1)
                    SoQuanTa++;
                else if (_MangOCo[currDong, currCot - count].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                    break;
            }
            if (SoQuanDich == 2)
                return 0;
            DiemTong -= arrDiemPhongNgu[SoQuanDich + 1];
            DiemTong += arrDiemTancong[SoQuanTa];

            return DiemTong;
        }
        private long DiemTC_DuyetCheoXuoi(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int count = 1; count < 6 && currCot + count < _BanCo.SoCot && currDong + count < _BanCo.SoDong; count++)
            {
                if (_MangOCo[currDong + count, currCot + count].SoHuu == 1)
                    SoQuanTa++;
                else if (_MangOCo[currDong + count, currCot + count].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                    break;
            }

            for (int count = 1; count < 6 && currCot - count >= 0 && currDong - count >= 0; count++)
            {
                if (_MangOCo[currDong - count, currCot - count].SoHuu == 1)
                    SoQuanTa++;
                else if (_MangOCo[currDong - count, currCot - count].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                    break;
            }
            if (SoQuanDich == 2)
                return 0;
            DiemTong -= arrDiemPhongNgu[SoQuanDich + 1];
            DiemTong += arrDiemTancong[SoQuanTa];

            return DiemTong;
        }
        private long DiemTC_DuyetCheoNguoc(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int count = 1; count < 6 && currCot + count < _BanCo.SoCot && currDong - count >= 0; count++)
            {
                if (_MangOCo[currDong - count, currCot + count].SoHuu == 1)
                    SoQuanTa++;
                else if (_MangOCo[currDong - count, currCot + count].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                    break;
            }

            for (int count = 1; count < 6 && currCot - count >= 0 && currDong + count < _BanCo.SoDong; count++)
            {
                if (_MangOCo[currDong + count, currCot - count].SoHuu == 1)
                    SoQuanTa++;
                else if (_MangOCo[currDong + count, currCot - count].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                    break;
            }
            if (SoQuanDich == 2)
                return 0;
            DiemTong -= arrDiemPhongNgu[SoQuanDich + 1];
            DiemTong += arrDiemTancong[SoQuanTa];

            return DiemTong;
        }

        #endregion

        #region Điểm phòng ngự duyệt theo chiều
        private long DiemPN_DuyetDoc(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int count = 1; count < 6 && currDong + count < _BanCo.SoDong; count++)
            {
                if (_MangOCo[currDong + count, currCot].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong + count, currCot].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else
                    break;
            }

            for (int count = 1; count < 6 && currDong - count >= 0; count++)
            {
                if (_MangOCo[currDong - count, currCot].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong - count, currCot].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else
                    break;
            }
            if (SoQuanTa == 2)
                return 0;
            DiemTong += arrDiemTancong[SoQuanDich];

            return DiemTong;
        }
        private long DiemPN_DuyetNgang(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int count = 1; count < 6 && currCot + count < _BanCo.SoCot; count++)
            {
                if (_MangOCo[currDong, currCot + count].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong, currCot + count].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else
                    break;
            }

            for (int count = 1; count < 6 && currCot - count >= 0; count++)
            {
                if (_MangOCo[currDong, currCot - count].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong, currCot - count].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else
                    break;
            }
            if (SoQuanTa == 2)
                return 0;
            DiemTong += arrDiemPhongNgu[SoQuanDich];

            return DiemTong;
        }
        private long DiemPN_DuyetCheoXuoi(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int count = 1; count < 6 && currCot + count < _BanCo.SoCot && currDong + count < _BanCo.SoDong; count++)
            {
                if (_MangOCo[currDong + count, currCot + count].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong + count, currCot + count].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else
                    break;
            }

            for (int count = 1; count < 6 && currCot - count >= 0 && currDong - count >= 0; count++)
            {
                if (_MangOCo[currDong - count, currCot - count].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong - count, currCot - count].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else
                    break;
            }
            if (SoQuanTa == 2)
                return 0;
            DiemTong += arrDiemPhongNgu[SoQuanDich];

            return DiemTong;
        }
        private long DiemPN_DuyetCheoNguoc(int currDong, int currCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int count = 1; count < 6 && currCot + count < _BanCo.SoCot && currDong - count >= 0; count++)
            {
                if (_MangOCo[currDong - count, currCot + count].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong - count, currCot + count].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else
                    break;
            }

            for (int count = 1; count < 6 && currCot - count >= 0 && currDong + count < _BanCo.SoDong; count++)
            {
                if (_MangOCo[currDong + count, currCot - count].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong + count, currCot - count].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else
                    break;
            }
            if (SoQuanTa == 2)
                return 0;
            DiemTong += arrDiemPhongNgu[SoQuanDich];

            return DiemTong;
        }

        #endregion


        #endregion
    }
}
