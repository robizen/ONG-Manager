/*
 * Creado por SharpDevelop.
 * Usuario: ops29rb12
 * Fecha: 17/10/2017
 * Hora: 19:58
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite; // CONEXION DDBB

namespace ONG_Manager
{
	/// <summary>
	/// Description of FormFormacion2.
	/// </summary>
	public partial class FormFormacion2 : Form
	{
		string strcon = "Data Source=ONGMANAGER.db;Version=3;";
		string sql;
		public FormFormacion2(string nombrecurso)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			if(nombrecurso != null)
			{
				tb1.Text = nombrecurso;
				cargarcurso();
			}
			
			
			 
				//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void TextBox3TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			validar();
		}
		
		void addcurso()
		{
			string fechainicio = calendarinicio.SelectionRange.Start.ToString("yyyy-MM-dd");
			string fechafin = calendarfinal.SelectionRange.Start.ToString("yyyy-MM-dd");
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
			sql = "INSERT INTO CURSOS(TIPO,NOMBRE,FECHAINICIO,FECHAFINAL,HORAS,HORASDIA,PERIODICIDAD,SESIONES,COMPLETADO,OBSERVACIONES) VALUES ('"+cb1.Text+ "','"+tb1.Text+"','"+fechainicio+"','"+fechafin+"','"+tb2.Text+"','"+tb3.Text+"','"+cb2.Text+"','"+tb4.Text+"','"+cb3.Text+"','"+tb5.Text+"');";
			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
			cmd.ExecuteNonQuery();
			conn.Close();
			cargarcurso();
			MessageBox.Show("CURSO AÑADIDO CORRECTAMENTE");
			
		}
		
		void validar()
		{
			int validacion;
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
  			sql = "select ID from CURSOS where NOMBRE ='"+tb1.Text+"';";
  			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
  			validacion = Convert.ToInt16(cmd.ExecuteScalar());
  			if (validacion == 0) 
  			{
  				addcurso();
  			}else
  			{
  				DialogResult result = MessageBox.Show("Ese curso ya consta creado, ¿quieres cargar los datos?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
  				if(result == DialogResult.Yes)
  				{
  					cargarcurso();
  				}
  				if(result == DialogResult.No)
  				{
  					MessageBox.Show("Entonces, revisa los datos introducidos");
  				}
  			}
		}
		
		void cargarcurso()
		{
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
			sql = "select * from CURSOS where NOMBRE ='"+tb1.Text+"';";
			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
			SQLiteDataReader r = cmd.ExecuteReader();
			while (r.Read()) {
				tb0.Text = r[0].ToString();
				cb1.Text = r[1].ToString();
				tb1.Text = r[2].ToString();
				string fechastr = r[3].ToString();
				int anno = Convert.ToInt16(fechastr.Substring(0,2));
				int mes = Convert.ToInt16(fechastr.Substring(3,2));
				int dia = Convert.ToInt16(fechastr.Substring(6,4));
				DateTime fecha = new DateTime(dia,mes,anno);
				calendarinicio.SelectionRange =  new SelectionRange (fecha,fecha);
				fechastr = r[4].ToString();
				anno = Convert.ToInt16(fechastr.Substring(0,2));
				mes = Convert.ToInt16(fechastr.Substring(3,2));
				dia = Convert.ToInt16(fechastr.Substring(6,4));
				fecha = new DateTime(dia,mes,anno);
				calendarfinal.SelectionRange =  new SelectionRange (fecha,fecha);
				tb2.Text = r[5].ToString();
				tb3.Text = r[6].ToString();
				cb2.Text = r[7].ToString();
				tb4.Text = r[8].ToString();
				cb3.Text = r[9].ToString();
				tbprofesor.Text = r[10].ToString();
				tb5.Text = r[11].ToString();
				
			}
			

		}
		void Button3Click(object sender, EventArgs e)
		{
				tb0.Text = "";
				cb1.Text = "";
				tb1.Text = "";
				tb2.Text = "";
				tb3.Text = "";
				cb2.Text = "";
				tb4.Text = "";
				cb3.Text = "";
				tbprofesor.Text = "";
				tb5.Text = "";
		}

		void Button4Click(object sender, EventArgs e)
		{
			buscarcurso();
		}
		void Button5Click(object sender, EventArgs e)
		{
			if (tb0 == null)
			{
				MessageBox.Show("SOLO PUEDES ACTUALIZAR CURSOS CREADOS ANTERIORMENTE, CREA UNO NUEVO O BUSCA UNO CREADO");
			}
			else
			{
				string fechainicio = calendarinicio.SelectionRange.Start.ToString("yyyy-MM-dd");
				string fechafin = calendarfinal.SelectionRange.Start.ToString("yyyy-MM-dd");
				SQLiteConnection conn = new SQLiteConnection(strcon);
	  			conn.Open();
				sql = "UPDATE CURSOS SET TIPO = '"+cb1.Text+ "', NOMBRE='"+tb1.Text+"',FECHAINICIO='"+fechainicio+"',FECHAFINAL='"+fechafin+"',HORAS='"+tb2.Text+"',HORASDIA='"+tb3.Text+"',PERIODICIDAD='"+cb2.Text+"',SESIONES='"+tb4.Text+"',COMPLETADO='"+cb3.Text+"',OBSERVACIONES='"+tb5.Text+"' WHERE ID = '"+tb0.Text+"';";
				SQLiteCommand cmd = new SQLiteCommand(sql, conn);
				cmd.ExecuteNonQuery();
				conn.Close();
				cargarcurso();
				MessageBox.Show("CURSO MODIFICADO CORRECTAMENTE");
			}
		}
		
		void buscarcurso()
		{
			
			int validacion;
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
  			sql = "select ID from CURSOS where NOMBRE ='"+tb1.Text+"';";
  			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
  			validacion = Convert.ToInt16(cmd.ExecuteScalar());
  			if (validacion == 0) 
  			{
  				MessageBox.Show("NO EXISTE EL CURSO, COMPRUEBA EL NOMBRE");
  			}else
  			{
  				DialogResult result = MessageBox.Show("Curso encontrado, ¿quieres cargar los datos?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
  				if(result == DialogResult.Yes)
  				{
  					cargarcurso();
  				}
  				if(result == DialogResult.No)
  				{
  					//
  				}
  			}
		}
		
		//FIN ARCHIVO
	}
}
