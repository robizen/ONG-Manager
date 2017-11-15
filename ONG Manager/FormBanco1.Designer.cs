/*
 * Creado por SharpDevelop.
 * Usuario: ops29rb12
 * Fecha: 08/11/2017
 * Hora: 19:53
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ONG_Manager
{
	partial class FormBanco1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView SALIDAS;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView STOCK;
		
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.STOCK = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.SALIDAS = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.STOCK)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SALIDAS)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(960, 695);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "BANCO DE ALIMENTOS";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.STOCK);
			this.groupBox2.Location = new System.Drawing.Point(6, 60);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(404, 617);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "STOCK ACTUAL";
			// 
			// STOCK
			// 
			this.STOCK.AllowUserToAddRows = false;
			this.STOCK.AllowUserToDeleteRows = false;
			this.STOCK.AllowUserToResizeColumns = false;
			this.STOCK.AllowUserToResizeRows = false;
			this.STOCK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.STOCK.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.STOCK.Location = new System.Drawing.Point(6, 19);
			this.STOCK.Name = "STOCK";
			this.STOCK.Size = new System.Drawing.Size(388, 592);
			this.STOCK.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.SALIDAS);
			this.groupBox3.Location = new System.Drawing.Point(550, 60);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(404, 617);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "SALIDAS";
			// 
			// SALIDAS
			// 
			this.SALIDAS.AllowUserToAddRows = false;
			this.SALIDAS.AllowUserToDeleteRows = false;
			this.SALIDAS.AllowUserToResizeRows = false;
			this.SALIDAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SALIDAS.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.SALIDAS.Location = new System.Drawing.Point(6, 19);
			this.SALIDAS.Name = "SALIDAS";
			this.SALIDAS.Size = new System.Drawing.Size(388, 592);
			this.SALIDAS.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(416, 19);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "EDITAR STOCK";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(416, 336);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(128, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = ">>>>>>";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// FormBanco1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 762);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormBanco1";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "FormBanco1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.STOCK)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SALIDAS)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
