/*
 * Creado por SharpDevelop.
 * Usuario: ops29rb12
 * Fecha: 31/10/2017
 * Hora: 19:57
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ONG_Manager
{
	partial class FormFormacion3
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox tbnombre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbid;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tb2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tb1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGridView dgridinscritos;
		private System.Windows.Forms.DataGridView dgriddisponibles;
		private System.Windows.Forms.TextBox tb3;
		
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
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.dgridinscritos = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dgriddisponibles = new System.Windows.Forms.DataGridView();
			this.tb3 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tb2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tb1 = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tbnombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbid = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgridinscritos)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgriddisponibles)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.groupBox4);
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(928, 657);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "ASIGNACIÓN DE ALUMNOS AL CURSO";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(793, 421);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(112, 23);
			this.button4.TabIndex = 27;
			this.button4.Text = "ELIMINAR";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(793, 207);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(112, 23);
			this.button3.TabIndex = 26;
			this.button3.Text = "AÑADIR";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(793, 178);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(112, 23);
			this.button2.TabIndex = 25;
			this.button2.Text = "LIMPIAR";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(793, 149);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 23);
			this.button1.TabIndex = 24;
			this.button1.Text = "BUSCAR";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.dgridinscritos);
			this.groupBox4.Location = new System.Drawing.Point(6, 402);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(768, 228);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "ALUMNOS INSCRITOS";
			// 
			// dgridinscritos
			// 
			this.dgridinscritos.AllowUserToAddRows = false;
			this.dgridinscritos.AllowUserToDeleteRows = false;
			this.dgridinscritos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgridinscritos.Location = new System.Drawing.Point(6, 19);
			this.dgridinscritos.Name = "dgridinscritos";
			this.dgridinscritos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgridinscritos.Size = new System.Drawing.Size(756, 203);
			this.dgridinscritos.TabIndex = 23;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dgriddisponibles);
			this.groupBox3.Controls.Add(this.tb3);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.tb2);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.tb1);
			this.groupBox3.Location = new System.Drawing.Point(6, 118);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(768, 278);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "ALUMNOS DISPONIBLES";
			// 
			// dgriddisponibles
			// 
			this.dgriddisponibles.AllowUserToAddRows = false;
			this.dgriddisponibles.AllowUserToDeleteRows = false;
			this.dgriddisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgriddisponibles.Location = new System.Drawing.Point(6, 60);
			this.dgriddisponibles.Name = "dgriddisponibles";
			this.dgriddisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgriddisponibles.Size = new System.Drawing.Size(756, 212);
			this.dgriddisponibles.TabIndex = 22;
			// 
			// tb3
			// 
			this.tb3.Location = new System.Drawing.Point(544, 31);
			this.tb3.Name = "tb3";
			this.tb3.Size = new System.Drawing.Size(193, 20);
			this.tb3.TabIndex = 21;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(504, 29);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 23);
			this.label5.TabIndex = 20;
			this.label5.Text = "NIF:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tb2
			// 
			this.tb2.Location = new System.Drawing.Point(305, 31);
			this.tb2.Name = "tb2";
			this.tb2.Size = new System.Drawing.Size(193, 20);
			this.tb2.TabIndex = 19;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(238, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 23);
			this.label3.TabIndex = 18;
			this.label3.Text = "APELLIDO1:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 29);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 23);
			this.label4.TabIndex = 16;
			this.label4.Text = "ID ALUMNO:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tb1
			// 
			this.tb1.Location = new System.Drawing.Point(82, 31);
			this.tb1.Name = "tb1";
			this.tb1.Size = new System.Drawing.Size(150, 20);
			this.tb1.TabIndex = 17;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tbnombre);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.tbid);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(6, 35);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(642, 67);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "DATOS CURSO";
			// 
			// tbnombre
			// 
			this.tbnombre.Enabled = false;
			this.tbnombre.Location = new System.Drawing.Point(346, 28);
			this.tbnombre.Name = "tbnombre";
			this.tbnombre.Size = new System.Drawing.Size(247, 20);
			this.tbnombre.TabIndex = 15;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(238, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 23);
			this.label2.TabIndex = 14;
			this.label2.Text = "NOMBRE CURSO:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbid
			// 
			this.tbid.Enabled = false;
			this.tbid.Location = new System.Drawing.Point(82, 27);
			this.tbid.Name = "tbid";
			this.tbid.Size = new System.Drawing.Size(150, 20);
			this.tbid.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 23);
			this.label1.TabIndex = 12;
			this.label1.Text = "ID CURSO:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormFormacion3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 762);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormFormacion3";
			this.Text = "FormFormacion3";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.groupBox1.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgridinscritos)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgriddisponibles)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
