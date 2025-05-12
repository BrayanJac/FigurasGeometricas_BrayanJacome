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

namespace Deltoid
{
    public partial class frmDeltoid : Form
    {

        private Deltoid objDeltoid = new Deltoid();

        private static frmDeltoid instance;

        private frmDeltoid()
        {
            InitializeComponent();
        }

        public static frmDeltoid getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmDeltoid();
            }
            return instance;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            objDeltoid.ReadData(txtShortSide, txtLongSide, txtMajorDiagonal, txtMinorDiagonal, picCanvas);
            objDeltoid.CalculatemPerimeter();
            objDeltoid.CalculatemArea();

            objDeltoid.PrintData(txtPerimeter, txtArea);
            //objDeltoid.PlotShape(picCanvas);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            objDeltoid.InitializeData(txtShortSide, txtLongSide, txtMajorDiagonal, txtMinorDiagonal, txtPerimeter, txtArea, picCanvas);
        } 

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDeltoid_Load(object sender, EventArgs e)
        {
            objDeltoid.InitializeData(txtShortSide, txtLongSide, txtMajorDiagonal, txtMinorDiagonal, txtPerimeter, txtArea, picCanvas);
        }
    }


    class Deltoid
    {
        private float mShortSide;
        private float mLongSide;
        private float mMajorDiagonal;
        private float mMinorDiagonal;
        private float mArea;
        private float mPerimeter;
        private Graphics g;
        private Pen pen;
        private const float SF = 20;

        public Deltoid()
        {
            mShortSide = 0.0f; mLongSide = 0.0f;
            mMajorDiagonal = 0.0f; mMinorDiagonal = 0.0f;
            mArea = 0.0f; mPerimeter = 0.0f;
        }

        public void ReadData(TextBox txtShortSide, TextBox txtLongSide, TextBox txtD1, TextBox txtD2, PictureBox picCanvas)
        {
            try
            {
                mShortSide = float.Parse(txtShortSide.Text);
                mLongSide = float.Parse(txtLongSide.Text);
                mMajorDiagonal = float.Parse(txtD1.Text);
                mMinorDiagonal = float.Parse(txtD2.Text);

                if (mShortSide <= 0 || mLongSide <= 0 || mMajorDiagonal <= 0 || mMinorDiagonal <= 0)
                {
                    MessageBox.Show("Los numeros deben ser positivos", "Error");
                    txtShortSide.Focus();
                    mShortSide = 0.0f; mLongSide = 0.0f;
                    mMajorDiagonal = 0.0f; mMinorDiagonal = 0.0f;
                }
                picCanvas.Refresh();
                
            }
            catch
            {
                MessageBox.Show("Ingrese valores numericos", "Error");
            }
        }

        public void CalculatemPerimeter()
        {
            mPerimeter = 2 * (mShortSide + mLongSide);
        }

        public void CalculatemArea()
        {
            mArea = (mMajorDiagonal * mMinorDiagonal) / 2;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void PlotShape(PictureBox canvas)
        {
            g = canvas.CreateGraphics();
            pen = new Pen(Color.Red, 2);
            canvas.Refresh();

            float scale = SF;
            float cx = canvas.Width / 2;
            float cy = canvas.Height / 2;

            float halfDMayor = mMajorDiagonal * scale / 2;
            float halfDMenor = mMinorDiagonal * scale / 2;
            float halfDLong = mLongSide * scale / 2;
            float halfDShort = mShortSide * scale / 2;

            PointF top = new PointF(cx, cy - halfDMayor);
            PointF bottom = new PointF(cx, cy + halfDMayor);

            PointF left = new PointF(cx - halfDLong, cy);
            PointF right = new PointF(cx + halfDShort, cy);

            g.DrawPolygon(pen, new PointF[] { top, right, bottom, left });
        }

        public void InitializeData(TextBox txtShortSide, TextBox txtLongSide, TextBox txtD1, TextBox txtD2, TextBox txtPerimeter, TextBox txtArea, PictureBox canvas)
        {
            txtShortSide.Text = "";
            txtLongSide.Text = "";
            txtD1.Text = "";
            txtD2.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            canvas.Refresh();
            txtShortSide.Focus();
        }
    }
}
