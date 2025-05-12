using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jacome_Leccion
{
    public partial class FrmPentagon : Form
    {
        private Pentagon objPentagono = new Pentagon();

        private static FrmPentagon instance;

        private FrmPentagon()
        {
            InitializeComponent();
        }

        public static FrmPentagon getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmPentagon();
            }
            return instance;
        }

        private void FrmPentagon_Load(object sender, EventArgs e)
        {
            objPentagono.InitializeData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalcule_Click(object sender, EventArgs e)
        {
            objPentagono.ReadData(txtRadius, picCanvas);
            objPentagono.CalculatePerimeter();
            objPentagono.CalculateArea();
            objPentagono.PrintData(txtPerimeter, txtArea);
            //objPentagono.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objPentagono.InitializeData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


    class Pentagon
    {
        private float mRadius;
        private float mApothem;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 10;
        private int nlade = 5;

        public Pentagon()
        {
            mRadius = 0.0f;
            mApothem = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtRadius, PictureBox picCanvas)
        {
            try
            {
                mRadius = float.Parse(txtRadius.Text);

                if (mRadius <= 0)
                {
                    MessageBox.Show("Ingrese un numero positivo", "ERROR");
                    txtRadius.Focus();
                    mRadius = 0.0f;
                    return;
                }

                picCanvas.Refresh();
                CalculateApotema();
            }
            catch
            {
                MessageBox.Show("Ingrese numeros correctamente", "ERROR");
                txtRadius.Focus();
            }
        }


        private void CalculateApotema()
        {
            mApothem = mRadius * (float)Math.Cos(Math.PI / nlade);
        }

        public void CalculatePerimeter()
        {
            float lado = 2 * mRadius * (float)Math.Sin(Math.PI / nlade);
            mPerimeter = nlade * lado;
        }

        public void CalculateArea()
        {
            mArea = (mPerimeter * mApothem) / 2;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("F2");
            txtArea.Text = mArea.ToString("F2");
        }

        public void InitializeData(TextBox txtRadius, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mRadius = 0.0f; mApothem = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
            txtRadius.Text = ""; txtPerimeter.Text = ""; txtArea.Text = "";
            txtRadius.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);

            Point[] puntos = new Point[nlade];
            float centerX = picCanvas.Width / 2;
            float centerY = picCanvas.Height / 2;

            for (int i = 0; i < nlade; i++)
            {
                double angle = 2 * Math.PI * i / nlade;
                int x = (int)(centerX + mRadius * SF * Math.Cos(angle));
                int y = (int)(centerY + mRadius * SF * Math.Sin(angle));
                puntos[i] = new Point(x, y);
            }

            mGraph.DrawPolygon(mPen, puntos);
        }
    }

}
