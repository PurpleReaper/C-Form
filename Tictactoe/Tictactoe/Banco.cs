using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tictactoe
{
    public class Banco
    {
        #region Properties
        private Panel Xuly; //luu tru lai
        private TicTacToe owner;
        private List<Button> list_btn;
        private List<Mark> list_mark;   // lưu giá trị con cờ
        //bool turn = true;
        int turn_count = 0;
        
        public enum Mark
        {
            NO_VALUE,
            O_VALUE,
            X_VALUE
        }

        public Panel Xuly1
        {
            get
            {
                return Xuly;
            }

            set
            {
                Xuly = value;
            }
        }
        #endregion

        #region Initialize
        public Banco(TicTacToe owner ,Panel Xuly)
        {
            this.owner = owner;
            this.Xuly1 = Xuly;
            list_btn = new List<Button>(9);
            list_mark = new List<Mark>(9);
        }
        #endregion

        #region Methods
        public void VeBanCo()
        {
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };// luu lai oldbutton de su dung
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Button btn = new Button()
                    {
                        
                        Width = kichthuoc.Rong,
                        Height = kichthuoc.Dai,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch
                    };
                    btn.Click += Btn_Click;//uy thac 1 cai event, khi click vao se hien image


                    Xuly1.Controls.Add(btn);
                    oldButton = btn;//tai su dung lai

                    list_btn.Add(btn);
                    list_mark.Add(Mark.NO_VALUE);
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + kichthuoc.Dai);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }
        #endregion
        private void Btn_Click(object sender, EventArgs e)
        {
            //AI_AlpaBeta(); // xữ lý máy đánh
            Button btn = sender as Button; //khi click vao button nao button do se hien thi image
            btn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\p1.png");

            btn.Enabled = false; // k cho danh co sau khi da danh
            turn_count++;
            int index = list_btn.IndexOf(btn);
            list_mark[index] = Mark.X_VALUE;
            bool isEnd = xuLy();
            if (!isEnd)
                computer();


            


            
        }
        private void computer()
        {
            Button move = null;
            move = lookForWinOrBlock(Mark.O_VALUE);
            if (move == null)
            {
                move = lookForWinOrBlock(Mark.X_VALUE);
                if (move == null)
                {
                    move = lookforcorner();
                    if (move == null)
                        move = lookforopenspace();

                }
            }


                move.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\p2.jpg");

                move.Enabled = false; // k cho danh co sau khi da danh
                int index = list_btn.IndexOf(move);
                list_mark[index] = Mark.O_VALUE;

                xuLy();
            
        }
        
        
       
        private Button lookForWinOrBlock(Mark mark) // xử lý máy đánh
        {
            // Xet hang ngang
           for(int i=0; i<10; i += 4)
            {
                if (list_mark[i] == mark && list_mark[i + 1] == mark && list_mark[i + 2] == Mark.NO_VALUE)
                    return list_btn[i + 2];
                if (list_mark[i] == mark && list_mark[i + 1] == Mark.NO_VALUE && list_mark[i + 2] == mark)
                    return list_btn[i + 1];
                if (list_mark[i] == Mark.NO_VALUE && list_mark[i + 1] == mark && list_mark[i + 2] == mark)
                    return list_btn[i];
            }

           // xet hang doc
           for(int i=0; i<3; i++)
            {
                if (list_mark[i] == mark && list_mark[i + 4] == mark && list_mark[i + 8] == Mark.NO_VALUE)
                    return list_btn[i + 8];
                if (list_mark[i] == mark && list_mark[i + 4] == Mark.NO_VALUE && list_mark[i + 8] == mark)
                    return list_btn[i + 4];
                if (list_mark[i] == Mark.NO_VALUE && list_mark[i + 4] == mark && list_mark[i + 8] == mark)
                    return list_btn[i];
            }
            // xét \
            if (list_mark[0] == mark && list_mark[5] == mark && list_mark[10] == Mark.NO_VALUE)
                return list_btn[10];
            if (list_mark[0] == mark && list_mark[5] == Mark.NO_VALUE && list_mark[10] == mark)
                return list_btn[5];
            if (list_mark[0] == Mark.NO_VALUE && list_mark[5] == mark && list_mark[10] == mark)
                return list_btn[0];

            // xét /
            if (list_mark[2] == mark && list_mark[5] == mark && list_mark[8] == Mark.NO_VALUE)
                return list_btn[8];
            if (list_mark[2] == mark && list_mark[5] == Mark.NO_VALUE && list_mark[8] == mark)
                return list_btn[5];
            if (list_mark[2] == Mark.NO_VALUE && list_mark[5] == mark && list_mark[8] == mark)
                return list_btn[2];

            return null;
        }
        private Button lookforcorner()
        {
            
            if (list_mark[0] == Mark.O_VALUE)
            {
                if (list_mark[2] == Mark.NO_VALUE)
                    return list_btn[2];
                if (list_mark[10] == Mark.NO_VALUE)
                    return list_btn[10];
                if (list_mark[8] == Mark.NO_VALUE)
                    return list_btn[8];
            }
            if (list_mark[2] == Mark.O_VALUE)
            {
                if (list_mark[0] == Mark.NO_VALUE)
                    return list_btn[0];
                if (list_mark[8] == Mark.NO_VALUE)
                    return list_btn[8];
                if (list_mark[10] == Mark.NO_VALUE)
                    return list_btn[10];
            }
            if (list_mark[10] == Mark.O_VALUE)
            {
                if (list_mark[0] == Mark.NO_VALUE)
                    return list_btn[0];
                if (list_mark[8] == Mark.NO_VALUE)
                    return list_btn[8];
                if (list_mark[2] == Mark.NO_VALUE)
                    return list_btn[2];
            }
            if (list_mark[8] == Mark.O_VALUE)
            {
                if (list_mark[0] == Mark.NO_VALUE)
                    return list_btn[0];
                if (list_mark[2] == Mark.NO_VALUE)
                    return list_btn[2];
                if (list_mark[10] == Mark.NO_VALUE)
                    return list_btn[10];
            }
            if (list_mark[0] == Mark.NO_VALUE)
                return list_btn[0];
            if (list_mark[2] == Mark.NO_VALUE)
                return list_btn[2];
            if (list_mark[8] == Mark.NO_VALUE)
                return list_btn[8];
            if (list_mark[10] == Mark.NO_VALUE)
                return list_btn[10];
            if (list_mark[4] == Mark.NO_VALUE)
                return list_btn[4];
            if (list_mark[5] == Mark.NO_VALUE)
                return list_btn[5];
            if (list_mark[6] == Mark.NO_VALUE)
                return list_btn[6];
            return null;
        }
        private Button lookforopenspace()
        {
            Button b = null;
            foreach (Control control in Xuly1.Controls)
            {
                b = control as Button;
                int index = list_btn.IndexOf(b);
                if (list_mark[index] == Mark.NO_VALUE)
                    return b;
            }

            return null;
        }



        public bool kiemTraThangThua(Mark mark)
        {
            bool isVictory = false;
            // Check Rows
            for(int i = 0; i < 10; i = i + 4)
            {
                if(list_mark[i] == mark && list_mark[i+1] == mark && list_mark[i+2] == mark)
                {
                    isVictory = true;
                }
            }
            // Check Cols
            for (int i = 0; i <= 2; i++)
            {
                if (list_mark[i] == mark && list_mark[i + 4] == mark && list_mark[i + 8] == mark)
                {
                    isVictory = true;
                }
            }
            // Check \

            if (list_mark[0] == mark && list_mark[5] == mark && list_mark[10] == mark)
            {
                 isVictory = true;
            }
            // Check /
            if (list_mark[2] == mark && list_mark[5] == mark && list_mark[8] == mark)
            {
                isVictory = true;
            }

            return isVictory;

        }

        public bool xuLy()
        {

            if(kiemTraThangThua(Mark.O_VALUE))
            {
                MessageBox.Show("Computer Win!!");
                Xuly1.Enabled = false;
                return true;
            }
            else if (kiemTraThangThua(Mark.X_VALUE))
            {
                MessageBox.Show("Player Win!!");
                Xuly1.Enabled = false;
                owner.PlusScore();
                
                return true;

            } else if(turn_count == 5)
            {
                MessageBox.Show("Hòa!!");
                Xuly1.Enabled = false;
                return true;
            }

            return false;
        }

    }
}
