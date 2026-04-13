using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("¡Botón Guardar presionado!");
            //Debug.WriteLine("¡Botón Guardar presionado!");
            //MessageBox.Show("¡Botón Guardar presionado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int num1 = int.Parse(txtNumero1.Text);
            int num2 = int.Parse(txtNumero2.Text);
            int resultado = num1 + num2;
            lblResultado.Text = "El Resultado es: " + resultado;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            //MessageBox.Show("¡Estás pasando el mouse sobre el botón Guardar!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Formularios -  frmNombreDelFormulario
            // Botón - btnNombreDelBotón
            // Label - lblNombreDelLabel
            // TextBox - txtNombreDelTextBox
            // ComboBox - cmbNombreDelComboBox
            // ListBox - lstNombreDelListBox
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int fibonacci = 10;
            int a = 0, b = 1, c;
            for (int i = 0; i < fibonacci; i++)
            {
                txtFibonacci.AppendText(a + Environment.NewLine);
                c = a + b;
                a = b;
                b = c;
            }
        }

        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y control de retroceso
            preventNonNumericInput(sender, e);
        }

        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            preventNonNumericInput(sender, e);
        }

        private void preventNonNumericInput(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y control de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAbrirFormularioDos_Click(object sender, EventArgs e)
        {
            frmDos frmDos = new frmDos();
            frmDos.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmUsuarios us = new frmUsuarios();
            us.ShowDialog();
        }
    }
}
