namespace Streaming.feedback
{
    partial class Recomendaciones
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
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.flowPanelPeliculasRelacionadas = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(76)))));
            this.pnlLateral.Controls.Add(this.btnCerrarSesion);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(232, 863);
            this.pnlLateral.TabIndex = 3;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 732);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(232, 131);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Volver";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // flowPanelPeliculasRelacionadas
            // 
            this.flowPanelPeliculasRelacionadas.AutoScroll = true;
            this.flowPanelPeliculasRelacionadas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowPanelPeliculasRelacionadas.Location = new System.Drawing.Point(232, 118);
            this.flowPanelPeliculasRelacionadas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowPanelPeliculasRelacionadas.Name = "flowPanelPeliculasRelacionadas";
            this.flowPanelPeliculasRelacionadas.Size = new System.Drawing.Size(688, 745);
            this.flowPanelPeliculasRelacionadas.TabIndex = 29;
            // 
            // Recomendaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 863);
            this.Controls.Add(this.flowPanelPeliculasRelacionadas);
            this.Controls.Add(this.pnlLateral);
            this.Name = "Recomendaciones";
            this.Text = "Recomendaciones";
            this.pnlLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.FlowLayoutPanel flowPanelPeliculasRelacionadas;
    }
}