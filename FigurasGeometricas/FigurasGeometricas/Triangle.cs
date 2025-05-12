using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vnetanas;
using static System.Windows.Forms.MonthCalendar;

namespace Triangulo
{
    public partial class frmTriangle : Form
    {
        CTriangulo objTriangle = new CTriangulo();
        private static frmTriangle instance;

        private frmTriangle()
        {
            InitializeComponent();
        }
        public static frmTriangle getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmTriangle();
            }
            return instance;
        }

        private void FrmTriangulo_Load(object sender, EventArgs e)
        {
            objTriangle.InitializeData(txtSideA, txtSideB, txtSideC, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalcule_Click(object sender, EventArgs e)
        {
            objTriangle.ReadData(txtSideA,txtSideB,txtSideC);
            objTriangle.checkTriangle();
            objTriangle.PerimeterTriangle();
            objTriangle.AreaTriangle();    
            objTriangle.calculateAngleA();
            objTriangle.PrintData(txtPerimeter, txtArea);
            //objTriangle.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objTriangle.InitializeData(txtSideA, txtSideB, txtSideC, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           objTriangle.CloseForm(this);
        }
    }


    class CTriangulo
    {
        private float SideA;
        private float SideB;
        private float SideC;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;
        private PointF A;
        private PointF B;
        private PointF C;

        // Ángulo del vértice A en radianes
        private float angleA;

        public CTriangulo()
        {
            SideA = 0.0f; SideB = 0.0f; SideC = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        public void InitializeData(TextBox txtSideA, TextBox txtSideB, TextBox txtSideC, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            txtSideA.Text = "";
            txtSideB.Text = "";
            txtSideC.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            picCanvas.Refresh();
            txtSideA.Focus();
            txtSideB.Focus();
            txtSideC.Focus();
        }

        public void ReadData(TextBox txtSideA, TextBox txtSideB, TextBox txtSideC)
        {
            try
            {
                SideA = float.Parse(txtSideA.Text);
                SideB = float.Parse(txtSideB.Text);
                SideC = float.Parse(txtSideC.Text);

                if (SideA <= 0 || SideB <= 0 || SideC <= 0)
                {
                    MessageBox.Show("Los lados deben ser mayores a cero", "Mensaje de error");
                    txtSideA.Focus();
                    SideA = 0.0f; SideB = 0.0f; SideC = 0.0f;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no valido...", "Mensaje de error");
            }
        }

        public void PerimeterTriangle()
        {
            mPerimeter = SideA + SideB + SideC;
        }

        public void AreaTriangle()
        {
            float s = (SideA + SideB + SideC) / 2;
            mArea = (float)Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));

        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public bool checkTriangle()
        {
            if ((SideA + SideB > SideC) && (SideA + SideC > SideB) && (SideB + SideC < SideA))
            {
                return true;
            }
            else
                return false;
        }

        public void calculateAngleA()
        {
            angleA = (float)Math.Acos((SideB * SideB + SideC * SideC - SideA * SideA) / (2 * SideB * SideC));
        }
        private void calculateVertex()
        {
            A.X = 0.0f;
            A.Y = 0.0f;
            B.X = SideC;
            B.Y = 0.0f;

            calculateAngleA();
            C.X = SideB * (float)Math.Cos(angleA);
            C.Y = SideB * (float)Math.Sin(angleA);

        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);

            calculateVertex();

            mGraph.DrawLine(mPen, A.X * SF, A.Y * SF, B.X * SF, B.Y * SF);
            mGraph.DrawLine(mPen, A.X * SF, A.Y * SF, C.X * SF, C.Y * SF);
            mGraph.DrawLine(mPen, B.X * SF, B.Y * SF, C.X * SF, C.Y * SF);
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
