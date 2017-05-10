using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnetFeladat
{
    public partial class Form1 : Form
    {
       
        Rectangle A;
        Rectangle B;
        Rectangle C;
        Rectangle D;//our racket sprite
        private int A_x;
        private int A_y;

        private int B_x;
        private int B_y;

        private int C_x;
        private int C_y;

        private int D_x;
        private int D_y;
        
        


        public Form1()
        {
            InitializeComponent();
            A_x = 0;
            A_y = 0;

            B_x = 400;
            B_y = 0;

            D_x = 0;
            D_y = 400;

            C_x = 400;
            C_y = 400;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderColor = BackColor;
            button1.FlatAppearance.MouseOverBackColor = BackColor;
            button1.FlatAppearance.MouseDownBackColor = BackColor;





        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.RoyalBlue), new Rectangle(A_x, A_y, 20, 20));
            e.Graphics.FillRectangle(new SolidBrush(Color.RoyalBlue), new Rectangle(B_x, B_y, 20, 20));
            e.Graphics.FillRectangle(new SolidBrush(Color.RoyalBlue), new Rectangle(C_x, C_y, 20, 20));
            e.Graphics.FillRectangle(new SolidBrush(Color.RoyalBlue), new Rectangle(D_x, D_y, 20, 20));

        }
        private void A_timer_Tick(object sender, EventArgs e)
        {
            if(A_x == B_x - 20 && A_y == B_y - 20)
            {
                A_timer.Stop();
            }
            else {
            do
            {
                if (A_x < B_x)
                {
                    A_x++;
                }
                else
                {
                    A_x--;
                }
            }
            while (A_x == B_x-20);

            do
            {
                if (A_y < B_y)
                {
                    A_y++;
                }
                else
                {
                    A_y--;
                }

            }
            while (A_y == B_y-20);

           
            Invalidate();
            }

        }

        private void B_timer_Tick(object sender, EventArgs e)
        {
            if(B_x == C_x - 20 && B_y == C_y - 20)
            {
                B_timer.Stop();
            }
            else
            { 
            do
            {
                if (B_x < C_x)
                {
                    B_x++;
                }
                else
                {
                    B_x--;
                }
            }
            while (B_x == C_x-20);

            do
            {
                if (B_y < C_y)
                {
                    B_y++;
                }
                else
                {
                    B_y--;
                }

            }
            while (B_y == C_y-20);

         
            
            Invalidate();

            }


        }

        private void C_timer_Tick(object sender, EventArgs e)
        {
            if(C_x == D_x - 20 && C_y == D_y - 20)
            {
                C_timer.Stop();
            }
            else { 
            do
            {
                if (C_x < D_x)
                {
                    C_x++;
                }
                else
                {
                    C_x--;
                }
            }
            while (C_x == D_x-20);

            do
            {
                if (C_y < D_y)
                {
                    C_y++;
                }
                else
                {
                    C_y--;
                }

            }
            while (C_y == D_y-20);

            

            Invalidate();

            }


        }

        private void D_timer_Tick(object sender, EventArgs e)
        {
            if(D_x == A_x - 20 && D_y == A_y - 20)
            {
                D_timer.Stop();
            }
            else
            {

            
            do
            {
                if (D_x < A_x)
                {
                    D_x++;
                }
                else
                {
                    D_x--;
                }

            
            }
            while (D_x == A_x-20);

            do
            {
                if (D_y < A_y)
                {
                    D_y++;
                }
                else
                {
                    D_y--;
                }

            }
            while (D_y == A_y-20);

          
            Invalidate();

            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            A_timer.Stop(); B_timer.Stop(); C_timer.Stop(); D_timer.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer MyTimer = new Timer();
            MyTimer.Interval = (21000); // 45 mins
            MyTimer.Tick += new EventHandler(button1_Click);
            MyTimer.Start();
        }
    }
}
