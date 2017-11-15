/*
 * Creado por SharpDevelop.
 * Usuario: robiz
 * Fecha: 17/10/2017
 * Hora: 2:27
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ONG_Manager
{
	partial class FormMenu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem psicologíaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sociosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem formaciónToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem puntoDeInformaciónToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bancoDeAlimentosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.puntoDeInformaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.formaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.psicologíaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bancoDeAlimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuToolStripMenuItem,
			this.puntoDeInformaciónToolStripMenuItem,
			this.usuarioToolStripMenuItem,
			this.formaciónToolStripMenuItem,
			this.psicologíaToolStripMenuItem,
			this.bancoDeAlimentosToolStripMenuItem,
			this.sociosToolStripMenuItem,
			this.informesToolStripMenuItem,
			this.administraciónToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(984, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.cerrarSesiónToolStripMenuItem,
			this.salirToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.menuToolStripMenuItem.Text = "Menú";
			// 
			// cerrarSesiónToolStripMenuItem
			// 
			this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
			this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// puntoDeInformaciónToolStripMenuItem
			// 
			this.puntoDeInformaciónToolStripMenuItem.Name = "puntoDeInformaciónToolStripMenuItem";
			this.puntoDeInformaciónToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
			this.puntoDeInformaciónToolStripMenuItem.Text = "Punto de Información";
			this.puntoDeInformaciónToolStripMenuItem.Click += new System.EventHandler(this.PuntoDeInformaciónToolStripMenuItemClick);
			// 
			// usuarioToolStripMenuItem
			// 
			this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
			this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.usuarioToolStripMenuItem.Text = "Armario";
			this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.UsuarioToolStripMenuItemClick);
			// 
			// formaciónToolStripMenuItem
			// 
			this.formaciónToolStripMenuItem.Name = "formaciónToolStripMenuItem";
			this.formaciónToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
			this.formaciónToolStripMenuItem.Text = "Formación";
			this.formaciónToolStripMenuItem.Click += new System.EventHandler(this.FormaciónToolStripMenuItemClick);
			// 
			// psicologíaToolStripMenuItem
			// 
			this.psicologíaToolStripMenuItem.Name = "psicologíaToolStripMenuItem";
			this.psicologíaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
			this.psicologíaToolStripMenuItem.Text = "Psicología";
			this.psicologíaToolStripMenuItem.Click += new System.EventHandler(this.PsicologíaToolStripMenuItemClick);
			// 
			// bancoDeAlimentosToolStripMenuItem
			// 
			this.bancoDeAlimentosToolStripMenuItem.Name = "bancoDeAlimentosToolStripMenuItem";
			this.bancoDeAlimentosToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
			this.bancoDeAlimentosToolStripMenuItem.Text = "Banco de Alimentos";
			this.bancoDeAlimentosToolStripMenuItem.Click += new System.EventHandler(this.BancoDeAlimentosToolStripMenuItemClick);
			// 
			// sociosToolStripMenuItem
			// 
			this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
			this.sociosToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.sociosToolStripMenuItem.Text = "Socios";
			// 
			// informesToolStripMenuItem
			// 
			this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
			this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.informesToolStripMenuItem.Text = "Informes";
			this.informesToolStripMenuItem.Click += new System.EventHandler(this.InformesToolStripMenuItemClick);
			// 
			// administraciónToolStripMenuItem
			// 
			this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
			this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
			this.administraciónToolStripMenuItem.Text = "Administración";
			// 
			// FormMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 761);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormMenu";
			this.Text = "FormMenu";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenuFormClosed);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
