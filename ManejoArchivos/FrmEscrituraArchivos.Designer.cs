
namespace ManejoArchivos
{
    partial class FrmEscrituraArchivos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrearArchivo = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLeerArchivo = new System.Windows.Forms.Button();
            this.txtDatosArchivos = new System.Windows.Forms.RichTextBox();
            this.btnCopiaArchivo = new System.Windows.Forms.Button();
            this.btnCopiarArchivo = new System.Windows.Forms.Button();
            this.btnMoverArchivo = new System.Windows.Forms.Button();
            this.btnEliminarArchivo = new System.Windows.Forms.Button();
            this.btnobtenerruta = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnCrearArchivo
            // 
            this.btnCrearArchivo.Location = new System.Drawing.Point(677, 256);
            this.btnCrearArchivo.Name = "btnCrearArchivo";
            this.btnCrearArchivo.Size = new System.Drawing.Size(103, 23);
            this.btnCrearArchivo.TabIndex = 1;
            this.btnCrearArchivo.Text = "Crear Archivo";
            this.btnCrearArchivo.UseVisualStyleBackColor = true;
            this.btnCrearArchivo.Click += new System.EventHandler(this.btnCrearArchivo_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(94, 15);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(419, 20);
            this.txtFilePath.TabIndex = 2;
            this.txtFilePath.Text = "C:\\Users\\Waldemar\\Desktop\\Cosas Programacion\\windowsform\\Archivos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ruta de Archivo";
            // 
            // btnLeerArchivo
            // 
            this.btnLeerArchivo.Location = new System.Drawing.Point(652, 12);
            this.btnLeerArchivo.Name = "btnLeerArchivo";
            this.btnLeerArchivo.Size = new System.Drawing.Size(103, 23);
            this.btnLeerArchivo.TabIndex = 4;
            this.btnLeerArchivo.Text = "Leer Archivo";
            this.btnLeerArchivo.UseVisualStyleBackColor = true;
            this.btnLeerArchivo.Click += new System.EventHandler(this.btnLeerArchivo_Click);
            // 
            // txtDatosArchivos
            // 
            this.txtDatosArchivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatosArchivos.Location = new System.Drawing.Point(7, 41);
            this.txtDatosArchivos.Name = "txtDatosArchivos";
            this.txtDatosArchivos.Size = new System.Drawing.Size(773, 209);
            this.txtDatosArchivos.TabIndex = 5;
            this.txtDatosArchivos.Text = "";
            // 
            // btnCopiaArchivo
            // 
            this.btnCopiaArchivo.Location = new System.Drawing.Point(203, 256);
            this.btnCopiaArchivo.Name = "btnCopiaArchivo";
            this.btnCopiaArchivo.Size = new System.Drawing.Size(141, 23);
            this.btnCopiaArchivo.TabIndex = 6;
            this.btnCopiaArchivo.Text = "Hacer copia de archivo";
            this.btnCopiaArchivo.UseVisualStyleBackColor = true;
            this.btnCopiaArchivo.Click += new System.EventHandler(this.btnCopiaArchivo_Click);
            // 
            // btnCopiarArchivo
            // 
            this.btnCopiarArchivo.Location = new System.Drawing.Point(568, 256);
            this.btnCopiarArchivo.Name = "btnCopiarArchivo";
            this.btnCopiarArchivo.Size = new System.Drawing.Size(103, 23);
            this.btnCopiarArchivo.TabIndex = 7;
            this.btnCopiarArchivo.Text = "Copiar Archivo";
            this.btnCopiarArchivo.UseVisualStyleBackColor = true;
            this.btnCopiarArchivo.Click += new System.EventHandler(this.btnCopiarArchivo_Click);
            // 
            // btnMoverArchivo
            // 
            this.btnMoverArchivo.Location = new System.Drawing.Point(350, 256);
            this.btnMoverArchivo.Name = "btnMoverArchivo";
            this.btnMoverArchivo.Size = new System.Drawing.Size(103, 23);
            this.btnMoverArchivo.TabIndex = 8;
            this.btnMoverArchivo.Text = "Mover Archivo";
            this.btnMoverArchivo.UseVisualStyleBackColor = true;
            this.btnMoverArchivo.Click += new System.EventHandler(this.btnMoverArchivo_Click);
            // 
            // btnEliminarArchivo
            // 
            this.btnEliminarArchivo.Location = new System.Drawing.Point(459, 256);
            this.btnEliminarArchivo.Name = "btnEliminarArchivo";
            this.btnEliminarArchivo.Size = new System.Drawing.Size(103, 23);
            this.btnEliminarArchivo.TabIndex = 9;
            this.btnEliminarArchivo.Text = "Eliminar Archivo";
            this.btnEliminarArchivo.UseVisualStyleBackColor = true;
            this.btnEliminarArchivo.Click += new System.EventHandler(this.btnEliminarArchivo_Click);
            // 
            // btnobtenerruta
            // 
            this.btnobtenerruta.Location = new System.Drawing.Point(543, 12);
            this.btnobtenerruta.Name = "btnobtenerruta";
            this.btnobtenerruta.Size = new System.Drawing.Size(103, 23);
            this.btnobtenerruta.TabIndex = 10;
            this.btnobtenerruta.Text = "Obtener Ruta ";
            this.btnobtenerruta.UseVisualStyleBackColor = true;
            this.btnobtenerruta.Click += new System.EventHandler(this.btnobtenerruta_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmEscrituraArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 298);
            this.Controls.Add(this.btnobtenerruta);
            this.Controls.Add(this.btnEliminarArchivo);
            this.Controls.Add(this.btnMoverArchivo);
            this.Controls.Add(this.btnCopiarArchivo);
            this.Controls.Add(this.btnCopiaArchivo);
            this.Controls.Add(this.txtDatosArchivos);
            this.Controls.Add(this.btnLeerArchivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnCrearArchivo);
            this.Name = "FrmEscrituraArchivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mantenimiento Archivos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCrearArchivo;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLeerArchivo;
        private System.Windows.Forms.RichTextBox txtDatosArchivos;
        private System.Windows.Forms.Button btnCopiaArchivo;
        private System.Windows.Forms.Button btnCopiarArchivo;
        private System.Windows.Forms.Button btnMoverArchivo;
        private System.Windows.Forms.Button btnEliminarArchivo;
        private System.Windows.Forms.Button btnobtenerruta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

