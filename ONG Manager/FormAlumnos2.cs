/*
 * Creado por SharpDevelop.
 * Usuario: robiz
 * Fecha: 19/10/2017
 * Hora: 8:20
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
	/// Description of FormAlumnos2.
	/// </summary>
	public partial class FormAlumnos2 : Form
	{
		string strcon = "Data Source=ONGMANAGER.db;Version=3;";
		string sql;
		
		public FormAlumnos2(string id,string apellido1,string apellido2,string nombre,string nif)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			tbid.Text = id;
			tbnombre.Text = apellido1 + " " + apellido2 + ", "+ nombre;
			tbnif.Text = nif;
			cargainicialdatagrids();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void cargainicialdatagrids()
		{
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
  			sql = "select * from CURSOS;";
  			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
  			SQLiteDataAdapter da1 = new SQLiteDataAdapter(cmd);
        	DataTable dt1 = new DataTable();
        	da1.Fill(dt1);
        	dgcursos.DataSource = dt1;
		}
		void Button2Click(object sender, EventArgs e)
		{
			asignarcursos();
		}
		
		void asignarcursos()
		{
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
  			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
			if (dgcursos.SelectedRows.Count == 0)
			{
				MessageBox.Show("POR FAVOR, SELECCIONA UN CURSO");
			}else
			{
				for (int i = 0; i < dgcursos.SelectedRows.Count; i++) 
				{
					sql ="insert into ALUMNOSCURSO (IDCURSO, IDALUMNO, COMPLETADO) values ('"+dgcursos.SelectedRows[i].Cells[0].Value.ToString()+"','"+tbid.Text+"','NO');";
					cmd = new SQLiteCommand(sql, conn);
					cmd.ExecuteNonQuery();
					
				}
				conn.Close();
				MessageBox.Show("ASIGNACION COMPLETA");
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show( dgcursos.SelectedRows.Count.ToString());
		}
		
		
		
		
		// fin archivo
	}
}
