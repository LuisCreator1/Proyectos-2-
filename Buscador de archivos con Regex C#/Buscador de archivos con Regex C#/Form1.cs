using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BuscadorDeArchivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSeleccionarCarpeta_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialogo = new FolderBrowserDialog())
            {
                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    txtRuta.Text = dialogo.SelectedPath;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string ruta = txtRuta.Text;
            string patron = txtPatron.Text;

            if (!Directory.Exists(ruta))
            {
                MessageBox.Show("La ruta especificada no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Regex regex = new Regex(patron, RegexOptions.IgnoreCase);
                string[] archivos = Directory.GetFiles(ruta, "*", SearchOption.AllDirectories);
                lstResultados.Items.Clear();

                foreach (string archivo in archivos)
                {
                    string nombre = Path.GetFileName(archivo);
                    if (regex.IsMatch(nombre))
                    {
                        lstResultados.Items.Add(archivo);
                    }
                }

                if (lstResultados.Items.Count == 0)
                {
                    MessageBox.Show("No se encontraron archivos con ese patrón.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar archivos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Button btnSeleccionarCarpeta;
        private Button btnBuscar;

        private void InitializeComponent()
        {
            this.btnSeleccionarCarpeta = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.txtPatron = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSeleccionarCarpeta
            // 
            this.btnSeleccionarCarpeta.Location = new System.Drawing.Point(304, 67);
            this.btnSeleccionarCarpeta.Name = "btnSeleccionarCarpeta";
            this.btnSeleccionarCarpeta.Size = new System.Drawing.Size(128, 49);
            this.btnSeleccionarCarpeta.TabIndex = 0;
            this.btnSeleccionarCarpeta.Text = "boton";
            this.btnSeleccionarCarpeta.UseVisualStyleBackColor = true;
            this.btnSeleccionarCarpeta.Click += new System.EventHandler(this.btnSeleccionarCarpeta_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(304, 143);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(128, 49);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "boton";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.Location = new System.Drawing.Point(34, 67);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(235, 49);
            this.txtRuta.TabIndex = 2;
            // 
            // txtPatron
            // 
            this.txtPatron.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatron.Location = new System.Drawing.Point(34, 143);
            this.txtPatron.Name = "txtPatron";
            this.txtPatron.Size = new System.Drawing.Size(235, 49);
            this.txtPatron.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(90, 226);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(561, 333);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtPatron);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSeleccionarCarpeta);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox txtRuta;
        private TextBox txtPatron;
        private ListBox listBox1;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
