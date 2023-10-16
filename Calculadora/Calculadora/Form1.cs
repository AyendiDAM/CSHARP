using System.Diagnostics.Eventing.Reader;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                double sumandoa, sumandob, resultado;

                bool a = true;
                string n = txtNumero1.Text;
                string n2 = txtNumero2.Text;
                String vacia=txtNumero1.Text;



                int contador = 0, contador2 = 0;
                char c = ' ';


                for (int i = 0; i < n.Length; i++)
                {
                    c = char.ToUpper(n[i]);
                    if (c == ',')
                    {
                        contador++;


                    }
                    if (c == '.')
                    {
                        a = false;

                    }
                }
                for (int i = 0; i < n2.Length; i++)
                {
                    c = char.ToUpper(n2[i]);
                    if (c == ',')
                    {
                        contador2++;

                    }
                    if (c == '.')
                    {
                        a = false;

                    }
                }

                if (a)
                {
                 if (contador <= 1 && contador2 <= 1)
                    {
                        sumandoa = double.Parse(txtNumero1.Text);
                        sumandob = double.Parse(txtNumero2.Text);
                        resultado =sumandob + sumandoa;
                        txtResulttado.Text = resultado.ToString();
                        txtNumero1.Text = "";
                        txtNumero2.Text = "";

                    }
                    else 
                    {
                        MessageBox.Show("Introdujo: " + contador + " ','" + " no se puede introducir mas de una coma");
                        MessageBox.Show("Introdujo: " + contador2 + " ','" + " no se puede introducir mas de una coma");
                    }
                }
                 
               
                else {
                    MessageBox.Show("El " + n + " o " + n2 + " introducido debe dividirse por ',' , sino no se puede hacer la operación");
                }
                
   
            }
            catch (OverflowException)
            {
                MessageBox.Show("No puedo hacer la operación, el numero introducido supera los limites");
            }
            catch (FormatException)
            {
                MessageBox.Show("idayelin");
            }






        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int contador = 0;
                int contador2 = 0;
                double restaA, restaB, resultado;
                bool a = true;
                string n = txtNumero1.Text;
                string n2 = txtNumero2.Text;
                char c = ' ';
             

                for (int i = 0; i < n.Length; i++)
                {
                    c = char.ToUpper(n[i]);
                    if (c == ',')
                    {
                        contador++;

                    }
                    if (c == '.')
                    {
                        a = false;

                    }
                }
                for (int i = 0; i < n2.Length; i++)
                {
                    c = char.ToUpper(n2[i]);
                    if (c == ',')
                    {
                        contador2++;

                    }
                    if (c == '.')
                    {
                        a = false;

                    }
                }
                if (a)
                {
              
                 

                
                 if (contador <= 1 && contador2<=1)
                {
                    restaA = double.Parse(txtNumero1.Text);
                    restaB = double.Parse(txtNumero2.Text);
                    resultado = restaA - restaB;
                    txtResulttado.Text = resultado.ToString();
                    txtNumero1.Text = "";
                    txtNumero2.Text = "";
             
                }
                else  
                {
                    MessageBox.Show("Introdujo: " + contador + " ','" + " no se puede introducir mas de una coma");
                        MessageBox.Show("Introdujo: " + contador2 + " ','" + " no se puede introducir mas de una coma");
                    }
                }
                else
                {
                    MessageBox.Show("El " + n +" o "+n2 +" introducido debe estar dividido por ',' , sino no se puede hacer la operación");


                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("No puedo hacer la operación, el numero introducido supera los limites");
            }
            catch (FormatException)
            {
                MessageBox.Show("idayelin");
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar la calculadora?",
        "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                bool a = true;
                int contador2 = 0;
                int contador = 0;
                
                string n = txtNumero1.Text;
                string n2 = txtNumero2.Text;
                double multiplicaA, multiplicaB, resultado;
                char c = ' ';
                for (int i = 0; i < n.Length; i++)
                {
                    c = char.ToUpper(n[i]);
                    if (c == '.')
                    {
                        a = false;

                    }
                    if (c == ',')
                    {
                        contador++;

                    }
                }
                for (int i = 0; i < n2.Length; i++)
                {
                    c = char.ToUpper(n2[i]);
                    if (c == '.')
                    {
                        a = false;

                    }
                    if (c == ',')
                    {
                        contador2++;

                    }
                }
                if (a)
                {
                 
                
                 if (contador <= 1 && contador2<=1)
                {
                    // Código para el caso en que 'contador' sea menor o igual a 1
                    multiplicaA = double.Parse(txtNumero1.Text);
                    multiplicaB = double.Parse(txtNumero2.Text);
                    resultado = multiplicaA * multiplicaB;
                    txtResulttado.Text = resultado.ToString();
                    txtNumero1.Text = "";
                    txtNumero2.Text = "";
          
                }
                else 
                {
                    // Código para el caso en que 'contador' sea mayor que 1
                    MessageBox.Show("Introdujo: " + contador + " ','" + " no se puede introducir más de una coma");
                        MessageBox.Show("Introdujo: " + contador2 + " ','" + " no se puede introducir más de una coma");
                    }
                }
                else
                {
                    // Código para cualquier otro caso
                    MessageBox.Show("El " + n + " o " + n2 + " introducido debe poner los decimales con ',' sino no se puede hacer la operación");
                }


            }
            catch (OverflowException)
            {
                MessageBox.Show("No puedo hacer la operación, el numero introducido supera los limites");
            }
            catch (FormatException)
            {
                MessageBox.Show("has introducido algún carater no numérico");
            }

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {

            try
            {
                int contador2 = 0;
                int contador = 0;
                bool a = true;
                char c = ' ';

                double dividirA, dividirB, resultado;
                string n = txtNumero1.Text;
                string n2 = txtNumero2.Text;
                for (int i = 0; i < n.Length; i++)
                {
                    c = char.ToUpper(n[i]);
                    if (c == ',')
                    {
                        contador++;

                    }
                    if (c == '.')
                    {
                        a = false;

                    }
                }
                for (int i = 0; i < n2.Length; i++)
                {
                    c = char.ToUpper(n2[i]);
                    if (c == '.')
                    {
                        a = false;

                    }
                    if (c == ',')
                    {
                        contador2++;

                    }
                }
                if (a)
                {
               
            
                
                if (contador<=1 && contador2<=1)
                {
                    dividirA = double.Parse(txtNumero1.Text);
                    dividirB = double.Parse(txtNumero2.Text);
                    resultado = dividirA / dividirB;
                    txtResulttado.Text = resultado.ToString();
                    txtNumero1.Text = "";
                    txtNumero2.Text = "";
           
                }
                else 
                {
                    MessageBox.Show("Introdujo: " + contador + " ','" + " no se puede introducir mas de una coma");
                        MessageBox.Show("Introdujo: " + contador2 + " ','" + " no se puede introducir mas de una coma");
                    }
                }
                else
                {
                    MessageBox.Show("El " + n + " o "+n2+" introducido debe poner los decimales con ',' sino no se puede hacer la operación");
              
                }

      
        
            }
            catch (OverflowException)
            {
                MessageBox.Show("No puedo hacer la operación, el numero introducido supera los limites");
            }
            catch (FormatException)
            {
                MessageBox.Show("has introducido algún carater no numérico");
            }




        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            txtResulttado.Text = "";
        }
    }
}