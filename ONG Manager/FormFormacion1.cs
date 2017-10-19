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
			FormFormacion2 formCurso = new FormFormacion2();
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
		
		
		
		//final del fichero
	}
}
