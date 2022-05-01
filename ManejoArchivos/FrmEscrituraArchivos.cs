using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoArchivos
{
    public partial class FrmEscrituraArchivos : Form
    {
        public FrmEscrituraArchivos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void btnCrearArchivo_Click(object sender, EventArgs e)
        {
            string path = @txtFilePath.Text + @"\escrituratxt.txt";
            StreamWriter sw = new StreamWriter(path,true);//El true significa que el archivo no se actualizara

            sw.WriteLine("Esta es la primera linea del archivo");
            sw.WriteLine("Esta es la segunda linea del archivo");
            sw.WriteLine("Esta es la tercera linea del archivo");
            sw.WriteLine("Esta es la cuarta linea del archivo");
            sw.WriteLine("Esta es la quinta linea del archivo");
            sw.Close();

        }

        private void btnLeerArchivo_Click(object sender, EventArgs e)
        {
            string path = @txtFilePath.Text + @"\escrituratxt.txt";
            string linea="";
            StreamReader sr = new StreamReader(path);
            while ((linea= sr.ReadLine())!=null)
            {
                txtDatosArchivos.AppendText(linea+"\n");
            }
           
            sr.Close();

        }

        private void btnCopiaArchivo_Click(object sender, EventArgs e)
        {
            string nombrearchivo = @"\escrituratxt.txt";
            string path = @txtFilePath.Text + nombrearchivo;
            if(File.Exists(path))//Verifico si el archivo ya existe
            {
                nombrearchivo = @"\escrituratxt " + Guid.NewGuid().ToString() + ".txt";
                 path = @txtFilePath.Text + nombrearchivo;
            }

            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine("Esta es la N linea del archivo");
            sw.Close();
        }

        private void btnCopiarArchivo_Click(object sender, EventArgs e)
        {
            //string ruta_archivo_a_mover = @"C:\Users\Waldemar\Desktop\Cosas Programacion\windowsform\Archivos\CopiaArchivo";
            //string pathincial = @txtFilePath.Text + @"\escrituratxt.txt";
            //string pathfinal = ruta_archivo_a_mover + @"\escrituratxtcopia.txt";
            //if (!Directory.Exists(ruta_archivo_a_mover))
            //{
            //    Directory.CreateDirectory(ruta_archivo_a_mover);
            //}
            //if (File.Exists(pathincial))
            //{
            //    File.Copy(pathincial, pathfinal, true);//True significa que remplazo el archivo cuando lo copio

            //}
        }

        private void btnMoverArchivo_Click(object sender, EventArgs e)
        {
            //string ruta_archivo_a_mover = @"C:\Users\Waldemar\Desktop\Cosas Programacion\windowsform\Archivos\CopiaArchivo";
            //string pathincial = @txtFilePath.Text + @"\escrituratxt.txt";
            //string pathfinal = ruta_archivo_a_mover + @"\escrituratxtcopia.txt";
            //if (!Directory.Exists(ruta_archivo_a_mover))
            //{
            //    Directory.CreateDirectory(ruta_archivo_a_mover);
            //}
            //if (File.Exists(pathincial))
            //{
            //    File.Move(pathincial, pathfinal);

            //}
        }

        private void btnEliminarArchivo_Click(object sender, EventArgs e)
        {
            //string pathincial = @txtFilePath.Text + @"\escrituratxt.txt";
            //File.Delete(pathincial);
        }

        private void btnobtenerruta_Click(object sender, EventArgs e)
        {
            //string rutaarchivo = string.Empty;
         
            //if (openFileDialog1.ShowDialog()==DialogResult.OK)
            //{
            //    rutaarchivo = openFileDialog1.FileName;
            //}
            //txtFilePath.Text = rutaarchivo;
        }
    }
}
