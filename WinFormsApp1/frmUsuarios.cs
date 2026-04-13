using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmUsuarios : Form
    {
        List<Usuario> usuarios;
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            usuarios = new List<Usuario>();
        }

        private void cargarUsuarios()
        {
            dgvUsuarios.Rows.Clear();
            // Agregar usuarios al DataGridView
            foreach (var usuario in usuarios)
            {
                dgvUsuarios.Rows.Add(usuario.Nombres, usuario.Apellidos, usuario.Edad);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtEdad.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new Usuario
            {
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Edad = int.TryParse(txtEdad.Text, out int edad) ? edad : 0
            };

            usuarios.Add(nuevoUsuario);
            cargarUsuarios();
        }
    }
}
