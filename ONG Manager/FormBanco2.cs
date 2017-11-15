/*
 * Creado por SharpDevelop.
 * Usuario: ops29rb12
 * Fecha: 15/11/2017
 * Hora: 21:37
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite; // CONEXION DDBB

namespace ONG_Manager
{
	/// <summary>
	/// Description of FormBanco2.
	/// </summary>
	public partial class FormBanco2 : Form
	{
		string strcon = "Data Source=ONGMANAGER.db;Version=3;";
		string sql;
		
		public FormBanco2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ActualizarDataGrid()
		{
			
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
  			sql = "select PRODUCTO, UNIDADES from BANCOALIMENTOS;";
  			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
  			SQLiteDataAdapter da1 = new SQLiteDataAdapter(cmd);
        	DataTable dt1 = new DataTable();
        	da1.Fill(dt1);
        	DGBanco1.DataSource = dt1;
		}
		void LimpiarTabla()
		{
			//limpiar la tabla
		}
		
		void GuardarCambios()
		{
			//limpia la tabla, y recorre el dg para volver a almacenar los datos
			
		}
		
		
		
		
	} // FINAL DEL ARCHIVO
}
