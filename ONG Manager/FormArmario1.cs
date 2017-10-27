/*
 * Creado por SharpDevelop.
 * Usuario: ops29rb12
 * Fecha: 27/10/2017
 * Hora: 18:55
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
	/// Description of FormArmario1.
	/// </summary>
	public partial class FormArmario1 : Form
	{
		
		string strcon = "Data Source=ONGMANAGER.db;Version=3;";
		string sql,hoy;
		
		
		public FormArmario1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			hoy = DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Day.ToString();
		
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void addregistro()
		{
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
			sql = "INSERT INTO ARMARIO(ROPADEABRIGO_HOMBRE,PRENDASSUPERIORES_HOMBRE,PRENDASINFERIORES_HOMBRE,CALZADO_HOMBRE, ROPAINTERIOR_HOMBRE, ROPADEABRIGO_MUJER,PRENDASSUPERIORES_MUJER,PRENDASINFERIORES_MUJER,CALZADO_MUJER, ROPAINTERIOR_MUJER, ROPADEABRIGO_NINO, PRENDASSUPERIORES_NINO, PRENDASINFERIORES_NINO, CALZADO_NINO,ROPAINTERIOR_NINO, PANALES, HIGIENE,MENAJE,FECHA) VALUES ('"+tbhombre1.Text+"' ,'"+tbhombre2.Text+"' ,'"+tbhombre3.Text+"' ,'"+tbhombre4.Text+"' ,'"+tbhombre5.Text+"' ,'"+tbmujer1.Text+"' ,'"+tbmujer2.Text+"' ,'"+tbmujer3.Text+"' ,'"+tbmujer4.Text+"' ,'"+tbmujer5.Text+"' ,'"+tbnino1.Text+"' ,'"+tbnino2.Text+"' ,'"+tbnino3.Text+"' ,'"+tbnino4.Text+"' ,'"+tbnino5.Text+"','"+tbnino6.Text+"' ,'"+tbhigiene.Text+"' ,'"+tbmenaje.Text+"', '"+hoy+"');";
			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("REGISTRO ALMACENADO CORRECTAMENTE");
			tbhombre1.Text="0";
			tbhombre2.Text="0";
			tbhombre3.Text="0";
			tbhombre4.Text="0";
			tbhombre5.Text="0";
			tbmujer1.Text="0";
			tbmujer2.Text="0";
			tbmujer3.Text="0";
			tbmujer4.Text="0";
			tbmujer5.Text="0";
			tbnino1.Text="0";
			tbnino2.Text="0";
			tbnino3.Text="0";
			tbnino4.Text="0";
			tbnino5.Text="0";
			tbnino6.Text="0";
			tbhigiene.Text="0";
			tbmenaje.Text="0";
			
		}
		
		
		
		void minregistro()
		{
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
  			sql = "INSERT INTO ARMARIO(ROPADEABRIGO_HOMBRE,PRENDASSUPERIORES_HOMBRE,PRENDASINFERIORES_HOMBRE,CALZADO_HOMBRE, ROPAINTERIOR_HOMBRE, ROPADEABRIGO_MUJER,PRENDASSUPERIORES_MUJER,PRENDASINFERIORES_MUJER,CALZADO_MUJER, ROPAINTERIOR_MUJER, ROPADEABRIGO_NINO, PRENDASSUPERIORES_NINO, PRENDASINFERIORES_NINO, CALZADO_NINO,ROPAINTERIOR_NINO, PANALES, HIGIENE,MENAJE,VOLUNTARIO,FECHA) VALUES ('-"+tbshombre1.Text+"' ,'-"+tbshombre2.Text+"' ,'-"+tbshombre3.Text+"' ,'-"+tbshombre4.Text+"' ,'-"+tbshombre5.Text+"' ,'-"+tbsmujer1.Text+"' ,'-"+tbsmujer2.Text+"' ,'-"+tbsmujer3.Text+"' ,'-"+tbsmujer4.Text+"' ,'-"+tbsmujer5.Text+"' ,'-"+tbsnino1.Text+"' ,'-"+tbsnino2.Text+"' ,'-"+tbsnino3.Text+"' ,'-"+tbsnino4.Text+"' ,'-"+tbsnino5.Text+"','-"+tbsnino6.Text+"' ,'-"+tbshigiene.Text+"' ,'-"+tbsmenaje.Text+"','"+tbvoluntario.Text+"', '"+hoy+"');";
			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
			cmd.ExecuteNonQuery();
			conn.Close();
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			addregistro();
		}
		void Button2Click(object sender, EventArgs e)
		{
			minregistro();
		}
		void Button3Click(object sender, EventArgs e)
		{
			cargardatos();
		}
		
		void cargardatos()
		{	
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
  			string fecha1,fecha2;
  			fecha1 = dateTimePicker1.Value.Year.ToString()+"-"+dateTimePicker1.Value.Month.ToString()+"-"+dateTimePicker1.Value.Day.ToString();
  			fecha2 = dateTimePicker2.Value.Year.ToString()+"-"+dateTimePicker2.Value.Month.ToString()+"-"+dateTimePicker2.Value.Day.ToString();
			sql = "select * from ARMARIO WHERE ARMARIO.FECHA BETWEEN date('"+fecha1+"') AND date('"+fecha2+"');";
  			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
  			SQLiteDataAdapter da1 = new SQLiteDataAdapter(cmd);
        	DataTable dt1 = new DataTable();
        	da1.Fill(dt1);
        	dataGridView1.DataSource = dt1;
        	
			
		}
		
		
		
		
		
	} // FIN DEL ARCHIVO
}
