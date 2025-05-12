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

namespace Oval
{
    public partial class frmOval : Form
    {

        private Oval objOval = new Oval();

        private static frmOval instance;

        private frmOval()
        {
            InitializeComponent();
        }

        public static frmOval getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmOval();
            }
            return instance;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            objOval.ReadData(txtMajorAxis,txtMinorAxis, picCanvas);
            objOval.CalculePerimeter();
            objOval.CalculeArea();

            objOval.PrintData(txtPerimeter, txtArea);
            //objOval.PlotShape(picCanvas);
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            objOval.InitializeData(txtMajorAxis, txtMinorAxis, txtPerimeter, txtArea, picCanvas);
        } 

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmOval_Load(object sender, EventArgs e)
        {
            objOval.InitializeData( txtMajorAxis, txtMinorAxis, txtPerimeter, txtArea, picCanvas);
        }
    }


    class Oval
    {
        private float mMajorSemiAxis; 
        private float mMinorSemiAxis; 
        private float mPerimeter;
        private float mArea;
        private Graphics graph;
        private Pen pen;
        private const float SF = 20;

        public Oval()
        {
            mMajorSemiAxis = 0.0f; mMinorSemiAxis = 0.0f;
           mPerimeter = 0.0f; mArea = 0.0f;
        }

        public void ReadData(TextBox txtMajorAxis, TextBox txtMinorAxis, PictureBox picCanvas)
        {
            try
            {
                mMajorSemiAxis = float.Parse(txtMajorAxis.Text);
                mMinorSemiAxis = float.Parse(txtMinorAxis.Text); 

                if (mMajorSemiAxis <= 0 || mMinorSemiAxis <= 0)
                {
                    MessageBox.Show("Los números deben ser positivos.", "Error");
                    mMajorSemiAxis = 0.0f;
                    mMinorSemiAxis = 0.0f;
                    return;
                }

                picCanvas.Refresh();
            }
            catch
            {
                MessageBox.Show("Introduzca valores numericos válidos.", "Error");
            }
        }

        public void CalculePerimeter()
        {
            mPerimeter = (float)(Math.PI * (3 * (mMajorSemiAxis + mMinorSemiAxis) - Math.Sqrt((3 * mMajorSemiAxis + mMinorSemiAxis) * (mMajorSemiAxis + 3 * mMinorSemiAxis))));
        }

        public void CalculeArea()
        {
            mArea = (float)(Math.PI * mMajorSemiAxis * mMinorSemiAxis);
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("");
            txtArea.Text = mArea.ToString("");
        }

        public void PlotShape(PictureBox picCanvas)
        {
            graph = picCanvas.CreateGraphics();
            pen = new Pen(Color.Blue, 2);

            float width = mMajorSemiAxis * 2 * SF;
            float height = mMinorSemiAxis * 2 * SF;

            float x = (picCanvas.Width - width) / 2;
            float y = (picCanvas.Height - height) / 2;

            graph.DrawEllipse(pen, x, y, width, height);
        }

        public void InitializeData(TextBox txtMajorAxis, TextBox txtMinorAxis, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            txtMajorAxis.Text = "";
            txtMinorAxis.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            picCanvas.Refresh();
            txtMajorAxis.Focus();
        }
    }

}
