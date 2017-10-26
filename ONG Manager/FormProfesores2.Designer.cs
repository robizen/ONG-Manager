/*
 * Creado por SharpDevelop.
 * Usuario: robiz
 * Fecha: 22/10/2017
 * Hora: 1:39
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ONG_Manager
{
	partial class FormProfesores2
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView dgcursos;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox tbnif;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbnombre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbid;
		private System.Windows.Forms.Label label1;
		
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dgcursos = new System.Windows.Forms.DataGridView();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tbnif = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbnombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbid = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgcursos)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(953, 668);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "ASIGNACIÓN DE CURSOS AL PROFESOR";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 505);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(201, 23);
			this.button2.TabIndex = 10;
			this.button2.Text = "ASIGNAR CURSOS AL PROFESOR";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dgcursos);
			this.groupBox3.Controls.Add(this.checkBox1);
			this.groupBox3.Controls.Add(this.button1);
			this.groupBox3.Controls.Add(this.dateTimePicker1);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.textBox1);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Location = new System.Drawing.Point(7, 114);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(939, 385);
			this.groupBox3.TabIndex = 9;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "CURSOS";
			// 
			// dgcursos
			// 
			this.dgcursos.AllowUserToAddRows = false;
			this.dgcursos.AllowUserToDeleteRows = false;
			this.dgcursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgcursos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgcursos.Location = new System.Drawing.Point(6, 55);
			this.dgcursos.Name = "dgcursos";
			this.dgcursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgcursos.Size = new System.Drawing.Size(927, 313);
			this.dgcursos.TabIndex = 20;
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(674, 16);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(143, 24);
			this.checkBox1.TabIndex = 19;
			this.checkBox1.Text = "FILTRAR POR FECHA";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(237, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(141, 23);
			this.button1.TabIndex = 18;
			this.button1.Text = "BUSCAR POR NOMBRE";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(468, 18);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 17;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(384, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(102, 23);
			this.label5.TabIndex = 16;
			this.label5.Text = "FECHA INICIO:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(102, 18);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(129, 20);
			this.textBox1.TabIndex = 15;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 23);
			this.label4.TabIndex = 14;
			this.label4.Text = "NOMBRE CURSO:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tbnif);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.tbnombre);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.tbid);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(6, 31);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(941, 70);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "DATOS DEL PROFESOR";
			// 
			// tbnif
			// 
			this.tbnif.Enabled = false;
			this.tbnif.Location = new System.Drawing.Point(785, 28);
			this.tbnif.Name = "tbnif";
			this.tbnif.Size = new System.Drawing.Size(150, 20);
			this.tbnif.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(746, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 23);
			this.label3.TabIndex = 12;
			this.label3.Text = "NIF:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbnombre
			// 
			this.tbnombre.Enabled = false;
			this.tbnombre.Location = new System.Drawing.Point(373, 28);
			this.tbnombre.Name = "tbnombre";
			this.tbnombre.Size = new System.Drawing.Size(367, 20);
			this.tbnombre.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(238, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 23);
			this.label2.TabIndex = 10;
			this.label2.Text = "APELLIDOS Y NOMBRE:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbid
			// 
			this.tbid.Enabled = false;
			this.tbid.Location = new System.Drawing.Point(96, 28);
			this.tbid.Name = "tbid";
			this.tbid.Size = new System.Drawing.Size(136, 20);
			this.tbid.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "ID PROFESOR:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormProfesores2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 761);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormProfesores2";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "FormProfesores2";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgcursos)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
