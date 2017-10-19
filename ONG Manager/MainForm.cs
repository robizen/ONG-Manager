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
//using System.Data.OleDb; //DATASBASE ACCESS ** Ahora se usa SQLite en su lugar
using System.Data.SQLite; // CONEXION DDBB

namespace ONG_Manager
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string strcon = "Data Source=ONGMANAGER.db;Version=3;";
		string sql;
		int perfil = 0;
		public MainForm()
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
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
  			sql = "select PERFIL from USERS where USUARIO ='"+textBox1.Text+"' and PASSWORD = '"+textBox2.Text+"';";
  			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
  			perfil = Convert.ToInt16(cmd.ExecuteScalar());
  			conn.Close();
  			CargarMenu();
		}
		
		void CargarMenu()
		{
			if (perfil == 0)
			{
				MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTO","ERROR DE ACCESO");
			}else
			{
				FormMenu Menuform = new FormMenu(perfil);
				this.Close();
				Menuform.Show();
			}
		}
		
		void debug()
		{
			FormMenu Menuform = new FormMenu(perfil);
				this.Hide();
				Menuform.Show();
		}
		void Button2Click(object sender, EventArgs e)
		{
			// Application.Exit(); // debug test
			debug();
			
		}
	}
}
