namespace HolaMundo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPruebas_Click(object sender, EventArgs e)
        {
            //aqui sale una pantalla y con opciones de si,no o cancelar
            DialogResult result = MessageBox.Show("hola","Prueba",MessageBoxButtons.YesNoCancel);
            MessageBox.Show(result.ToString());             
        }
    }
}