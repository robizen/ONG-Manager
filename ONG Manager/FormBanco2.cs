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
			sql = "";
			ActualizarDataGrid();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ActualizarDataGrid()
		{
			
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
  			sql = "select ID, PRODUCTO, UNIDADES from BANCOALIMENTOS;";
  			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
  			SQLiteDataAdapter da1 = new SQLiteDataAdapter(cmd);
        	DataTable dt1 = new DataTable();
        	da1.Fill(dt1);
        	DGBanco1.DataSource = dt1;
        	DGBanco1.Columns[0].Visible = false;
        	conn.Close();
        	
		}
		
		void GuardarCambios()
		{
			//Recorre el dg para volver a almacenar los datos
			int x;
			try 
			{
				
				for (int i = 0; i < DGBanco1.Rows.Count -1; i++) 
				{
					if (DGBanco1.Rows[i].Cells[0].Value != null) {
						sql = "select count (ID) from BANCOALIMENTOS WHERE ID = '"+DGBanco1.Rows[i].Cells[0].Value.ToString()+"';";
						x = ComprobarValor();
					}
					else
					{
						x=0;
					}
					if (x == 0) {
						sql = "INSERT INTO BANCOALIMENTOS (PRODUCTO, UNIDADES) VALUES ('"+DGBanco1.Rows[i].Cells[1].Value.ToString()+"', '"+DGBanco1.Rows[i].Cells[2].Value.ToString()+"');";
						EjecutarSQL();
					}
					else
					{
						sql = "UPDATE BANCOALIMENTOS SET PRODUCTO = '"+DGBanco1.Rows[i].Cells[1].Value.ToString()+"', UNIDADES = '"+DGBanco1.Rows[i].Cells[2].Value.ToString()+"'  WHERE ID = '"+DGBanco1.Rows[i].Cells[0].Value.ToString()+"';";
						EjecutarSQL();
					}
				}
				MessageBox.Show("Cambios almacenados correctamente");
				
			
			} catch (Exception Ex) {
				MessageBox.Show(Ex.ToString());
			}
			ActualizarDataGrid();
			
		}
		
		public string Leercampo(string campo, string tabla)
		{
			string valor;
			SQLiteConnection conn = new SQLiteConnection(strcon);
			conn.Open();
			sql = "select "+campo+" from "+tabla+";"; 
			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
			SQLiteDataReader reader = cmd.ExecuteReader();
			reader.Read();
			valor = reader[0].ToString();
			reader.Close();
			conn.Close();
			return valor;
		}
		
		public int ComprobarValor()
		{
			int valor;
			SQLiteConnection conn = new SQLiteConnection(strcon);
			conn.Open();
			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
			SQLiteDataReader reader = cmd.ExecuteReader();
			reader.Read();
			valor = Convert.ToInt16(reader[0].ToString());
			reader.Close();
			conn.Close();
			return valor;
			
		}
		
		void EjecutarSQL()
		{
			try {
				SQLiteConnection con2 = new SQLiteConnection(strcon);
				con2.Open();
				SQLiteCommand cmd2 = new SQLiteCommand(sql, con2);
				cmd2.ExecuteNonQuery();
				con2.Close(); 
			
			} 
			catch (Exception ex) {
				MessageBox.Show(ex.ToString(),"ERROR, COMPRUEBE LA BASE DE DATOS");
				throw;
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			GuardarCambios();
		}
			
		
		
		
		
	} // FINAL DEL ARCHIVO
}
