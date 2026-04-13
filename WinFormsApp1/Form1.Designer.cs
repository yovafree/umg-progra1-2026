namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            lblResultado = new Label();
            txtFibonacci = new TextBox();
            btnAbrirFormularioDos = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.BackgroundImage = Properties.Resources.save;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("ROG Fonts", 9F);
            button1.Location = new Point(56, 266);
            button1.Name = "button1";
            button1.Size = new Size(237, 68);
            button1.TabIndex = 0;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseHover += button1_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(56, 40);
            label1.Name = "label1";
            label1.Size = new Size(421, 28);
            label1.TabIndex = 1;
            label1.Text = "Programa que permite sumar dos números:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(56, 84);
            label2.Name = "label2";
            label2.Size = new Size(206, 28);
            label2.TabIndex = 2;
            label2.Text = "Ingrese el número 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(56, 131);
            label3.Name = "label3";
            label3.Size = new Size(206, 28);
            label3.TabIndex = 3;
            label3.Text = "Ingrese el número 2:";
            // 
            // txtNumero1
            // 
            txtNumero1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtNumero1.Location = new Point(268, 84);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(300, 34);
            txtNumero1.TabIndex = 4;
            txtNumero1.KeyPress += txtNumero1_KeyPress;
            // 
            // txtNumero2
            // 
            txtNumero2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtNumero2.Location = new Point(268, 131);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(300, 34);
            txtNumero2.TabIndex = 5;
            txtNumero2.KeyPress += txtNumero2_KeyPress;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblResultado.Location = new Point(56, 201);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(160, 28);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "El Resultado es:";
            // 
            // txtFibonacci
            // 
            txtFibonacci.Location = new Point(56, 366);
            txtFibonacci.Multiline = true;
            txtFibonacci.Name = "txtFibonacci";
            txtFibonacci.Size = new Size(570, 189);
            txtFibonacci.TabIndex = 7;
            // 
            // btnAbrirFormularioDos
            // 
            btnAbrirFormularioDos.Location = new Point(558, 277);
            btnAbrirFormularioDos.Name = "btnAbrirFormularioDos";
            btnAbrirFormularioDos.Size = new Size(94, 29);
            btnAbrirFormularioDos.TabIndex = 8;
            btnAbrirFormularioDos.Text = "Abrir Formulario";
            btnAbrirFormularioDos.UseVisualStyleBackColor = true;
            btnAbrirFormularioDos.Click += btnAbrirFormularioDos_Click;
            // 
            // button2
            // 
            button2.Location = new Point(562, 321);
            button2.Name = "button2";
            button2.Size = new Size(155, 29);
            button2.TabIndex = 9;
            button2.Text = "Agregar Usuarios";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(962, 595);
            Controls.Add(button2);
            Controls.Add(btnAbrirFormularioDos);
            Controls.Add(txtFibonacci);
            Controls.Add(lblResultado);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Aplicación de Ejemplo - Progra I";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Label lblResultado;
        private TextBox txtFibonacci;
        private Button btnAbrirFormularioDos;
        private Button button2;
    }
}
