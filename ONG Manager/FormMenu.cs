/*
 * Creado por SharpDevelop.
 * Usuario: robiz
 * Fecha: 17/10/2017
 * Hora: 2:27
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ONG_Manager
{
	/// <summary>
	/// Description of FormMenu.
	/// </summary>
	public partial class FormMenu : Form
	{
		public FormMenu(int perfil)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void UsuarioToolStripMenuItemClick(object sender, EventArgs e)
		{
			Limpiarforms();
			FormArmario1 armarioform1 = new FormArmario1();
			armarioform1.MdiParent = this;
			armarioform1.Show();
		}
		void FormaciónToolStripMenuItemClick(object sender, EventArgs e)
		{
			Limpiarforms();
			FormFormacion1 formacionform1 = new FormFormacion1();
			formacionform1.MdiParent = this;
			formacionform1.Show();
		}
		
		void Limpiarforms()
		{
			if (this.MdiChildren.Length > 0)
			{
				this.ActiveMdiChild.Close();
			}
		}
		void PsicologíaToolStripMenuItemClick(object sender, EventArgs e)
		{
			Limpiarforms();
			FormPsico1 psicologia1 = new FormPsico1();
			psicologia1.MdiParent = this;
			psicologia1.Show();
		}
		void PuntoDeInformaciónToolStripMenuItemClick(object sender, EventArgs e)
		{
			Limpiarforms();
			FormInform1 informacion1 = new FormInform1();
			informacion1.MdiParent = this;
			informacion1.Show();
		}
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void InformesToolStripMenuItemClick(object sender, EventArgs e)
		{
			Limpiarforms();
			FormInformes informes1 = new FormInformes();
			informes1.MdiParent = this;
			informes1.Show();
		}
	}
}
