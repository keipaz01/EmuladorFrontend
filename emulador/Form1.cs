using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emulador
{
    public partial class frmLista : Form
    {
        public frmLista()
        {
            InitializeComponent();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
               // sqlCon.Open();
            }
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(); // Este objeto se usa para poder ejecutar un exe
            startInfo.FileName = Application.StartupPath + @"\..\..\..\..\..\Emulators\NES\fceux-2.2.3\fceux.exe"; // esta propiedad debe contener la ruta del exe que se quiere ejecutar
            startInfo.Arguments = "\"" + Application.StartupPath + @"\..\..\..\..\..\Emulators\NES\roms\Super Mario Bros. 2.zip" + "\""; // esta propiedad debe contener el parametro que se le pasa al exe con la ruta del rom (para que sepa que juego se quiere cargar)
            Process.Start(startInfo); // Ejecutar el EXE

            // Nota: Application.StartupPath nos indica la ruta completa donde se encuentra el ejecutable de nuestro proyecto. Desde aqui podemos usar ..\ para indicar otra ruta diferente
        }

        private void frmLista_Load(object sender, EventArgs e)
        {
            String[] files = Directory.GetFiles(@"..\..\..\..\..\Emulators\.roms");
            DataTable table = new DataTable();
            table.Columns.Add("Juegos");

            for(int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name);
            }
            dgvRoms.DataSource = table;
        }
    }
}
