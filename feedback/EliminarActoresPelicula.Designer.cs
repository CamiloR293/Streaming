﻿namespace Streaming.feedback
{
    partial class EliminarActoresPelicula
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
            this.pnlDesktop.Controls.Add(this.cmbBoxActor);
            this.pnlDesktop.Controls.Add(this.label2);
            this.pnlDesktop.Controls.Add(this.cmbBoxPelicula);
            this.pnlDesktop.Controls.Add(this.lblPelicula);
            this.pnlDesktop.Controls.Add(this.btnActualizar);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(0, 67);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(607, 416);
            this.pnlDesktop.TabIndex = 8;
            this.pnlDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDesktop_Paint);
            // 
            // cmbBoxActor
            // 
            this.cmbBoxActor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBoxActor.FormattingEnabled = true;
            this.cmbBoxActor.Location = new System.Drawing.Point(271, 184);
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
            this.label2.Location = new System.Drawing.Point(151, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "Actor:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbBoxPelicula
            // 
            this.cmbBoxPelicula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBoxPelicula.FormattingEnabled = true;
            this.cmbBoxPelicula.Location = new System.Drawing.Point(271, 108);
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
            this.lblPelicula.Location = new System.Drawing.Point(151, 108);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(75, 21);
            this.lblPelicula.TabIndex = 27;
            this.lblPelicula.Text = "Pelicula:";
            this.lblPelicula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPelicula.Click += new System.EventHandler(this.lblPelicula_Click);
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
            this.btnActualizar.Text = "Eliminar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // pnlBanner
            // 
            this.pnlBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(117)))));
            this.pnlBanner.Controls.Add(this.label1);
            this.pnlBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBanner.Location = new System.Drawing.Point(0, 0);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Size = new System.Drawing.Size(607, 67);
            this.pnlBanner.TabIndex = 7;
            this.pnlBanner.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBanner_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(180, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "ELIMINAR ACTORES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EliminarActoresPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 483);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarActoresPelicula";
            this.Text = "EliminarActoresPelicula";
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
    }
}