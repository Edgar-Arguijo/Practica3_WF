namespace Practica3_WF
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.btnRevisar = new System.Windows.Forms.Button();
            this.txtError = new System.Windows.Forms.TextBox();
            this.gpError = new System.Windows.Forms.GroupBox();
            this.txtMsgError = new System.Windows.Forms.TextBox();
            this.cboPredet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gpError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCadena
            // 
            this.txtCadena.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtCadena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtCadena.Location = new System.Drawing.Point(274, 61);
            this.txtCadena.Margin = new System.Windows.Forms.Padding(4);
            this.txtCadena.Multiline = true;
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(332, 214);
            this.txtCadena.TabIndex = 0;
            this.txtCadena.Text = "string cadena = \"Hola mundo\";";
            // 
            // btnRevisar
            // 
            this.btnRevisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRevisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevisar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnRevisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRevisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRevisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRevisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRevisar.Location = new System.Drawing.Point(91, 282);
            this.btnRevisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRevisar.Name = "btnRevisar";
            this.btnRevisar.Size = new System.Drawing.Size(78, 28);
            this.btnRevisar.TabIndex = 1;
            this.btnRevisar.Text = "Revisar";
            this.btnRevisar.UseVisualStyleBackColor = false;
            this.btnRevisar.Click += new System.EventHandler(this.btnRevisar_Click);
            // 
            // txtError
            // 
            this.txtError.BackColor = System.Drawing.Color.Green;
            this.txtError.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtError.Location = new System.Drawing.Point(12, 247);
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(248, 28);
            this.txtError.TabIndex = 3;
            this.txtError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gpError
            // 
            this.gpError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gpError.Controls.Add(this.txtMsgError);
            this.gpError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.gpError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gpError.Location = new System.Drawing.Point(12, 75);
            this.gpError.Name = "gpError";
            this.gpError.Size = new System.Drawing.Size(248, 166);
            this.gpError.TabIndex = 5;
            this.gpError.TabStop = false;
            this.gpError.Text = "Información: del Error: ";
            // 
            // txtMsgError
            // 
            this.txtMsgError.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtMsgError.Location = new System.Drawing.Point(9, 22);
            this.txtMsgError.Multiline = true;
            this.txtMsgError.Name = "txtMsgError";
            this.txtMsgError.ReadOnly = true;
            this.txtMsgError.Size = new System.Drawing.Size(232, 129);
            this.txtMsgError.TabIndex = 0;
            // 
            // cboPredet
            // 
            this.cboPredet.BackColor = System.Drawing.Color.AliceBlue;
            this.cboPredet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cboPredet.FormattingEnabled = true;
            this.cboPredet.ItemHeight = 13;
            this.cboPredet.Items.AddRange(new object[] {
            "Ingresar un numero (Consola)",
            "Suma de dos números",
            "Restar -1 a un número"});
            this.cboPredet.Location = new System.Drawing.Point(12, 42);
            this.cboPredet.Name = "cboPredet";
            this.cboPredet.Size = new System.Drawing.Size(248, 21);
            this.cboPredet.TabIndex = 6;
            this.cboPredet.Text = "Básico";
            this.cboPredet.SelectedIndexChanged += new System.EventHandler(this.cboPredet_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(273, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Código Predefinido:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(857, 31);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCerrar.Location = new System.Drawing.Point(588, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 23);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(45, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Errores de Compilación";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(621, 324);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboPredet);
            this.Controls.Add(this.gpError);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.btnRevisar);
            this.Controls.Add(this.txtCadena);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Práctica 3";
            this.gpError.ResumeLayout(false);
            this.gpError.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Button btnRevisar;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.GroupBox gpError;
        private System.Windows.Forms.ComboBox cboPredet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMsgError;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

