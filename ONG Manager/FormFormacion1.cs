/*
 * Creado por SharpDevelop.
 * Usuario: robiz
 * Fecha: 17/10/2017
 * Hora: 2:48
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ONG_Manager
{
	/// <summary>
	/// Description of FormFormacion1.
	/// </summary>
	public partial class FormFormacion1 : Form
	{
		public FormFormacion1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			FormFormacion2 formCurso = new FormFormacion2();
			formCurso.MdiParent = this.MdiParent;
			formCurso.Show();
		}
	}
}
