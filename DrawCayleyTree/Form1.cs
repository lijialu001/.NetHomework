using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawCayleyTree
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        double th1;
        double th2;
        double per1;
        double per2;
        double thx = -Math.PI / 2;
        public Form1()
        {
            InitializeComponent();
        }

        void drawCayleyTree(int n, double x0,double y0,double leng,double th,string treeColor)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1,treeColor);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1,treeColor);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2,treeColor);
        }

        private void drawLine(double x0, double y0, double x1, double y1, string color)
        {
            switch (color)
            {
                case "红色": graphics.DrawLine(Pens.Red, (int)x0, (int)y0, (int)x1, (int)y1);break;
                case "蓝色": graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);break;
                case "绿色": graphics.DrawLine(Pens.Green, (int)x0, (int)y0, (int)x1, (int)y1);break;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            int n1 = int.Parse(depth.Text);
            double x = 200;
            double y = 310;
            double leng1 = double.Parse(mainlength.Text);
            th1 = double.Parse(rightAngle.Text) * Math.PI / 180;
            th2 = double.Parse(leftAngle.Text) * Math.PI / 180;
            per1 = double.Parse(rightRatio.Text);
            per2 = double.Parse(leftRatio.Text);
            string selectcolor=comboBox1.Text;

            drawCayleyTree(n1, x, y, leng1, thx, selectcolor);

            
        }

    }
}
