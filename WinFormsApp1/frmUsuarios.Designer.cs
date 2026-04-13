namespace WinFormsApp1
{
    partial class frmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNuevo = new Button();
            txtNombres = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtApellidos = new TextBox();
            txtEdad = new TextBox();
            btnGuardar = new Button();
            dgvUsuarios = new DataGridView();
            Nombres = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(42, 210);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 56);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo Usuario";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(137, 50);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(205, 27);
            txtNombres.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 50);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombres:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 97);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "Apellidos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 144);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Edad:";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(137, 94);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(205, 27);
            txtApellidos.TabIndex = 5;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(137, 141);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(205, 27);
            txtEdad.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(137, 210);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(83, 56);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar Usuario";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { Nombres, Apellidos, Edad });
            dgvUsuarios.Location = new Point(47, 289);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(643, 188);
            dgvUsuarios.TabIndex = 8;
            // 
            // Nombres
            // 
            Nombres.HeaderText = "Nombres";
            Nombres.MinimumWidth = 6;
            Nombres.Name = "Nombres";
            Nombres.Width = 125;
            // 
            // Apellidos
            // 
            Apellidos.HeaderText = "Apellidos";
            Apellidos.MinimumWidth = 6;
            Apellidos.Name = "Apellidos";
            Apellidos.Width = 125;
            // 
            // Edad
            // 
            Edad.HeaderText = "Edad";
            Edad.MinimumWidth = 6;
            Edad.Name = "Edad";
            Edad.Width = 125;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 505);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnGuardar);
            Controls.Add(txtEdad);
            Controls.Add(txtApellidos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombres);
            Controls.Add(btnNuevo);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevo;
        private TextBox txtNombres;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtApellidos;
        private TextBox txtEdad;
        private Button btnGuardar;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn Edad;
    }
}