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

namespace Diamond
{
    public partial class frmDiamond : Form
    {

        private Diamond objDiamond = new Diamond();

        private static frmDiamond instance;

        private frmDiamond()
        {
            InitializeComponent();
        }

        public static frmDiamond getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmDiamond();
            }
            return instance;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            objDiamond.ReadData(txtSide,txtDiagonalS,txtDiagonalI, picCanvas);
            objDiamond.PerimeterDiamond();
            objDiamond.AreaDiamond();

            objDiamond.PrintData(txtPerimeter, txtArea);
            //objDiamond.PlotShape(picCanvas);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            objDiamond.InitializeData(txtSide, txtDiagonalS, txtDiagonalI, txtPerimeter, txtArea, picCanvas);
        } 

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDiamond_Load(object sender, EventArgs e)
        {
            objDiamond.InitializeData(txtSide, txtDiagonalS, txtDiagonalI, txtPerimeter, txtArea, picCanvas);
        }
    }


    class Diamond
    {
        private float mSide;
        private float mDiagonalS;
        private float mDiagonalI;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;

        public Diamond()
        {
            mSide = 0.0f;
            mDiagonalS = 0.0f;
            mDiagonalI = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtSide, TextBox txtDiagonalS, TextBox txtDiagonalI, PictureBox picCanvas)
        {
            try
            {
                mSide = float.Parse(txtSide.Text);
                mDiagonalS = float.Parse(txtDiagonalS.Text);
                mDiagonalI = float.Parse(txtDiagonalI.Text);

                if (mSide <= 0 || mDiagonalS <= 0 || mDiagonalI <= 0)
                {
                    MessageBox.Show("Los numeros deben ser positivos", "Mensaje de error");
                    mSide = 0;
                    mDiagonalS = 0;
                    mDiagonalI = 0;
                    return;
                }
                picCanvas.Refresh();
            }
            catch
            {
                MessageBox.Show("Introduzca valores numericos.", "Mensaje de error");
            }
        }

        public void PerimeterDiamond()
        {
            mPerimeter = 4 * mSide;
        }

        public void AreaDiamond()
        {
            mArea = (mDiagonalS * mDiagonalI) / 2;
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

            float halfDiagonalS = mDiagonalS / 2;
            float halfDiagonalI = mDiagonalI / 2;

            PointF point1 = new PointF(picCanvas.Width / 2 - halfDiagonalS * SF, picCanvas.Height / 2);
            PointF point2 = new PointF(picCanvas.Width / 2, picCanvas.Height / 2 - halfDiagonalI * SF);
            PointF point3 = new PointF(picCanvas.Width / 2 + halfDiagonalS * SF, picCanvas.Height / 2);
            PointF point4 = new PointF(picCanvas.Width / 2, picCanvas.Height / 2 + halfDiagonalI * SF);

            mGraph.DrawPolygon(mPen, new PointF[] { point1, point2, point3, point4 });
        }

        public void InitializeData(TextBox txtSide, TextBox txtDiagonalS, TextBox txtDiagonalI, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            txtSide.Text = "";
            txtDiagonalS.Text = "";
            txtDiagonalI.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            picCanvas.Refresh();
            txtSide.Focus();
        }
    }
}
