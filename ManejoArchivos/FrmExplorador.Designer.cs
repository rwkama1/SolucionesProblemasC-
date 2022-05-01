
namespace ManejoArchivos
{
    partial class FrmExplorador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lstArchivos = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grpFileName = new System.Windows.Forms.GroupBox();
            this.lblfilename = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblfiletype = new System.Windows.Forms.Label();
            this.grpFileName.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Location = new System.Drawing.Point(94, 15);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(599, 20);
            this.txtRutaArchivo.TabIndex = 1;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(699, 13);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lstArchivos
            // 
            this.lstArchivos.HideSelection = false;
            this.lstArchivos.LargeImageList = this.imageList1;
            this.lstArchivos.Location = new System.Drawing.Point(12, 42);
            this.lstArchivos.Name = "lstArchivos";
            this.lstArchivos.Size = new System.Drawing.Size(762, 348);
            this.lstArchivos.SmallImageList = this.imageList1;
            this.lstArchivos.TabIndex = 3;
            this.lstArchivos.UseCompatibleStateImageBehavior = false;
            this.lstArchivos.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstArchivos_ItemSelectionChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(48, 48);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // grpFileName
            // 
            this.grpFileName.Controls.Add(this.lblfilename);
            this.grpFileName.ForeColor = System.Drawing.Color.Navy;
            this.grpFileName.Location = new System.Drawing.Point(12, 397);
            this.grpFileName.Name = "grpFileName";
            this.grpFileName.Size = new System.Drawing.Size(95, 41);
            this.grpFileName.TabIndex = 4;
            this.grpFileName.TabStop = false;
            this.grpFileName.Text = "File Name";
            // 
            // lblfilename
            // 
            this.lblfilename.AutoSize = true;
            this.lblfilename.Location = new System.Drawing.Point(30, 16);
            this.lblfilename.Name = "lblfilename";
            this.lblfilename.Size = new System.Drawing.Size(0, 13);
            this.lblfilename.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblfiletype);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(679, 397);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(95, 41);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Type";
            // 
            // lblfiletype
            // 
            this.lblfiletype.AutoSize = true;
            this.lblfiletype.Location = new System.Drawing.Point(26, 16);
            this.lblfiletype.Name = "lblfiletype";
            this.lblfiletype.Size = new System.Drawing.Size(0, 13);
            this.lblfiletype.TabIndex = 1;
            // 
            // FrmExplorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpFileName);
            this.Controls.Add(this.lstArchivos);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtRutaArchivo);
            this.Controls.Add(this.btnBack);
            this.Name = "FrmExplorador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Explorador";
            this.Load += new System.EventHandler(this.FrmExplorador_Load);
            this.grpFileName.ResumeLayout(false);
            this.grpFileName.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ListView lstArchivos;
        private System.Windows.Forms.GroupBox grpFileName;
        private System.Windows.Forms.Label lblfilename;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblfiletype;
        private System.Windows.Forms.ImageList imageList1;
    }
}