using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCaro
{
    class OCo
    {
        public const int _DoDai = 25; // Độ dài cạnh của 1 ô cờ
        private int _Dong;
        private int _Cot;
        private int _SoHuu;
        private Point _ViTri;

        #region Getter - Setter
        public int Dong
        {
            set { _Dong = value; }
            get { return _Dong; }
        }
        public int Cot
        {
            set { _Cot = value; }
            get { return _Cot; }
        }
        public int SoHuu
        {
            set { _SoHuu = value; }
            get { return _SoHuu; }
        }
        public Point ViTri
        {
            set { _ViTri = value; }
            get { return _ViTri; }
        }
        #endregion


        //  Hàm khởi tạo
        public OCo (int dong, int cot, Point vitri, int sohuu)
        {
            _Dong = dong;
            _Cot = cot;
            _ViTri = vitri;
            _SoHuu = sohuu;
        }

        public OCo()
        {
        }
    }
}
