using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figuras;
using static System.Windows.Forms.MonthCalendar;

namespace Rhomboid
{
    public partial class frmRhomboid : Form
    {

        private Rhomboid objRhomboid = new Rhomboid();

        private static frmRhomboid instance;

        private frmRhomboid()
        {
            InitializeComponent();
        }

        public static frmRhomboid getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmRhomboid();
            }
            return instance;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            objRhomboid.ReadData(txtSide,txtBase,txtHeight, picCanvas);
            objRhomboid.PerimeterRhomboid();
            objRhomboid.AreaRhomboid();

            objRhomboid.PrintData(txtPerimeter, txtArea);
            //objRhomboid.PlotShape(picCanvas);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            objRhomboid.InitializeData(txtSide, txtBase, txtHeight, txtPerimeter, txtArea, picCanvas);
        } 

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRhomboid_Load(object sender, EventArgs e)
        {
            objRhomboid.InitializeData(txtSide, txtBase, txtHeight, txtPerimeter, txtArea, picCanvas);
        }
    }


    class Rhomboid
    {
        private float mBase;
        private float mSide;
        private float mHeight;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 10;

        public Rhomboid()
        {
            mBase = 0.0f; mSide = 0.0f; mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        public void ReadData(TextBox txtBase, TextBox txtLade, TextBox txtHeight, PictureBox picCanvas)
        {
            try
            {
                mBase = float.Parse(txtBase.Text);
                mSide = float.Parse(txtLade.Text);
                mHeight = float.Parse(txtHeight.Text);

                if (mBase <= 0 || mSide <= 0 || mHeight <= 0)
                {
                    MessageBox.Show("Los numeros deben ser positivos", "Error");
                    mSide = 0.0f;
                    mBase = 0.0f;
                    mHeight = 0.0f;
                    return;
                }
                picCanvas.Refresh();
            }
            catch
            {
                MessageBox.Show("Introduzca valores numericos.", "Error");
            }
        }

        public void PerimeterRhomboid()
        {
            mPerimeter = 2 * (mBase + mSide);
        }

        public void AreaRhomboid()
        {
            mArea = mBase * mHeight;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Green, 2);

            float offset = mHeight * SF / 2;
            float baseDraw = mBase * SF;
            float alturaDraw = mHeight * SF;

            PointF p1 = new PointF(50 + offset, 50);
            PointF p2 = new PointF(50 + offset + baseDraw, 50);
            PointF p3 = new PointF(50 + baseDraw, 50 + alturaDraw);
            PointF p4 = new PointF(50, 50 + alturaDraw);

            mGraph.DrawPolygon(mPen, new PointF[] { p1, p2, p3, p4 });
        }

        public void InitializeData(TextBox txtBase, TextBox txtLade, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            txtBase.Text = "";
            txtLade.Text = "";
            txtHeight.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            picCanvas.Refresh();
            txtBase.Focus();
        }
    }
}
