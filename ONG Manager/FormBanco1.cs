/*
 * Creado por SharpDevelop.
 * Usuario: ops29rb12
 * Fecha: 08/11/2017
 * Hora: 19:53
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite; // CONEXION DDBB
using System.Data;

namespace ONG_Manager
{
	/// <summary>
	/// Description of FormBanco1.
	/// </summary>
	public partial class FormBanco1 : Form
	{
		string strcon = "Data Source=ONGMANAGER.db;Version=3;";
		string sql;
		public FormBanco1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			ActualizarDataGrid();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			FormBanco2 Banco2 = new FormBanco2();
			Banco2.MdiParent = this.MdiParent;
			this.Close();
			Banco2.Show();
		}
		
			void ActualizarDataGrid()
		{
			
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
  			sql = "select ID, PRODUCTO, UNIDADES from BANCOALIMENTOS where UNIDADES > 0;";
  			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
  			SQLiteDataAdapter da1 = new SQLiteDataAdapter(cmd);
        	DataTable dt1 = new DataTable();
        	da1.Fill(dt1);
        	STOCK.DataSource = dt1;
        	STOCK.Columns[0].Visible = false;
        	conn.Close();
        	
		}
		
		
		
	}
}
