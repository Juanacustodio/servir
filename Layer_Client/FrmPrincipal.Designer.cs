﻿namespace Layer_Client
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdministrar = new System.Windows.Forms.ToolStripMenuItem();
            this.ofertaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuscarOferta = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPublicarOferta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentaToolStripMenuItem,
            this.ofertaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdministrar});
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.cuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // btnAdministrar
            // 
            this.btnAdministrar.Name = "btnAdministrar";
            this.btnAdministrar.Size = new System.Drawing.Size(136, 22);
            this.btnAdministrar.Text = "Administrar";
            this.btnAdministrar.Click += new System.EventHandler(this.BtnAdministrar_Click);
            // 
            // ofertaToolStripMenuItem
            // 
            this.ofertaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBuscarOferta,
            this.btnPublicarOferta});
            this.ofertaToolStripMenuItem.Name = "ofertaToolStripMenuItem";
            this.ofertaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ofertaToolStripMenuItem.Text = "Oferta";
            // 
            // btnBuscarOferta
            // 
            this.btnBuscarOferta.Name = "btnBuscarOferta";
            this.btnBuscarOferta.Size = new System.Drawing.Size(117, 22);
            this.btnBuscarOferta.Text = "Buscar";
            this.btnBuscarOferta.Click += new System.EventHandler(this.BtnBuscarOferta_Click);
            // 
            // btnPublicarOferta
            // 
            this.btnPublicarOferta.Name = "btnPublicarOferta";
            this.btnPublicarOferta.Size = new System.Drawing.Size(117, 22);
            this.btnPublicarOferta.Text = "Publicar";
            this.btnPublicarOferta.Click += new System.EventHandler(this.BtnPublicarOferta_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ofertaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnBuscarOferta;
        private System.Windows.Forms.ToolStripMenuItem btnPublicarOferta;
        private System.Windows.Forms.ToolStripMenuItem btnAdministrar;
    }
}