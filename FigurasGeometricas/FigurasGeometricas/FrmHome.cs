using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Deltoid;
using Diamond;
using Ellipse;
using Figuras;
using IsoscelesTrapezoid;
using Jacome_Leccion;
using Oval;
using Rhomboid;
using Trapezium;
using Trapezoid;
using Triangulo;
using Vnetanas;

namespace FigurasGeometricas
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRectangle frm2 = frmRectangle.getInstance();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCircle frm2 = frmCircle.getInstance();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTriangle frm2 = frmTriangle.getInstance();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void pentagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPentagon frm2 = FrmPentagon.getInstance();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void hexagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHexagon frm2 = FrmHexagon.getInstance();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void octagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOctagon frm2 = FrmOctagon.getInstance();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void pentagonoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmHeptagon frm2 = FrmHeptagon.getInstance();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void eneagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEnneagon frm2 = FrmEnneagon.getInstance();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void decagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDecagon frm2 = FrmDecagon.getInstance();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSquare frm2 = frmSquare.getInstance();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiamond frm2 = frmDiamond.getInstance();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRhomboid frm2 = frmRhomboid.getInstance();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void deltoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeltoid frm2 = frmDeltoid.getInstance();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEllipse frm2 = frmEllipse.getInstance();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void ovaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOval frm2 = frmOval.getInstance();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void trapecioIsoscelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsoscelesTrapezoid frm2 = frmIsoscelesTrapezoid.getInstance();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void trapezoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrapezoid frm2 = frmTrapezoid.getInstance();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrapezium frm2 = frmTrapezium.getInstance();
            frm2.MdiParent = this;
            frm2.Show();
        }
    }
}
