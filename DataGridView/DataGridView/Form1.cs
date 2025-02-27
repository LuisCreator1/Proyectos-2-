namespace DataGridView
{
    public partial class Forms : Form
    {
        private int n = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnaAdicionar_Click(object sender, EventArgs e)
        {
            int n = dtgvProductos.Rows.Add();


            dtgvProductos.Rows[n].Cells[0].Value = txtCodigo.Text;
            dtgvProductos.Rows[n].Cells[1].Value = txtNombre.Text;
            dtgvProductos.Rows[n].Cells[2].Value = txtPrecio.Text;


            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPrecio.Text = string.Empty;
        }

        private void dtgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                lblInformacion.Text = (string)dtgvProductos.Rows[n].Cells[1].Value;

            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                dtgvProductos.Rows.RemoveAt(n);
            }
        }
    }
}