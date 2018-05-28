using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCaro
{
    class BanCo
    {
        private int _SoDong;
        private int _SoCot;

        #region Hàm khởi tạo

        public BanCo()
        {
            _SoDong = 0;
            _SoCot = 0;
        }
        public BanCo(int soDong, int soCot)
        {
            _SoDong = soDong;
            _SoCot = soCot;
        }

        #endregion

        #region Getter - Setter

        public int SoDong
        {
            get { return _SoDong; }
            set { _SoDong = value; }
        }
        public int SoCot
        {
            get { return _SoCot; }
            set { _SoCot = value; }
        }
        #endregion



        // Hàm kẻ ô bàn cờ
        public void VeBanCo(Graphics g)  
        {
            for(int i = 0; i <= _SoCot; i++)
            {
                g.DrawLine(CaroChess.pen, i * OCo._DoDai, 0, i * OCo._DoDai, _SoDong * OCo._DoDai);
            }
            for (int i = 0; i <= _SoDong; i++)
            {
                g.DrawLine(CaroChess.pen, 0, i*OCo._DoDai, _SoCot*OCo._DoDai, i*OCo._DoDai);
            }
        }

        // Hàm vẽ quân cờ
        public void VeQuanCo(Graphics g, Image image, Point point)  
        {
            g.DrawImage(image, point);
        }

        // Hàm xóa quân cờ
        public void XoaQuanCo(Graphics g, Point point, SolidBrush sb)
        {
            g.FillRectangle(sb, point.X + 1, point.Y + 1, OCo._DoDai - 1, OCo._DoDai - 1);
        }
    }
}
