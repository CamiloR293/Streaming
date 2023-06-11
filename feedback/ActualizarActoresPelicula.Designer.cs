namespace Streaming.feedback
{
    partial class ActualizarActoresPelicula
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
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.cmbBoxPapel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbBoxActor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBoxPelicula = new System.Windows.Forms.ComboBox();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDesktop.SuspendLayout();
            this.pnlBanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(194)))), ((int)(((byte)(157)))));
            this.pnlDesktop.Controls.Add(this.cmbBoxPapel);
            this.pnlDesktop.Controls.Add(this.label6);
            this.pnlDesktop.Controls.Add(this.txtFechaNacimiento);
            this.pnlDesktop.Controls.Add(this.label5);
            this.pnlDesktop.Controls.Add(this.txtSegundoApellido);
            this.pnlDesktop.Controls.Add(this.label3);
            this.pnlDesktop.Controls.Add(this.txtSegundoNombre);
            this.pnlDesktop.Controls.Add(this.label4);
            this.pnlDesktop.Controls.Add(this.txtPrimerApellido);
            this.pnlDesktop.Controls.Add(this.lblApellido);
            this.pnlDesktop.Controls.Add(this.txtPrimerNombre);
            this.pnlDesktop.Controls.Add(this.lblNombre);
            this.pnlDesktop.Controls.Add(this.cmbBoxActor);
            this.pnlDesktop.Controls.Add(this.label2);
            this.pnlDesktop.Controls.Add(this.cmbBoxPelicula);
            this.pnlDesktop.Controls.Add(this.lblPelicula);
            this.pnlDesktop.Controls.Add(this.btnActualizar);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(0, 67);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(607, 416);
            this.pnlDesktop.TabIndex = 6;
            // 
            // cmbBoxPapel
            // 
            this.cmbBoxPapel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBoxPapel.FormattingEnabled = true;
            this.cmbBoxPapel.Items.AddRange(new object[] {
            "Principal",
            "Secundario"});
            this.cmbBoxPapel.Location = new System.Drawing.Point(271, 92);
            this.cmbBoxPapel.Name = "cmbBoxPapel";
            this.cmbBoxPapel.Size = new System.Drawing.Size(144, 21);
            this.cmbBoxPapel.TabIndex = 44;
            this.cmbBoxPapel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(151, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 43;
            this.label6.Text = "Papel:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFechaNacimiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNacimiento.Location = new System.Drawing.Point(271, 275);
            this.txtFechaNacimiento.Multiline = true;
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(196, 20);
            this.txtFechaNacimiento.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 21);
            this.label5.TabIndex = 41;
            this.label5.Text = "Fecha de nacimiento:";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSegundoApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSegundoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoApellido.Location = new System.Drawing.Point(347, 223);
            this.txtSegundoApellido.Multiline = true;
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(188, 20);
            this.txtSegundoApellido.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 21);
            this.label3.TabIndex = 39;
            this.label3.Text = "Segundo apellido:";
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSegundoNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSegundoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoNombre.Location = new System.Drawing.Point(347, 158);
            this.txtSegundoNombre.Multiline = true;
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(188, 20);
            this.txtSegundoNombre.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Segundo nombre:";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrimerApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrimerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerApellido.Location = new System.Drawing.Point(37, 223);
            this.txtPrimerApellido.Multiline = true;
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(180, 20);
            this.txtPrimerApellido.TabIndex = 36;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(33, 199);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(132, 21);
            this.lblApellido.TabIndex = 35;
            this.lblApellido.Text = "Primer apellido:";
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrimerNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrimerNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerNombre.Location = new System.Drawing.Point(37, 158);
            this.txtPrimerNombre.Multiline = true;
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(180, 20);
            this.txtPrimerNombre.TabIndex = 34;
            this.txtPrimerNombre.TextChanged += new System.EventHandler(this.txtPrimerNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(33, 134);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(129, 21);
            this.lblNombre.TabIndex = 33;
            this.lblNombre.Text = "Primer nombre:";
            // 
            // cmbBoxActor
            // 
            this.cmbBoxActor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBoxActor.FormattingEnabled = true;
            this.cmbBoxActor.Location = new System.Drawing.Point(271, 54);
            this.cmbBoxActor.Name = "cmbBoxActor";
            this.cmbBoxActor.Size = new System.Drawing.Size(144, 21);
            this.cmbBoxActor.TabIndex = 30;
            this.cmbBoxActor.SelectedIndexChanged += new System.EventHandler(this.cmbBoxActor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "Actor:";
            // 
            // cmbBoxPelicula
            // 
            this.cmbBoxPelicula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBoxPelicula.FormattingEnabled = true;
            this.cmbBoxPelicula.Location = new System.Drawing.Point(271, 16);
            this.cmbBoxPelicula.Name = "cmbBoxPelicula";
            this.cmbBoxPelicula.Size = new System.Drawing.Size(144, 21);
            this.cmbBoxPelicula.TabIndex = 28;
            this.cmbBoxPelicula.SelectedIndexChanged += new System.EventHandler(this.cmbBoxPelicula_SelectedIndexChanged);
            // 
            // lblPelicula
            // 
            this.lblPelicula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelicula.Location = new System.Drawing.Point(151, 16);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(75, 21);
            this.lblPelicula.TabIndex = 27;
            this.lblPelicula.Text = "Pelicula:";
            this.lblPelicula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(117)))));
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(76)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizar.Location = new System.Drawing.Point(430, 324);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(106, 40);
            this.btnActualizar.TabIndex = 26;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // pnlBanner
            // 
            this.pnlBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(117)))));
            this.pnlBanner.Controls.Add(this.label1);
            this.pnlBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBanner.Location = new System.Drawing.Point(0, 0);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Size = new System.Drawing.Size(607, 67);
            this.pnlBanner.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(180, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "ACTUALIZAR ACTORES";
            // 
            // ActualizarActoresPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 483);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActualizarActoresPelicula";
            this.Text = "ActualizarActoresPelicula";
            this.pnlDesktop.ResumeLayout(false);
            this.pnlDesktop.PerformLayout();
            this.pnlBanner.ResumeLayout(false);
            this.pnlBanner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.ComboBox cmbBoxActor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBoxPelicula;
        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBoxPapel;
        private System.Windows.Forms.Label label6;
    }
}