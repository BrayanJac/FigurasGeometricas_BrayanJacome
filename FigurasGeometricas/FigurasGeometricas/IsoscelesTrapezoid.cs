using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diamond;
using static System.Windows.Forms.MonthCalendar;

namespace IsoscelesTrapezoid
{
    public partial class frmIsoscelesTrapezoid : Form
    {
        private IsoscelesTrapezoid objIsoscelesTrapezoid = new IsoscelesTrapezoid();
        
        private static frmIsoscelesTrapezoid instance;

        private frmIsoscelesTrapezoid()
        {
            InitializeComponent();
        }

        public static frmIsoscelesTrapezoid getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmIsoscelesTrapezoid();
            }
            return instance;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objIsoscelesTrapezoid.ReadData(txtSides, txtBaseI, txtBaseS, picCanvas);
            objIsoscelesTrapezoid.PerimeterIsoscelesTrapezoid();
            objIsoscelesTrapezoid.AreaIsoscelesTrapezoid();
            objIsoscelesTrapezoid.PrintData(txtPerimeter, txtArea);
            //objIsoscelesTrapezoid.PlotShape(picCanvas);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            objIsoscelesTrapezoid.InitializeData(txtSides, txtBaseI, txtBaseS, txtArea, txtPerimeter, picCanvas);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmIsoscelesTrapezoid_Load(object sender, EventArgs e)
        {
            objIsoscelesTrapezoid.InitializeData(txtSides, txtBaseI, txtBaseS, txtArea, txtPerimeter, picCanvas);
        }
    }


    class IsoscelesTrapezoid
    {
        private float mSides;
        private float mBaseS;
        private float mBaseI;
        private float mPerimeter;
        private float mArea;
        private float mHeight;
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;

        public IsoscelesTrapezoid()
        {
            mSides = 0.0f;
            mBaseI = 0.0f;
            mBaseS = 0.0f;
            mHeight = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtLateral, TextBox txtBaseInf, TextBox txtBaseSup, PictureBox picCanvas)
        {
            try
            {
                mSides = float.Parse(txtLateral.Text);
                mBaseS = float.Parse(txtBaseSup.Text);
                mBaseI = float.Parse(txtBaseInf.Text);
                if (mBaseI <= 0 || mBaseS <= 0 || mSides <= 0)
                {
                    MessageBox.Show("Los numeros deben ser positivos.", "Mensaje de error");
                    return;
                }
                HeightIsoscelesTrapezoid();
                picCanvas.Refresh();
            }
            catch
            {
                MessageBox.Show("Introduzca valores numericos.", "Mensaje de error");
            }
        }

        public void HeightIsoscelesTrapezoid()
        {
            if (mBaseI > mBaseS)
            {
                float diferenciaBases = (mBaseI - mBaseS) / 2;
                mHeight = (float)Math.Sqrt((mSides * mSides) - (diferenciaBases * diferenciaBases));
            }
            else
            {
                MessageBox.Show("La base inferior debe ser mayor que la superior para calcular la altura.", "Error");
            }
        }


        public void PerimeterIsoscelesTrapezoid()
        {
            mPerimeter = 2 * mSides + mBaseI + mBaseS;
        }

        public void AreaIsoscelesTrapezoid()
        {
            mArea = ((mBaseI + mBaseS) * mHeight) / 2;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void PlotShape(PictureBox picCanvas)
        {

            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);

            float diferenciaBases = (mBaseI - mBaseS) / 2;
            PointF[] puntos = new PointF[]
            {
                new PointF(100 + diferenciaBases * SF, 100), 
                new PointF(100 + (diferenciaBases + mBaseS) * SF, 100), 
                new PointF(100 + mBaseI * SF, 100 + mHeight * SF), 
                new PointF(100, 100 + mHeight * SF) 
            };

            mGraph.DrawPolygon(mPen, puntos);
        }

        public void InitializeData(TextBox txtSides, TextBox txtBaseI, TextBox txtBaseS, TextBox txtArea, TextBox txtPerimeter, PictureBox picCanvas)
        {
            txtPerimeter.Text = "";
            txtBaseI.Text = "";
            txtBaseS.Text = "";
            txtSides.Text = "";
            txtArea.Text = "";
            picCanvas.Refresh();
            txtSides.Focus();
        }
    }
}
