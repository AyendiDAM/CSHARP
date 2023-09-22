namespace HolaMundo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int n = 10, a = 3, j = 121, suma = 0;
            suma = n + a;
            MessageBox.Show("la suma es de: " + n + " + " + a + "= " + suma);
        }

        private void btnPruebas_Click(object sender, EventArgs e)
        {
            //aqui sale una pantalla y con opciones de si,no o cancelar
            DialogResult result = MessageBox.Show("mas practica", "Ismael", MessageBoxButtons.YesNoCancel);
            MessageBox.Show(result.ToString());

        }

        private void btnVentana_Click(object sender, EventArgs e)
        {
            //creamos un segundo formulario
            Form nuevaVentana = new Form(); //esta en memoria
            nuevaVentana.Text = "nueva ventana no modal";//esta en memoria y le cambiamos el testo
            nuevaVentana.Owner = this;//el propietario es el principal seria un hijo de la que sale al comienzo el awner indica que son primas nos ayuda a localizarlo
            //nuevaVentana.Show();//es neceario para mostrar la información
            nuevaVentana.ShowDialog();//así no se carga el procesador
            //para compartir datos entre las ventanas
        }
    }
}