/*
 * Creado por SharpDevelop.
 * Usuario: robiz
 * Fecha: 17/10/2017
 * Hora: 2:48
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ONG_Manager
{
	partial class FormFormacion1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button11 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(960, 717);
			this.tabControl1.TabIndex = 22;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage1.Controls.Add(this.groupBox3);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(952, 691);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "CURSOS";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button9);
			this.groupBox3.Controls.Add(this.button8);
			this.groupBox3.Controls.Add(this.button7);
			this.groupBox3.Controls.Add(this.dataGridView2);
			this.groupBox3.Location = new System.Drawing.Point(9, 434);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(758, 251);
			this.groupBox3.TabIndex = 36;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "ALUMNOS";
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(344, 26);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(177, 23);
			this.button9.TabIndex = 36;
			this.button9.Text = "HOJA DE FIRMAS";
			this.button9.UseVisualStyleBackColor = true;
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(161, 26);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(177, 23);
			this.button8.TabIndex = 35;
			this.button8.Text = "VER ASISTENTES";
			this.button8.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(11, 26);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(144, 23);
			this.button7.TabIndex = 34;
			this.button7.Text = "AÑADIR FICHA";
			this.button7.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(9, 55);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(742, 183);
			this.dataGridView2.TabIndex = 33;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button4);
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.dataGridView1);
			this.groupBox2.Location = new System.Drawing.Point(10, 27);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(759, 250);
			this.groupBox2.TabIndex = 35;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "GESTION DE CURSOS";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(252, 22);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(139, 23);
			this.button4.TabIndex = 32;
			this.button4.Text = "EXPORTAR CURSOS";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(171, 22);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 31;
			this.button3.Text = "ELIMINAR";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(90, 22);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 30;
			this.button2.Text = "MODIFICAR";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(9, 22);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 29;
			this.button1.Text = "AÑADIR";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(9, 51);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(726, 193);
			this.dataGridView1.TabIndex = 28;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button11);
			this.groupBox1.Controls.Add(this.button10);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(10, 309);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(759, 100);
			this.groupBox1.TabIndex = 34;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "BUSCAR DE CURSOS";
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(672, 65);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(80, 23);
			this.button11.TabIndex = 28;
			this.button11.Text = "CANCELAR";
			this.button11.UseVisualStyleBackColor = true;
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(586, 65);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(80, 23);
			this.button10.TabIndex = 27;
			this.button10.Text = "ACEPTAR";
			this.button10.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(609, 25);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(143, 20);
			this.textBox1.TabIndex = 26;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(540, 25);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 23);
			this.label4.TabIndex = 25;
			this.label4.Text = "NOMBRE:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(363, 25);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 24;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(238, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 23);
			this.label3.TabIndex = 23;
			this.label3.Text = "CURSO COMPLETADO:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(53, 25);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 22;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(10, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 23);
			this.label2.TabIndex = 21;
			this.label2.Text = "TIPO:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(952, 691);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "ALUMNOS / PROFESORADO";
			// 
			// FormFormacion1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 761);
			this.ControlBox = false;
			this.Controls.Add(this.tabControl1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormFormacion1";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "FormFormacion1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
