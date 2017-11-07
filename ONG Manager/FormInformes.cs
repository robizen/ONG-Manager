/*
 * Creado por SharpDevelop.
 * Usuario: ops29rb12
 * Fecha: 07/11/2017
 * Hora: 20:14
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
	/// Description of FormInformes.
	/// </summary>
	public partial class FormInformes : Form
	{
		
		string strcon = "Data Source=ONGMANAGER.db;Version=3;";
		string sql,hoy,fichero;
		
		public FormInformes()
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
		
	
		void informeArmario()
		{	
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
  			string fecha1,fecha2;
  			fecha1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
			fecha2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
			sql = "select * from ARMARIO WHERE FECHA BETWEEN '"+fecha1+"' AND'"+fecha2+"';";
  			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
  			SQLiteDataAdapter da1 = new SQLiteDataAdapter(cmd);
        	DataTable dt1 = new DataTable();
        	da1.Fill(dt1);
        	dataGridView1.DataSource = dt1;
        	
			
		}
		
		void informePsicologia()
		{
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
  			string fecha1,fecha2;
  			fecha1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
			fecha2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
			sql = "select (T1.APELLIDO1 || ' ' || T1.APELLIDO2 ||', ' ||  T1.NOMBRE) AS PSICOLOGO, T2.TIPO, T2.HOMBRES, T2.MUJERES, T2.NINOS AS NIÑOS, T2.NOTAS, T2.FECHA  from PSICOLOGIA AS T2 INNER JOIN PSICOLOGOS AS T1 ON T2.IDPSICOLOGO = T1.ID WHERE T2.FECHA BETWEEN '"+fecha1+"' AND'"+fecha2+"';";
  			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
  			SQLiteDataAdapter da1 = new SQLiteDataAdapter(cmd);
        	DataTable dt1 = new DataTable();
        	da1.Fill(dt1);
        	dataGridView1.DataSource = dt1;
		}
		
		void exportarPsicologia()
		{
			
			try {
				
		 	Microsoft.Office.Interop.Excel.Application aplicacion;
	        Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
	        Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
	        aplicacion = new Microsoft.Office.Interop.Excel.Application();
	        libros_trabajo = aplicacion.Workbooks.Add();
	        hoja_trabajo = 
	            (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
	        //Recorremos el DataGridView rellenando la hoja de trabajo
	        
	        hoja_trabajo.Cells[1,1] = "PSICOLOGO";
	        hoja_trabajo.Cells[1,2] = "TIPO";
	        hoja_trabajo.Cells[1,3] = "HOMBRES";
	        hoja_trabajo.Cells[1,4] = "MUJERES";
	        hoja_trabajo.Cells[1,5] = "NIÑOS";
	        hoja_trabajo.Cells[1,6] = "NOTAS";
	        hoja_trabajo.Cells[1,7] = "FECHA";
			
	        Excel.Range rng;
	        int lineas = dataGridView1.Rows.Count + 5;
	        rng = hoja_trabajo.get_Range("G1","G"+ lineas.ToString());
	        rng.NumberFormat = "dd/MM/yyyy";
	        
	        for (int i = 0; i < dataGridView1.Rows.Count -1 ; i++)
	        {
	            for (int j = 0; j < 7; j++)
	            {
	         
	                hoja_trabajo.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
	            }
	        }
	 
	        
	        libros_trabajo.SaveAs(fichero, 
	            Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
	        libros_trabajo.Close(true);
	        aplicacion.Quit();	
			
			
			} catch (Exception ex) {
				
				MessageBox.Show(ex.Message.ToString());
			}
			
			
			MessageBox.Show("Exportacion Finalizada");
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			informeArmario();
		}
		void Button8Click(object sender, EventArgs e)
		{
			informePsicologia();
		}
		void Button7Click(object sender, EventArgs e)
		{
			informePsicologia();
			rutafichero("Psicologia");
			exportarPsicologia();
		}
		
		void informePuntoinfo()
		{
			SQLiteConnection conn = new SQLiteConnection(strcon);
  			conn.Open();
  			string fecha1,fecha2;
  			fecha1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
			fecha2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
			sql = "select * FROM INFORMACION WHERE FECHA BETWEEN '"+fecha1+"' AND '"+fecha2+"';";
  			SQLiteCommand cmd = new SQLiteCommand(sql, conn);
  			SQLiteDataAdapter da1 = new SQLiteDataAdapter(cmd);
        	DataTable dt1 = new DataTable();
        	da1.Fill(dt1);
        	dataGridView1.DataSource = dt1;
		}
		
			
		void exportarPuntoinfo()
		{
			
			try {
				
		 	Microsoft.Office.Interop.Excel.Application aplicacion;
	        Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
	        Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
	        aplicacion = new Microsoft.Office.Interop.Excel.Application();
	        libros_trabajo = aplicacion.Workbooks.Add();
	        hoja_trabajo = 
	            (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
	        //Recorremos el DataGridView rellenando la hoja de trabajo
	        
	        hoja_trabajo.Cells[1,1] = "TIPO";
	        hoja_trabajo.Cells[1,2] = "EXTRA";
	        hoja_trabajo.Cells[1,3] = "HOMBRES";
	        hoja_trabajo.Cells[1,4] = "MUJERES";
	        hoja_trabajo.Cells[1,5] = "NIÑOS";
	        hoja_trabajo.Cells[1,6] = "NOTAS";
	        hoja_trabajo.Cells[1,7] = "FECHA";
			
	        Excel.Range rng;
	        int lineas = dataGridView1.Rows.Count + 5;
	        rng = hoja_trabajo.get_Range("G1","G"+ lineas.ToString());
	        rng.NumberFormat = "dd/MM/yyyy";
	        
	        for (int i = 0; i < dataGridView1.Rows.Count -1 ; i++)
	        {
	            for (int j = 0; j < 7; j++)
	            {
	         
	                hoja_trabajo.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
	            }
	        }
	 
	        
	        libros_trabajo.SaveAs(fichero, 
	            Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
	        libros_trabajo.Close(true);
	        aplicacion.Quit();	
			
			
			} catch (Exception ex) {
				
				MessageBox.Show(ex.Message.ToString());
			}
			
			
			MessageBox.Show("Exportacion Finalizada");
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			informePuntoinfo();
		}
		void Button5Click(object sender, EventArgs e)
		{
			informePuntoinfo();
			rutafichero("PuntoInfo");
			exportarPuntoinfo();
		}
		void Button2Click(object sender, EventArgs e)
		{
	
		}
		
		void rutafichero(string informe)
		{
			saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			saveFileDialog1.FileName = "Reporte "+ informe + " " + hoy;
			if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK){
				fichero = saveFileDialog1.FileName.ToString();
				
			}
			

		}
		
		
	} // final del archivo
}
