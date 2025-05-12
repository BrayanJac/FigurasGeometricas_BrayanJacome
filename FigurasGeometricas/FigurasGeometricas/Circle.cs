using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vnetanas
{
    public partial class frmCircle : Form
    {

        //Definicion de un objeto de tipo CCirculo
        private CCirculo objCircle = new CCirculo();
        private static frmCircle instance;

        private frmCircle()
        {
            InitializeComponent();
        }

        public static frmCircle getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmCircle();
            }
            return instance;
        }

        private void frmCircle_Load(object sender, EventArgs e)
        {
            //Inicializa los datos y controles
            //Llamada a la funcion InitializeData
            objCircle.InitializeData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculater_Click(object sender, EventArgs e)
        {
            //Lectura de datos
            //Llamada a la funcion ReadData
            objCircle.ReadData(txtRadius);
            //Calculo del perimetro de un rectangulo
            //Llamada a la funcion PerimeterRectangle
            objCircle.PerimeterRectangle();
            //Calculo del area de un rectangulo
            //Llamada a la funcion AreaRectangle
            objCircle.AreaRectangle();
            //Impresion de datos
            //Llamada a la funcion PrintData
            objCircle.PrintData(txtPerimeter, txtArea);
            //Graficacion de un rectangulo
            //Llamada a la funcion PlotShape
            //objCircle.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Inicializa los datos y controles
            //Llamada a la funcion InitializeData
            objCircle.InitializeData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Cierra el formulario
            //Llamada a la funcion CloseForm
            objCircle.CloseForm(this);
        }
    }


    class CCirculo
    {
        //Datos Miembro (ATRIBUTOS)

        //Ancho del circulo
        private float mRadius;
        //Perimetro del circulo
        private float mPerimeter;
        //Area del circulo
        private float mArea;
        //Objeto que activa el modo grafico
        private Graphics mGraph;
        //Constante scale factor (Zoom In/Zoom Out)
        private const float SF = 20;
        //Objeto boligrafo que dibuja o escribe en un lienzo (canvas).
        private Pen mPen;

        //Funciones Miembro (Metodos)

        //Constructor sin parametros
        public CCirculo()
        {
            mRadius = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        //Funcion que lee los datos de entrada del circulo
        public void ReadData(TextBox txtRadius)
        {
            try
            {
                mRadius = float.Parse(txtRadius.Text);

                if (mRadius <= 0)
                {
                    MessageBox.Show("Ingrese un numero positivo", "ERROR");
                    txtRadius.Focus();
                    mRadius = 0.0f;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no valido...", "Mensaje de error");
            }
        }

        //Funcion que calcula el perimetro del circulo
        public void PerimeterRectangle()
        {
            mPerimeter = 2 * mRadius * (float)Math.PI;
        }

        //Funcion que calcula el area del circulo
        public void AreaRectangle()
        {
            //mArea = (float)Math.PI * mRadius * mRadius;
            mArea = (float)Math.PI * (float)Math.Pow(mRadius, 2);
        }

        //Funcion que imprime el perimetro el area del circulo
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        //Funcion que inicializa los datos y controles del circulo
        public void InitializeData(TextBox txtRadius, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mRadius = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;

            txtRadius.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
            //Mantiene el cursor titilando en una caja de texto
            txtRadius.Focus();
            picCanvas.Refresh();
        }

        //Funcion que grafica un circulo 
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            //Graficar un circulo en base a una elipse
            mGraph.DrawEllipse(mPen, 0, 0, 2 * mRadius * SF, 2 * mRadius * SF);
        }

        //Funcion que cierra un formulario 
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }

    }
}
