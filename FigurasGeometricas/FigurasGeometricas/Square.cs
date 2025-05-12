using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    public partial class frmSquare : Form
    {
        private Square ObjSquare = new Square();

        private static frmSquare instance;

        private frmSquare()
        {
            InitializeComponent();
        }

        public static frmSquare getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmSquare();
            }
            return instance;
        }

        private void frmSquare_Load(object sender, EventArgs e)
        {
            ObjSquare.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            ObjSquare.ReadData(txtSide, picCanvas);
            ObjSquare.PerimeterSquare();
            ObjSquare.AreaSquare();
            ObjSquare.PrintData(txtPerimeter, txtArea);
            //ObjSquare.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjSquare.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjSquare.CloseForm(this);
        }

        
    }


    class Square
    {
        private float mSide;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        public Square()
        {
            mSide = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        public void ReadData(TextBox txtSide, PictureBox picCanvas)
        {
            try
            {
                mSide = float.Parse(txtSide.Text);
                if (mSide <= 0)
                {
                    MessageBox.Show("Ingrese un numero positivo", "ERROR");
                    txtSide.Focus();
                    mSide = 0.0f;
                    return;
                }
                picCanvas.Refresh();

            }
            catch
            {
                MessageBox.Show("Ingreso no valido. Introduzca valores numericos.", "Mensaje de error");
            }
        }

        public void PerimeterSquare()
        {
            mPerimeter = 4 * mSide;
        }

        public void AreaSquare()
        {
            mArea = mSide * mSide;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void InitializeData(TextBox txtSide, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mSide = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;

            txtSide.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
            txtSide.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            mGraph.DrawRectangle(mPen, 0, 0, mSide * SF, mSide * SF);  
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }

    }

    
}
