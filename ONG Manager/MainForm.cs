/*
 * Creado por SharpDevelop.
 * Usuario: robiz
 * Fecha: 17/10/2017
 * Hora: 2:26
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb; //DATASBASE ACCESS

namespace ONG_Manager
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string strcon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ONGMANAGER.mdb;Persist Security Info=True";
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			OleDbConnection conn = new OleDbConnection(strcon);
  			conn.Open();
  			MessageBox.Show(conn.State.ToString());
  			conn.Close();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			CargarMenu();
		}
		
		void CargarMenu()
		{
			FormMenu Menuform = new FormMenu();
			this.Hide();
			Menuform.Show();
		}
	}
}
