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
    public partial class FrmExplorador : Form
    {
        private string filepath = @"C:\Users\Waldemar\Desktop\Cosas Programacion\windowsform\Archivos";
        private bool isFile = false;
        private string currentselectedItem = "";
        public FrmExplorador()
        {
            InitializeComponent();
        }

        private void FrmExplorador_Load(object sender, EventArgs e)
        {
            txtRutaArchivo.Text = filepath;
            CargarArchivosDirectiorios();
        }

        private void CargarArchivosDirectiorios()
        {
            DirectoryInfo filelist;
            try
            {
                filelist = new DirectoryInfo(filepath);
                FileInfo[] files = filelist.GetFiles();//GET ALL THE FILES
                DirectoryInfo[] dirs = filelist.GetDirectories();//GET ALL THE DIRS
                for (int i = 0; i < files.Length; i++)
                {
                    lstArchivos.Items.Add(files[i].Name);

                }
                for (int i = 0; i < dirs.Length; i++)
                {
                    lstArchivos.Items.Add(dirs[i].Name);

                }
            }
            catch 
            {

                throw;
            }
                  
        }
       
        private void lstArchivos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentselectedItem = e.Item.Text;
            FileAttributes fileAttr = File.GetAttributes(filepath + "/" + currentselectedItem);
            if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                txtRutaArchivo.Text = filepath + "/" + currentselectedItem;
            }
            else 

            {
                isFile = true;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            filepath = txtRutaArchivo.Text;
            CargarArchivosDirectiorios();
            isFile = false;
        }
    }
}
