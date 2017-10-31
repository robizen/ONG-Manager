/*
 * Creado por SharpDevelop.
 * Usuario: ops29rb12
 * Fecha: 31/10/2017
 * Hora: 19:57
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite; // CONEXION DDBB
using Excel = Microsoft.Office.Interop.Excel;

namespace ONG_Manager
{
	/// <summary>
	/// Description of FormFormacion3.
	/// </summary>
	public partial class FormFormacion3 : Form
	{
		string strcon = "Data Source=ONGMANAGER.db;Version=3;";
		string sql;
		
		public FormFormacion3(string idcurso, string nomcurso)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			tbid.Text = idcurso;
			tbnombre.Text = nomcurso;
			cargaralumnosdisponibles();
			cargaralumnosinscritos();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void cargaralumnosinscritos()
		{
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
  			sql = "select ALUMNOS.ID, ALUMNOS.NOMBRE,ALUMNOS.APELLIDO1,ALUMNOS.APELLIDO2,ALUMNOS.NIF from ALUMNOS INNER JOIN ALUMNOSCURSO ON ALUMNOSCURSO.IDALUMNO = ALUMNOS.ID WHERE ALUMNOSCURSO.IDCURSO = '"+tbid.Text+"';";
  			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
  			SQLiteDataAdapter da1 = new SQLiteDataAdapter(cmd);
        	DataTable dt1 = new DataTable();
        	da1.Fill(dt1);
        	dgridinscritos.DataSource = dt1;
        	conn.Close();
		}
		void cargaralumnosdisponibles()
		{
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
  			sql = "SELECT ALUMNOS.ID, ALUMNOS.NOMBRE, ALUMNOS.APELLIDO1, ALUMNOS.APELLIDO2, ALUMNOS.NIF FROM ALUMNOS WHERE ALUMNOS.ID NOT IN (select ALUMNOS.ID from ALUMNOS INNER JOIN ALUMNOSCURSO ON ALUMNOSCURSO.IDALUMNO = ALUMNOS.ID WHERE ALUMNOSCURSO.IDCURSO = '"+tbid.Text+"');";
  			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
  			SQLiteDataAdapter da2 = new SQLiteDataAdapter(cmd);
        	DataTable dt2 = new DataTable();
        	da2.Fill(dt2);
        	dgriddisponibles.DataSource = dt2;
        	conn.Close();
		}
		void Button3Click(object sender, EventArgs e)
		{
			asignar();
			cargaralumnosdisponibles();
			cargaralumnosinscritos();
		}
		void Button4Click(object sender, EventArgs e)
		{
			
			desasignar();
			cargaralumnosdisponibles();
			cargaralumnosinscritos();
		}
		void asignar()
		{
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
  			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
			if (dgriddisponibles.SelectedRows.Count == 0)
			{
				MessageBox.Show("POR FAVOR, SELECCIONA UN ALUMNO");
			}else
			{
				for (int i = 0; i < dgriddisponibles.SelectedRows.Count; i++) 
				{
					sql ="insert into ALUMNOSCURSO (IDCURSO, IDALUMNO, COMPLETADO) values ('"+tbid.Text+"','"+dgriddisponibles.SelectedRows[i].Cells[0].Value.ToString()+"','NO');";
					cmd = new SQLiteCommand(sql, conn);
					cmd.ExecuteNonQuery();
					
				}
				conn.Close();
				MessageBox.Show("ASIGNACION COMPLETA");
			}
		}
		
		void desasignar()
		{
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
  			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
			if (dgridinscritos.SelectedRows.Count == 0)
			{
				MessageBox.Show("POR FAVOR, SELECCIONA UN ALUMNO");
			}else
			{
				for (int i = 0; i < dgridinscritos.SelectedRows.Count; i++) 
				{
					sql ="delete from ALUMNOSCURSO where IDCURSO = '"+tbid.Text+"' AND IDALUMNO = '"+dgridinscritos.SelectedRows[i].Cells[0].Value.ToString()+"';";
					cmd = new SQLiteCommand(sql, conn);
					cmd.ExecuteNonQuery();
					
				}
				conn.Close();
				MessageBox.Show("ELIMINACIÓN COMPLETA");
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
  			sql = "SELECT ALUMNOS.ID, ALUMNOS.NOMBRE, ALUMNOS.APELLIDO1, ALUMNOS.APELLIDO2, ALUMNOS.NIF FROM ALUMNOS WHERE (ALUMNOS.ID NOT IN (select ALUMNOS.ID from ALUMNOS INNER JOIN ALUMNOSCURSO ON ALUMNOSCURSO.IDALUMNO = ALUMNOS.ID WHERE ALUMNOSCURSO.IDCURSO = '"+tbid.Text+"')) AND ( ALUMNOS.ID LIKE '%"+tb1.Text+"%')AND ( ALUMNOS.APELLIDO1 LIKE '%"+tb2.Text+"%')AND ( ALUMNOS.NIF LIKE '%"+tb3.Text+"%');";
  			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
  			SQLiteDataAdapter da2 = new SQLiteDataAdapter(cmd);
        	DataTable dt2 = new DataTable();
        	da2.Fill(dt2);
        	dgriddisponibles.DataSource = dt2;
        	conn.Close();
		}
		void Button2Click(object sender, EventArgs e)
		{
			tb1.Text = "";
			tb2.Text = "";
			tb3.Text = "";
			cargaralumnosdisponibles();
		}
		
		
		
	} // fin archivo
}
