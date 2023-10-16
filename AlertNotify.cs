using Alert.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Alert
{
    public partial class AlertNotify : Form
    {
        private Form bg;
        private Form parent;

        public Image Imagen
        {
            set
            {
                pbIcono.Image = value;
            }
        }

        public string Mensaje
        {
            set
            {
                lblTexto.Text = value;
            }
        }

        public Font Fuente
        {
            set
            {
                lblTexto.Font = value;
            }
        }

        public int Tiempo
        {
            set
            {
                Time.Interval = value;
                lblClose.Visible = false;
            }
        }

        public AlertNotify(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            confingBackGround();
        }

        private void confingBackGround()
        {
            bg = new Form();
            bg.Opacity = .70d;
            bg.BackColor = Color.Black;
            bg.TopMost = true;
            bg.Location = this.Location;
            bg.ShowInTaskbar = false;
            this.Owner = bg;
            bg.Show();

            Rectangle pBounds = parent.Bounds;
            bg.FormBorderStyle = parent.FormBorderStyle;
            bg.SetBounds(pBounds.X, pBounds.Y, pBounds.Width, pBounds.Height);
            bg.Size = parent.Size;
        }

        private void Alert_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, 20, 20), 180, 90);
            path.AddLine(20, 0, this.Width - 20, 0);
            path.AddArc(new Rectangle(this.Width - 20, 0, 20, 20), -90, 90);
            path.AddLine(this.Width, 20, this.Width, this.Height - 20);
            path.AddArc(new Rectangle(this.Width - 20, this.Height - 20, 20, 20), 0, 90);
            path.AddLine(this.Width - 20, this.Height, 20, this.Height);
            path.AddArc(new Rectangle(0, this.Height - 20, 20, 20), 90, 90);
            path.CloseFigure();

            this.Region = new System.Drawing.Region(path);

            // Obtener objeto Graphics del formulario
            Graphics graphics = this.CreateGraphics();

            // Establecer la propiedad SmoothingMode en AntiAlias
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibujar la figura geométrica en el formulario
            graphics.DrawPath(new Pen(Color.Gray, 1), path);

            // Liberar los recursos
            graphics.Dispose();
            Time.Start();
        }

        private void pnlFondo_Paint(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, 20, 20), 180, 90);
            path.AddLine(20, 0, pnlFondo.Width - 20, 0);
            path.AddArc(new Rectangle(pnlFondo.Width - 20, 0, 20, 20), -90, 90);
            path.AddLine(pnlFondo.Width, 20, pnlFondo.Width, pnlFondo.Height - 20);
            path.AddArc(new Rectangle(pnlFondo.Width - 20, pnlFondo.Height - 20, 20, 20), 0, 90);
            path.AddLine(pnlFondo.Width - 20, pnlFondo.Height, 20, pnlFondo.Height);
            path.AddArc(new Rectangle(0, pnlFondo.Height - 20, 20, 20), 90, 90);
            path.CloseFigure();

            pnlFondo.Region = new System.Drawing.Region(path);

            // Obtener objeto Graphics del formulario
            Graphics graphics = pnlFondo.CreateGraphics();

            // Establecer la propiedad SmoothingMode en AntiAlias
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibujar la figura geométrica en el formulario
            graphics.DrawPath(new Pen(Color.Gray, 1), path);

            // Liberar los recursos
            graphics.Dispose();
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            if (!lblClose.Visible)
            {
                this.TopMost = false;
                bg.TopMost = false;
                parent.Focus();
                parent.BringToFront();
                this.Dispose();
                bg.Dispose();
            }

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            bg.TopMost = false;
            parent.Focus();
            parent.BringToFront();
            this.Dispose();
            bg.Dispose();
        }


    }
}
