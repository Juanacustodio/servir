namespace Layer_Client
{
    partial class FrmAdminPrincipal
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdministrar = new System.Windows.Forms.ToolStripMenuItem();
            this.carreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centroDeEstudiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofertaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oRHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOSTULANTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuscarCarrera = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregarCarrera = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuscarCentroEstudios = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregarCentroEstudios = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuscarOferta = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregarOferta = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuscarORH = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregarORH = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuscarPostulante = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregarPostulante = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentaToolStripMenuItem,
            this.carreraToolStripMenuItem,
            this.centroDeEstudiosToolStripMenuItem,
            this.ofertaToolStripMenuItem,
            this.oRHToolStripMenuItem,
            this.pOSTULANTEToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
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
            this.btnAdministrar.Size = new System.Drawing.Size(180, 22);
            this.btnAdministrar.Text = "Administrar";
            // 
            // carreraToolStripMenuItem
            // 
            this.carreraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBuscarCarrera,
            this.btnAgregarCarrera});
            this.carreraToolStripMenuItem.Name = "carreraToolStripMenuItem";
            this.carreraToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.carreraToolStripMenuItem.Text = "Carrera";
            // 
            // centroDeEstudiosToolStripMenuItem
            // 
            this.centroDeEstudiosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBuscarCentroEstudios,
            this.btnAgregarCentroEstudios});
            this.centroDeEstudiosToolStripMenuItem.Name = "centroDeEstudiosToolStripMenuItem";
            this.centroDeEstudiosToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.centroDeEstudiosToolStripMenuItem.Text = "Centro de estudios";
            // 
            // ofertaToolStripMenuItem
            // 
            this.ofertaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBuscarOferta,
            this.btnAgregarOferta});
            this.ofertaToolStripMenuItem.Name = "ofertaToolStripMenuItem";
            this.ofertaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ofertaToolStripMenuItem.Text = "Oferta";
            // 
            // oRHToolStripMenuItem
            // 
            this.oRHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBuscarORH,
            this.btnAgregarORH});
            this.oRHToolStripMenuItem.Name = "oRHToolStripMenuItem";
            this.oRHToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.oRHToolStripMenuItem.Text = "ORH";
            // 
            // pOSTULANTEToolStripMenuItem
            // 
            this.pOSTULANTEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBuscarPostulante,
            this.btnAgregarPostulante});
            this.pOSTULANTEToolStripMenuItem.Name = "pOSTULANTEToolStripMenuItem";
            this.pOSTULANTEToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.pOSTULANTEToolStripMenuItem.Text = "Postulante";
            this.pOSTULANTEToolStripMenuItem.Click += new System.EventHandler(this.POSTULANTEToolStripMenuItem_Click);
            // 
            // btnBuscarCarrera
            // 
            this.btnBuscarCarrera.Name = "btnBuscarCarrera";
            this.btnBuscarCarrera.Size = new System.Drawing.Size(180, 22);
            this.btnBuscarCarrera.Text = "Buscar";
            this.btnBuscarCarrera.Click += new System.EventHandler(this.BtnBuscarCarrera_Click);
            // 
            // btnAgregarCarrera
            // 
            this.btnAgregarCarrera.Name = "btnAgregarCarrera";
            this.btnAgregarCarrera.Size = new System.Drawing.Size(180, 22);
            this.btnAgregarCarrera.Text = "Agregar";
            this.btnAgregarCarrera.Click += new System.EventHandler(this.BtnAgregarCarrera_Click);
            // 
            // btnBuscarCentroEstudios
            // 
            this.btnBuscarCentroEstudios.Name = "btnBuscarCentroEstudios";
            this.btnBuscarCentroEstudios.Size = new System.Drawing.Size(180, 22);
            this.btnBuscarCentroEstudios.Text = "Buscar";
            this.btnBuscarCentroEstudios.Click += new System.EventHandler(this.BtnBuscarCentroEstudios_Click);
            // 
            // btnAgregarCentroEstudios
            // 
            this.btnAgregarCentroEstudios.Name = "btnAgregarCentroEstudios";
            this.btnAgregarCentroEstudios.Size = new System.Drawing.Size(180, 22);
            this.btnAgregarCentroEstudios.Text = "Agregar";
            this.btnAgregarCentroEstudios.Click += new System.EventHandler(this.BtnAgregarCentroEstudios_Click);
            // 
            // btnBuscarOferta
            // 
            this.btnBuscarOferta.Name = "btnBuscarOferta";
            this.btnBuscarOferta.Size = new System.Drawing.Size(180, 22);
            this.btnBuscarOferta.Text = "Buscar";
            this.btnBuscarOferta.Click += new System.EventHandler(this.BtnBuscarOferta_Click);
            // 
            // btnAgregarOferta
            // 
            this.btnAgregarOferta.Name = "btnAgregarOferta";
            this.btnAgregarOferta.Size = new System.Drawing.Size(180, 22);
            this.btnAgregarOferta.Text = "Agregar";
            this.btnAgregarOferta.Click += new System.EventHandler(this.BtnAgregarOferta_Click);
            // 
            // btnBuscarORH
            // 
            this.btnBuscarORH.Name = "btnBuscarORH";
            this.btnBuscarORH.Size = new System.Drawing.Size(180, 22);
            this.btnBuscarORH.Text = "Buscar";
            this.btnBuscarORH.Click += new System.EventHandler(this.BtnBuscarORH_Click);
            // 
            // btnAgregarORH
            // 
            this.btnAgregarORH.Name = "btnAgregarORH";
            this.btnAgregarORH.Size = new System.Drawing.Size(180, 22);
            this.btnAgregarORH.Text = "Agregar";
            this.btnAgregarORH.Click += new System.EventHandler(this.BtnAgregarORH_Click);
            // 
            // btnBuscarPostulante
            // 
            this.btnBuscarPostulante.Name = "btnBuscarPostulante";
            this.btnBuscarPostulante.Size = new System.Drawing.Size(180, 22);
            this.btnBuscarPostulante.Text = "Buscar";
            this.btnBuscarPostulante.Click += new System.EventHandler(this.BtnBuscarPostulante_Click);
            // 
            // btnAgregarPostulante
            // 
            this.btnAgregarPostulante.Name = "btnAgregarPostulante";
            this.btnAgregarPostulante.Size = new System.Drawing.Size(180, 22);
            this.btnAgregarPostulante.Text = "Agregar";
            this.btnAgregarPostulante.Click += new System.EventHandler(this.BtnAgregarPostulante_Click);
            // 
            // FrmAdminPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAdminPrincipal";
            this.Text = "FrmAdminPrincipal";
            this.Load += new System.EventHandler(this.FrmAdminPrincipal_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAdministrar;
        private System.Windows.Forms.ToolStripMenuItem carreraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centroDeEstudiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ofertaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oRHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOSTULANTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnBuscarCarrera;
        private System.Windows.Forms.ToolStripMenuItem btnAgregarCarrera;
        private System.Windows.Forms.ToolStripMenuItem btnBuscarCentroEstudios;
        private System.Windows.Forms.ToolStripMenuItem btnAgregarCentroEstudios;
        private System.Windows.Forms.ToolStripMenuItem btnBuscarOferta;
        private System.Windows.Forms.ToolStripMenuItem btnAgregarOferta;
        private System.Windows.Forms.ToolStripMenuItem btnBuscarORH;
        private System.Windows.Forms.ToolStripMenuItem btnAgregarORH;
        private System.Windows.Forms.ToolStripMenuItem btnBuscarPostulante;
        private System.Windows.Forms.ToolStripMenuItem btnAgregarPostulante;
    }
}