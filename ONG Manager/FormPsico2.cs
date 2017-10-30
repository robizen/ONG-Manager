﻿/*
 * Creado por SharpDevelop.
 * Usuario: ops29rb12
 * Fecha: 30/10/2017
 * Hora: 18:29
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
	/// Description of FormPsico2.
	/// </summary>
	public partial class FormPsico2 : Form
	{
		string strcon = "Data Source=ONGMANAGER.db;Version=3;";
		string sql;
		public FormPsico2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
				void Button2Click(object sender, EventArgs e)
		{
			int validacion;
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
  			sql = "select id from PSICOLOGOS where nif ='"+tb4.Text+"';";
  			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
  			validacion = Convert.ToInt16(cmd.ExecuteScalar());
  			if (validacion == 0) 
  			{
  				addpsicologo();
  			}else
  			{
  				DialogResult result = MessageBox.Show("Ya hay datos de ese psicologo, ¿quieres cargarlos?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
  				if(result == DialogResult.Yes)
  				{
  					cargarpsico();
  				}
  				if(result == DialogResult.No)
  				{
  					MessageBox.Show("Entonces, revisa los datos introducidos");
  				}
  			}
		}
		
		void addpsicologo()
		{
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
			sql = "INSERT INTO PSICOLOGOS(NOMBRE,APELLIDO1,APELLIDO2,NIF,PAIS,EDAD,SEXO,TELEFONO1,TELEFONO2,EMAIL,DIRECCION1,DIRECCION2,POBLACION,PROVINCIA,OBSERVACIONES) VALUES ('"+tb1.Text+ "','"+tb2.Text+"','"+tb3.Text+"','"+tb4.Text+"','"+tb5.Text+"','"+tb6.Text+"','"+cb1.Text+"','"+tb7.Text+"','"+tb8.Text+"','"+tb9.Text+"','"+tb10.Text+"','"+tb11.Text+"','"+tb12.Text+"','"+tb13.Text+"','"+tb14.Text+"');";
			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Registro realizado correctamente.");
			limpiarcampos();
		}
		
			void limpiarcampos()
		{
				tb0.Text = "";
				tb1.Text = "";
				tb2.Text = "";
				tb3.Text = "";
				tb4.Text = "";
				tb5.Text = "";
				tb6.Text = "";
				cb1.Text = "";
				tb7.Text = "";
				tb8.Text = "";
				tb9.Text = "";
				tb10.Text = "";
				tb11.Text = "";
				tb12.Text = "";
				tb13.Text = "";
				tb14.Text = "";
		}
		
		
		void cargarpsico()
		{
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
			sql = "select * from PSICOLOGOS where nif ='"+tb4.Text+"';";
			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
			SQLiteDataReader r = cmd.ExecuteReader();
			while (r.Read()) {
				tb0.Text = r[0].ToString();
				tb1.Text = r[1].ToString();
				tb2.Text = r[2].ToString();
				tb3.Text = r[3].ToString();
				tb4.Text = r[4].ToString();
				tb5.Text = r[5].ToString();
				tb6.Text = r[6].ToString();
				cb1.Text = r[7].ToString();
				tb7.Text = r[8].ToString();
				tb8.Text = r[9].ToString();
				tb9.Text = r[10].ToString();
				tb10.Text = r[11].ToString();
				tb11.Text = r[12].ToString();
				tb12.Text = r[13].ToString();
				tb13.Text = r[14].ToString();
				tb14.Text = r[15].ToString();
			}
			

		}
		
		void Button1Click(object sender, EventArgs e)
		{
			int validacion;
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
  			sql = "select id from PSICOLOGOS where nif ='"+tb4.Text+"';";
  			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
  			validacion = Convert.ToInt16(cmd.ExecuteScalar());
  			if (validacion == 0) 
  			{
  				MessageBox.Show("DNI NO ENCONTRADO");
  				
  			}else
  			{
  				cargarpsico();
  			}
		}
		void Button3Click(object sender, EventArgs e)
		{
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
			sql = "UPDATE PSICOLOGOS SET NOMBRE = '"+tb1.Text+"', APELLIDO1 = '"+tb2.Text+"' , APELLIDO2 = '"+tb3.Text+"', NIF = '"+tb4.Text+"',PAIS = '"+tb5.Text+"',EDAD = '"+tb6.Text+"' ,SEXO = '"+cb1.Text+"' ,TELEFONO1 = '"+tb7.Text+"',TELEFONO2 = '"+tb8.Text+"',EMAIL = '"+tb9.Text+"' ,DIRECCION1 = '"+tb10.Text+"',DIRECCION2 = '"+tb11.Text+"',POBLACION = '"+tb12.Text+"', PROVINCIA = '"+tb13.Text+"', OBSERVACIONES = '"+tb14.Text+"' WHERE ID = '"+tb0.Text+"';";
			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("REGISTRO EDITADO CORRECTAMENTE");
		}
		
		
		
		
		
	} // FIN FORM
}