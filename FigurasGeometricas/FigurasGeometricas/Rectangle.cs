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
    public partial class frmRectangle : Form
    {
        //Definicion de un objeto de tipo CRectangle
        private CRectangle ObjRectangle = new CRectangle();

        private static frmRectangle instance;

        private frmRectangle()
        {
            InitializeComponent();
        }

        public static frmRectangle getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmRectangle();
            }
            return instance;
        }

        private void frmRectangle_Load(object sender, EventArgs e)
        {
            //Inicializa los datos y controles
            //Llamada a la funcion InitializeData
            ObjRectangle.InitializeData(txtWidth, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            //Lectura de datos
            //Llamada a la funcion ReadData
            ObjRectangle.ReadData(txtWidth, txtHeight, picCanvas);
            //Calculo del perimetro de un rectangulo
            //Llamada a la funcion PerimeterRectangle
            ObjRectangle.PerimeterRectangle();
            //Calculo del area de un rectangulo
            //Llamada a la funcion AreaRectangle
            ObjRectangle.AreaRectangle();
            //Impresion de datos
            //Llamada a la funcion PrintData
            ObjRectangle.PrintData(txtPerimeter, txtArea);
            //Graficacion de un rectangulo
            //Llamada a la funcion PlotShape
            //ObjRectangle.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Inicializa los datos y controles
            //Llamada a la funcion InitializeData
            ObjRectangle.InitializeData(txtWidth, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Cierra el formulario
            //Llamada a la funcion CloseForm
            ObjRectangle.CloseForm(this);
        }

        
    }


    class CRectangle
    {
        //Datos Miembro (ATRIBUTOS)

        //Ancho del rectangulo
        private float mWidth;
        //Ancho del rectangulo
        private float mHeight;
        //Perimetro del rectangulo
        private float mPerimeter;
        //Area del rectangulo
        private float mArea;
        //Objeto que activa el modo grafico
        private Graphics mGraph;
        //Constante scale factor (Zoom In/Zoom Out)
        private const float SF = 20;
        //Objeto boligrafo que dibuja o escribe en un lienzo (canvas).
        private Pen mPen;

        //Funciones Miembro (Metodos)

        //Constructor sin parametros
        public CRectangle()
        {
            mWidth = 0.0f; mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        //Funcion que lee los datos de entrada del rectangulo
        public bool ReadData(TextBox txtWidth, TextBox txtHeight, PictureBox picCanvas)
        {
            try
            {
                mWidth = float.Parse(txtWidth.Text);
                mHeight = float.Parse(txtHeight.Text);

                if (mWidth == mHeight)
                {
                    MessageBox.Show("El ancho y el alto no pueden ser iguales. No se permite un cuadrado.", "Validacion de entrada");
                    mWidth = 0;
                    mHeight = 0;
                    picCanvas.Refresh();
                    return false;
                }
                if (mWidth <= 0 || mHeight <= 0)
                {
                    MessageBox.Show("Ingrese un numero positivo", "ERROR");
                    txtWidth.Focus();
                    mWidth = 0.0f; mHeight = 0.0f;
                    return false;
                }

                picCanvas.Refresh();
                return true;
            }
            catch
            {
                MessageBox.Show("Ingreso no valido. Introduzca valores numericos.", "Mensaje de error");
                return false;
            }
        }


        //Funcion que calcula el perimetro del rectangulo
        public void PerimeterRectangle()
        {
            mPerimeter = 2 * (mWidth + mHeight);
        }

        //Funcion que calcula el area del rectangulo
        public void AreaRectangle()
        {
            mArea = mWidth * mHeight;
        }

        //Funcion que imprime el perimetro el area del rectangulo
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        //Funcion que inicializa los datos y controles del rectangulo
        public void InitializeData(TextBox txtWidth, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mHeight = 0.0f; mWidth = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;

            txtHeight.Text = ""; txtWidth.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
            //Mantiene el cursor titilando en una caja de texto
            txtWidth.Focus();
            picCanvas.Refresh();
        }

        //Funcion que grafica un rectangulo 
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            //Graficar un rectangulo
            mGraph.DrawRectangle(mPen, 0, 0, mWidth * SF, mHeight * SF);  
        }

        //Funcion que cierra un formulario 
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }

    }

    
}
