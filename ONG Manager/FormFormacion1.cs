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
using Excel = Microsoft.Office.Interop.Excel;

namespace ONG_Manager
{
	/// <summary>
	/// Description of FormFormacion1.
	/// </summary>
	public partial class FormFormacion1 : Form
	{
		string strcon = "Data Source=ONGMANAGER.db;Version=3;";
		string sql;
		string nomcurso,idcurso,idprofesor;
		
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
			bool editar = false;
			string ideditar = "";
			FormAlumnos1 formalumno = new FormAlumnos1(editar, ideditar);
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
        	sql = "select * from PROFESORES;";
        	cmd = new SQLiteCommand(sql, conn);
        	SQLiteDataAdapter da3 = new SQLiteDataAdapter(cmd);
        	DataTable dt3 = new DataTable();
        	da3.Fill(dt3);
        	dgridprofesores.DataSource = dt3;
        	
  			conn.Close();
		}

		void Button8Click(object sender, EventArgs e)
		{
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
			sql = "select * from ALUMNOS;";
			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
        	cmd = new SQLiteCommand(sql, conn);
        	SQLiteDataAdapter da2 = new SQLiteDataAdapter(cmd);
        	DataTable dt2 = new DataTable();
        	da2.Fill(dt2);
        	conn.Close();
        	tbapellidoalumno.Text = "";
        	tbdnialumno.Text = "";
        	tbidalumno.Text ="";
        	dgridalumnos.DataSource = dt2;
		}
		void Button2Click(object sender, EventArgs e)
		{
			nomcurso = dgridcursos.SelectedRows[0].Cells[2].Value.ToString();
			FormFormacion2 formCurso = new FormFormacion2(nomcurso);
			formCurso.MdiParent = this.MdiParent;
			this.Close();
			formCurso.Show();
		}
		void Button15Click(object sender, EventArgs e)
		{
			bool editar = false;
			string ideditar = dgridprofesores.SelectedRows[0].Cells[0].Value.ToString();
			FormProfesores1 formprofe = new FormProfesores1(editar, ideditar);
			formprofe.MdiParent = this.MdiParent;
			this.Close();
			formprofe.Show();
		}
		void Button6Click(object sender, EventArgs e)
		{
			bool editar = true;
			string ideditar = dgridalumnos.SelectedRows[0].Cells[0].Value.ToString();
			FormAlumnos1 formalumno = new FormAlumnos1(editar, ideditar);
			formalumno.MdiParent = this.MdiParent;
			this.Close();
			formalumno.Show();
		}
		void Button13Click(object sender, EventArgs e)
		{	
			FormProfesores2 formaProfeCursos = new FormProfesores2(dgridprofesores.SelectedRows[0].Cells[0].Value.ToString(),dgridprofesores.SelectedRows[0].Cells[2].Value.ToString(),dgridprofesores.SelectedRows[0].Cells[3].Value.ToString(),dgridprofesores.SelectedRows[0].Cells[1].Value.ToString(),dgridprofesores.SelectedRows[0].Cells[4].Value.ToString());
			formaProfeCursos.MdiParent = this.MdiParent;
			this.Close();
			formaProfeCursos.Show();
		}
		
		void cargaralumnoscurso()
		{
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
  			sql = "select ALUMNOS.ID, ALUMNOS.NOMBRE,ALUMNOS.APELLIDO1,ALUMNOS.APELLIDO2,ALUMNOS.NIF from ALUMNOS INNER JOIN ALUMNOSCURSO ON ALUMNOSCURSO.IDALUMNO = ALUMNOS.ID WHERE ALUMNOSCURSO.IDCURSO = '"+dgridcursos.SelectedRows[0].Cells[0].Value.ToString()+"';";
  			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
  			SQLiteDataAdapter da4 = new SQLiteDataAdapter(cmd);
        	DataTable dt4 = new DataTable();
        	da4.Fill(dt4);
        	dgridalumnoscurso.DataSource = dt4;
        	conn.Close();
		}
		void DgridcursosClick(object sender, EventArgs e)
		{
			idcurso = dgridcursos.SelectedRows[0].Cells[0].Value.ToString();
			nomcurso = dgridcursos.SelectedRows[0].Cells[2].Value.ToString();
			idprofesor = dgridcursos.SelectedRows[0].Cells[10].Value.ToString();
			cargaralumnoscurso();
		}
		void Button10Click(object sender, EventArgs e)
		{
			
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
  			sql = "select * from CURSOS where CURSOS.TIPO LIKE '%"+comboBox1.Text+"%' and CURSOS.COMPLETADO LIKE '%"+comboBox2.Text+"%' and CURSOS.NOMBRE LIKE '%"+textBox1.Text+"%';";
  			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
  			SQLiteDataAdapter da1 = new SQLiteDataAdapter(cmd);
        	DataTable dt1 = new DataTable();
        	da1.Fill(dt1);
        	dgridcursos.DataSource = dt1;
        	conn.Close();
		}
		void Button11Click(object sender, EventArgs e)
		{
			comboBox1.Text = "";
			comboBox2.Text = "";
			textBox1.Text = "";
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
  			sql = "select * from CURSOS;";
  			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
  			SQLiteDataAdapter da1 = new SQLiteDataAdapter(cmd);
        	DataTable dt1 = new DataTable();
        	da1.Fill(dt1);
        	dgridcursos.DataSource = dt1;
        	conn.Close();
		}
		void Button18Click(object sender, EventArgs e)
		{
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
			sql = "select * from ALUMNOS where ALUMNOS.ID LIKE '%"+tbidalumno.Text+"%' and ALUMNOS.NIF LIKE '%"+tbdnialumno.Text+"%' and ALUMNOS.APELLIDO1 LIKE '%"+tbapellidoalumno.Text+"%';";
			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
        	cmd = new SQLiteCommand(sql, conn);
        	SQLiteDataAdapter da2 = new SQLiteDataAdapter(cmd);
        	DataTable dt2 = new DataTable();
        	da2.Fill(dt2);
        	dgridalumnos.DataSource = dt2;
        	conn.Close();
        	
		}
		void Button20Click(object sender, EventArgs e)
		{
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
			sql = "select * from PROFESORES where PROFESORES.ID LIKE '%"+tbidprofesor.Text+"%' and PROFESORES.NIF LIKE '%"+tbdniprofesor.Text+"%' and PROFESORES.APELLIDO1 LIKE '%"+tbapellidoprofesor.Text+"%';";
			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
        	cmd = new SQLiteCommand(sql, conn);
        	SQLiteDataAdapter da3 = new SQLiteDataAdapter(cmd);
        	DataTable dt3 = new DataTable();
        	da3.Fill(dt3);
        	dgridprofesores.DataSource = dt3;
        	conn.Close();
        	
		}
		void Button19Click(object sender, EventArgs e)
		{
			
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
			sql = "select * from PROFESORES ;";
			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
        	cmd = new SQLiteCommand(sql, conn);
        	SQLiteDataAdapter da3 = new SQLiteDataAdapter(cmd);
        	DataTable dt3 = new DataTable();
        	da3.Fill(dt3);
        	dgridprofesores.DataSource = dt3;
        	conn.Close();
        	tbapellidoprofesor.Text = "";
        	tbdniprofesor.Text = "";
        	tbidprofesor.Text ="";
		}
		void Button9Click(object sender, EventArgs e)
		{
			
			idcurso = dgridcursos.SelectedRows[0].Cells[0].Value.ToString();
			nomcurso = dgridcursos.SelectedRows[0].Cells[2].Value.ToString();
			idprofesor = dgridcursos.SelectedRows[0].Cells[10].Value.ToString();
			FormHojadefirmas hojadefirmas = new FormHojadefirmas(idcurso,nomcurso,idprofesor);
			hojadefirmas.Show();
			
		}
		void Button12Click(object sender, EventArgs e)
		{
			FormAlumnos2 asignarcursosalumno = new FormAlumnos2(dgridalumnos.SelectedRows[0].Cells[0].Value.ToString() ,dgridalumnos.SelectedRows[0].Cells[2].Value.ToString() ,dgridalumnos.SelectedRows[0].Cells[3].Value.ToString() ,dgridalumnos.SelectedRows[0].Cells[1].Value.ToString(), dgridalumnos.SelectedRows[0].Cells[4].Value.ToString());
			asignarcursosalumno.MdiParent = this.MdiParent;
			asignarcursosalumno.Show();
		}
		void Button14Click(object sender, EventArgs e)
		{
			bool editar = true;
			string ideditar = dgridprofesores.SelectedRows[0].Cells[0].Value.ToString();
			FormProfesores1 formprofe = new FormProfesores1(editar, ideditar);
			formprofe.MdiParent = this.MdiParent;
			this.Close();
			formprofe.Show();
		}
		void Button16Click(object sender, EventArgs e)
		{
			//CONVERTIR EN PROFESOR
			
			int validacion = 0;
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
  			sql = "select COUNT(ID) from PROFESORES where nif ='"+dgridalumnos.SelectedRows[0].Cells[4].Value.ToString()+"';";
  			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
  			validacion = Convert.ToInt16(cmd.ExecuteScalar());
  			if (validacion == 0) 
  			{
  				
  				sql = "insert into PROFESORES (NOMBRE, APELLIDO1, APELLIDO2, NIF, PAIS, EDAD, SEXO, TELEFONO1, TELEFONO2, EMAIL, DIRECCION1, DIRECCION2, POBLACION, PROVINCIA, OBSERVACIONES) SELECT NOMBRE, APELLIDO1, APELLIDO2, NIF, PAIS, EDAD, SEXO, TELEFONO1, TELEFONO2, EMAIL, DIRECCION1, DIRECCION2, POBLACION, PROVINCIA, OBSERVACIONES FROM ALUMNOS WHERE ALUMNOS.ID = '"+dgridalumnos.SelectedRows[0].Cells[0].Value.ToString()+"';";
  				cmd = new SQLiteCommand(sql, conn);
  				cmd.ExecuteNonQuery();
  				MessageBox.Show("DATOS COPIADOS CORRECTAMENTE");
  				cargainicialdatagrids();
  				
  			}else
  			{
  				
  				MessageBox.Show("YA EXISTEN DATOS CON ESE DNI, REVISA EL LISTADO DE PROFESORES.");
  			}
  			
  			
		}
		void Button17Click(object sender, EventArgs e)
		{
			int validacion = 0;
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
  			sql = "select COUNT(ID) from ALUMNOS where nif ='"+dgridprofesores.SelectedRows[0].Cells[4].Value.ToString()+"';";
  			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
  			validacion = Convert.ToInt16(cmd.ExecuteScalar());
  			if (validacion == 0) 
  			{
  				
  				sql = "insert into ALUMNOS (NOMBRE, APELLIDO1, APELLIDO2, NIF, PAIS, EDAD, SEXO, TELEFONO1, TELEFONO2, EMAIL, DIRECCION1, DIRECCION2, POBLACION, PROVINCIA, OBSERVACIONES) SELECT NOMBRE, APELLIDO1, APELLIDO2, NIF, PAIS, EDAD, SEXO, TELEFONO1, TELEFONO2, EMAIL, DIRECCION1, DIRECCION2, POBLACION, PROVINCIA, OBSERVACIONES FROM PROFESORES WHERE PROFESORES.ID = '"+dgridprofesores.SelectedRows[0].Cells[0].Value.ToString()+"';";
  				cmd = new SQLiteCommand(sql, conn);
  				cmd.ExecuteNonQuery();
  				MessageBox.Show("DATOS COPIADOS CORRECTAMENTE");
  				cargainicialdatagrids();
  				
  			}else
  			{
  				
  				MessageBox.Show("YA EXISTEN DATOS CON ESE DNI, REVISA EL LISTADO DE ALUMNOS.");
  			}
		}
		void Button7Click(object sender, EventArgs e)
		{
			FormFormacion3 ASIGNACION = new FormFormacion3(idcurso, nomcurso);
			ASIGNACION.MdiParent = this.MdiParent;
			ASIGNACION.Show();
		}
	
		
		
		
		
		//final del fichero
	}
}
