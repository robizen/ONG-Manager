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
		public FormMenu()
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
			FormUsuario1 userform1 = new FormUsuario1();
			userform1.MdiParent = this;
			userform1.Show();
		}
		void FormaciónToolStripMenuItemClick(object sender, EventArgs e)
		{
			FormFormacion1 formacionform1 = new FormFormacion1();
			formacionform1.MdiParent = this;
			formacionform1.Show();
		}
	}
}
