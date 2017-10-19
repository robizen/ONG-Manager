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
using System.Data;
using System.Data.SQLite; // CONEXION DDBB

namespace ONG_Manager
{
	/// <summary>
	/// Description of FormFormacion1.
	/// </summary>
	public partial class FormFormacion1 : Form
	{
		string strcon = "Data Source=ONGMANAGER.db;Version=3;";
		string sql;
		string nomcurso;
		
		public FormFormacion1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			cargainicialdatagrids();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			FormFormacion2 formCurso = new FormFormacion2(nomcurso);
			formCurso.MdiParent = this.MdiParent;
			this.Close();
			formCurso.Show();
		}
		void Button5Click(object sender, EventArgs e)
		{
			FormAlumnos1 formalumno = new FormAlumnos1();
			formalumno.MdiParent = this.MdiParent;
			this.Close();
			formalumno.Show();
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
        	dgridcursos.DataSource = dt1;
        	sql = "select * from ALUMNOS;";
        	cmd = new SQLiteCommand(sql, conn);
        	SQLiteDataAdapter da2 = new SQLiteDataAdapter(cmd);
        	DataTable dt2 = new DataTable();
        	da2.Fill(dt2);
        	dgridalumnos.DataSource = dt2;
        	
  			conn.Close();
		}

		void Button8Click(object sender, EventArgs e)
		{
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
  			sql = "select ALUMNOS.ID, ALUMNOS.NOMBRE,ALUMNOS.APELLIDO1,ALUMNOS.APELLIDO2,ALUMNOS.NIF from ALUMNOS INNER JOIN ALUMNOSCURSO ON ALUMNOSCURSO.IDALUMNO = ALUMNOS.ID WHERE ALUMNOSCURSO.IDCURSO = '"+dgridcursos.SelectedRows[0].Cells[0].Value.ToString()+"';";
  			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
  			SQLiteDataAdapter da3 = new SQLiteDataAdapter(cmd);
        	DataTable dt3 = new DataTable();
        	da3.Fill(dt3);
        	dgridalumnoscurso.DataSource = dt3;
		}
		void Button2Click(object sender, EventArgs e)
		{
			nomcurso = dgridcursos.SelectedRows[0].Cells[2].Value.ToString();
			FormFormacion2 formCurso = new FormFormacion2(nomcurso);
			formCurso.MdiParent = this.MdiParent;
			this.Close();
			formCurso.Show();
		}
		
		
		
		
		//final del fichero
	}
}
