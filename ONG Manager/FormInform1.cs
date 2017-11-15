/*
 * Creado por SharpDevelop.
 * Usuario: ops29rb12
 * Fecha: 30/10/2017
 * Hora: 18:14
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
	/// Description of FormInform1.
	/// </summary>
	public partial class FormInform1 : Form
	{
		string strcon = "Data Source=ONGMANAGER.db;Version=3;";
		string sql, hoy, fichero;
		public FormInform1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			hoy = DateTime.Today.Year.ToString("0000") + "-" + DateTime.Today.Month.ToString("00") + "-" + DateTime.Today.Day.ToString("00");
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
				void Button1Click(object sender, EventArgs e)
		{
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
			sql = "INSERT INTO INFORMACION(TIPO,EXTRA,HOMBRES,MUJERES,NINOS,NOTAS,FECHA) VALUES ('"+comboBox1.Text+"' ,'"+textBox1.Text+"' ,'"+textBox2.Text+"' ,'"+textBox3.Text+"' ,'"+textBox4.Text+"' ,'"+textBox5.Text+"', '"+hoy+"');";
			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Registro realizado correctamente.");
			limpiarcampos();
			
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			// CREAR PSICOLOGO
			FormPsico2 psicologo2 = new FormPsico2();
			psicologo2.MdiParent = this.MdiParent;
			psicologo2.Show();
			
		}
		
		void limpiarcampos()
		{
			textBox1.Text = "";
			textBox2.Text = "0";
			textBox3.Text = "0";
			textBox4.Text = "0";
			textBox5.Text = "";
			
		}

		
		
		
		
		
		
		
	}	//FINAL DEL ARCHIVO
}
