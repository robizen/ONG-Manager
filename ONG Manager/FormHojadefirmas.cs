/*
 * Creado por SharpDevelop.
 * Usuario: ops29rb12
 * Fecha: 07/11/2017
 * Hora: 21:18
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
	/// Description of FormHojadefirmas.
	/// </summary>
	public partial class FormHojadefirmas : Form
	{
		string strcon = "Data Source=ONGMANAGER.db;Version=3;";
		string sql;
		string idcurso2;
		string nomcurso2;
		string idprofesor2;
		
		
		public FormHojadefirmas(string idcurso,string nomcurso,string idprofesor)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
  			sql = "select ALUMNOS.ID, ALUMNOS.NOMBRE,ALUMNOS.APELLIDO1,ALUMNOS.APELLIDO2,ALUMNOS.NIF from ALUMNOS INNER JOIN ALUMNOSCURSO ON ALUMNOSCURSO.IDALUMNO = ALUMNOS.ID WHERE ALUMNOSCURSO.IDCURSO = '"+idcurso+"';";
  			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
  			SQLiteDataAdapter da4 = new SQLiteDataAdapter(cmd);
        	DataTable dt4 = new DataTable();
        	da4.Fill(dt4);
        	conn.Close();
        	dt1.DataSource = dt4;
        	idcurso2 = idcurso;
			nomcurso2 = nomcurso;
			idprofesor2 = idprofesor;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	
		void exportarExcel()
		{
			
			// HOJA DE FIRMAS
			//try {
				
		 	Microsoft.Office.Interop.Excel.Application aplicacion;
	        Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
	        Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
	        aplicacion = new Microsoft.Office.Interop.Excel.Application();
	        libros_trabajo = aplicacion.Workbooks.Add();
	        hoja_trabajo = 
	            (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
	        
	        
	        string profe = "SIN DATOS";
	        sql="select (APELLIDO1 || ' ' || APELLIDO2 || ', ' || NOMBRE) AS PROF FROM PROFESORES WHERE PROFESORES.ID = '"+idprofesor2+"'";
			SQLiteConnection con = new SQLiteConnection(strcon); 
			SQLiteCommand cmd = new SQLiteCommand(sql,con);
			con.Open();
			SQLiteDataReader reader = cmd.ExecuteReader();
			if (reader.HasRows)
			{
				while (reader.Read())
		            {
				 		profe = reader.GetString(0);
				 		MessageBox.Show(profe);
		            }
				
				
			} else
			{
				profe = "SIN PROFESOR ASIGNADO";
				MessageBox.Show(profe);
			}
			con.Close();
	        
	        string hoy = DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();
	        
	        hoja_trabajo.Cells[1,1] = "CURSO:";
	        hoja_trabajo.Cells[1,2] = nomcurso2;
	        hoja_trabajo.Cells[1,3] = "PROFESOR";
	        hoja_trabajo.Cells[1,4] = profe;
	        hoja_trabajo.Cells[1,5] = "FECHA";
	        hoja_trabajo.Cells[1,6] = monthCalendar1.SelectionEnd.Day.ToString()+"-"+monthCalendar1.SelectionEnd.Month.ToString()+"-"+monthCalendar1.SelectionEnd.Year.ToString();
	        
	        
	        hoja_trabajo.Cells[2,1] = "RELACION DE ASISTENTES:";
	        
	        hoja_trabajo.Cells[3,1] = "CODIGO ALUMNO:";
	        hoja_trabajo.Cells[3,2] = "NOMBRE";
	        hoja_trabajo.Cells[3,3] = "1er APELLIDO";
	        hoja_trabajo.Cells[3,4] = "2º APELLIDO";
	        hoja_trabajo.Cells[3,5] = "NIF";
	        hoja_trabajo.Cells[3,6] = "FIRMA";
	        
	        Excel.Range rng;
	        
	       
	       	        
	        for (int i = 0; i < dt1.Rows.Count ; i++)
	        {
	            for (int j = 0; j < 5; j++)
	            {
	         
	                hoja_trabajo.Cells[i + 4, j + 1] = dt1.Rows[i].Cells[j].Value;
	                rng = hoja_trabajo.get_Range(hoja_trabajo.Cells[i+4,j+1],hoja_trabajo.Cells[i+4,j+1]);
            		rng.BorderAround(ColorIndex: Excel.XlColorIndex.xlColorIndexAutomatic, Weight:Excel.XlBorderWeight.xlThick);
            	
	            }
	            rng = hoja_trabajo.get_Range(hoja_trabajo.Cells[i+4,6],hoja_trabajo.Cells[i+4,6]);
	            rng.BorderAround(ColorIndex: Excel.XlColorIndex.xlColorIndexAutomatic, Weight:Excel.XlBorderWeight.xlThick);
	        }
	        string fichero = "HOJADEFIRMAS "+nomcurso2+" "+monthCalendar1.SelectionEnd.Day.ToString()+"-"+monthCalendar1.SelectionEnd.Month.ToString()+"-"+monthCalendar1.SelectionEnd.Year.ToString()+".xls";
	        
	        libros_trabajo.SaveAs(fichero, 
	            Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
	        libros_trabajo.Close(true);
	        aplicacion.Quit();	
			
			
			//} catch (Exception ex) {
				
				//MessageBox.Show(ex.Message.ToString());
			//}
			
			
			MessageBox.Show("Exportacion Finalizada");
		}
		void MonthCalendar1DateChanged(object sender, DateRangeEventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			exportarExcel();
		}
	
	
	
	
	
	
	} //fin de archivo
}
