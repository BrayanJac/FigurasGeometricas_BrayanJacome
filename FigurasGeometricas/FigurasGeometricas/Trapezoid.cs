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

namespace Trapezoid
{
    public partial class frmTrapezoid : Form
    {
        private Trapezoid objTrapezoid = new Trapezoid();

        private static frmTrapezoid instance;

        private frmTrapezoid()
        {
            InitializeComponent();
        }

        public static frmTrapezoid getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmTrapezoid();
            }
            return instance;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objTrapezoid.ReadData(txtSideR, txtSideL, txtBaseI, txtBaseS, txtHeight, picCanvas);
            objTrapezoid.PerimeterTrapezoid();
            objTrapezoid.AreaTrapezoid();
            objTrapezoid.PrintData(txtPerimeter, txtArea);
            //objTrapezoid.PlotShape(picCanvas);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            objTrapezoid.InitializeData(txtSideR, txtSideL, txtBaseI, txtBaseS, txtHeight, txtArea, txtPerimeter, picCanvas);
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmTrapezoid_Load(object sender, EventArgs e)
        {
            objTrapezoid.InitializeData(txtSideR, txtSideL, txtBaseI, txtBaseS, txtHeight, txtArea, txtPerimeter, picCanvas);
        }
    }


    class Trapezoid
    {
        private float mSideR;
        private float mSideL;
        private float mBaseI;
        private float mBaseS;
        private float mHeight;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;

        public Trapezoid()
        {
            mSideR = 0.0f; mSideL = 0.0f; mBaseI = 0.0f; mBaseS = 0.0f;
            mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        public void ReadData(TextBox txtSideR, TextBox txtSideL, TextBox txtBaseI, TextBox txtBaseS, TextBox txtHeight, PictureBox picCanvas)
        {
            try
            {
                mSideR = float.Parse(txtSideR.Text);
                mSideL = float.Parse(txtSideL.Text);
                mBaseI = float.Parse(txtBaseI.Text);
                mBaseS = float.Parse(txtBaseS.Text);
                mHeight = float.Parse(txtHeight.Text);

                if (mBaseI <= 0 || mBaseS <= 0 || mSideR <= 0 || mSideL <= 0 || mHeight <= 0)
                {
                    MessageBox.Show("Todos los valores deben ser positivos.", "Mensaje de error");
                    mSideR = 0.0f; mSideL = 0.0f; 
                    mBaseI = 0.0f; mBaseS = 0.0f;
                    return;
                }

                picCanvas.Refresh();
            }
            catch
            {
                MessageBox.Show("Introduzca valores numéricos válidos.", "Mensaje de error");
            }
        }

        public void PerimeterTrapezoid()
        {
            mPerimeter = mSideR + mSideL + mBaseI + mBaseS;
        }

        public void AreaTrapezoid()
        {
            mArea = ((mBaseI + mBaseS) * mHeight) / 2;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("");
            txtArea.Text = mArea.ToString("");
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Green, 2);

            PointF[] points = new PointF[]
            {
                new PointF(100, 100),
                new PointF(100 + mBaseS * SF, 100),
                new PointF(100 + mBaseI * SF, 100 + mHeight * SF),
                new PointF(100 - (mBaseI - mBaseS) * SF, 100 + mHeight * SF) 
            };

            mGraph.DrawPolygon(mPen, points);
        }

        public void InitializeData(TextBox txtSideR, TextBox txtSideL, TextBox txtBaseI, TextBox txtBaseS, TextBox txtHeight,
            TextBox txtArea, TextBox txtPerimeter, PictureBox picCanvas)
        {
            txtSideR.Text = "";
            txtSideL.Text = "";
            txtBaseI.Text = "";
            txtBaseS.Text = "";
            txtHeight.Text = "";
            txtArea.Text = "";
            txtPerimeter.Text = "";
            picCanvas.Refresh();
            txtSideR.Focus();
        }
    }
}
