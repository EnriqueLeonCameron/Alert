namespace Alert
{
    partial class AlertConfirm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlFondo = new Panel();
            btnNo = new Button();
            btnSi = new Button();
            lblClose = new Label();
            lblTexto = new Label();
            pbIcono = new PictureBox();
            panel1 = new Panel();
            pnlFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFondo
            // 
            pnlFondo.BackColor = Color.White;
            pnlFondo.Controls.Add(btnNo);
            pnlFondo.Controls.Add(btnSi);
            pnlFondo.Controls.Add(lblClose);
            pnlFondo.Controls.Add(lblTexto);
            pnlFondo.Controls.Add(pbIcono);
            pnlFondo.Location = new Point(1, 1);
            pnlFondo.Name = "pnlFondo";
            pnlFondo.Size = new Size(320, 238);
            pnlFondo.TabIndex = 0;
            pnlFondo.Paint += pnlFondo_Paint;
            // 
            // btnNo
            // 
            btnNo.FlatAppearance.BorderSize = 0;
            btnNo.FlatStyle = FlatStyle.Flat;
            btnNo.Location = new Point(173, 192);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(98, 34);
            btnNo.TabIndex = 5;
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            btnNo.MouseEnter += Bnt_MouseEnter;
            // 
            // btnSi
            // 
            btnSi.BackColor = Color.Transparent;
            btnSi.BackgroundImageLayout = ImageLayout.None;
            btnSi.FlatAppearance.BorderSize = 0;
            btnSi.FlatStyle = FlatStyle.Flat;
            btnSi.Location = new Point(58, 192);
            btnSi.Name = "btnSi";
            btnSi.Size = new Size(98, 34);
            btnSi.TabIndex = 4;
            btnSi.UseVisualStyleBackColor = false;
            btnSi.Click += btnSi_Click;
            btnSi.MouseEnter += Bnt_MouseEnter;
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.Font = new Font("Lucida Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClose.ForeColor = Color.DimGray;
            lblClose.Location = new Point(291, 5);
            lblClose.Margin = new Padding(3, 12, 12, 0);
            lblClose.Name = "lblClose";
            lblClose.Padding = new Padding(0, 10, 10, 0);
            lblClose.Size = new Size(26, 25);
            lblClose.TabIndex = 2;
            lblClose.Text = "X";
            lblClose.Click += lblClose_Click;
            // 
            // lblTexto
            // 
            lblTexto.Font = new Font("Lucida Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTexto.ForeColor = Color.DimGray;
            lblTexto.Location = new Point(12, 135);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(299, 52);
            lblTexto.TabIndex = 1;
            lblTexto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbIcono
            // 
            pbIcono.Image = Properties.Resources.Success;
            pbIcono.InitialImage = Properties.Resources.Caution;
            pbIcono.Location = new Point(99, 12);
            pbIcono.Name = "pbIcono";
            pbIcono.Size = new Size(120, 120);
            pbIcono.SizeMode = PictureBoxSizeMode.Zoom;
            pbIcono.TabIndex = 0;
            pbIcono.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(pnlFondo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 239);
            panel1.TabIndex = 3;
            // 
            // AlertConfirm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 239);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "AlertConfirm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Alert";
            TopMost = true;
            Load += Alert_Load;
            pnlFondo.ResumeLayout(false);
            pnlFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFondo;
        private PictureBox pbIcono;
        private Label lblTexto;
        private Label lblClose;
        private Panel panel1;
        private Button btnSi;
        private Button btnNo;
    }
}