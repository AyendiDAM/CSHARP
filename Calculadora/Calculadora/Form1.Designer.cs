namespace Calculadora
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
            btnResta = new Button();
            btnSuma = new Button();
            btnSalir = new Button();
            groupBox1 = new GroupBox();
            btnDividir = new Button();
            btnMultiplicar = new Button();
            label3 = new Label();
            label2 = new Label();
            txtResulttado = new TextBox();
            label1 = new Label();
            txtNumero2 = new TextBox();
            txtNumero1 = new TextBox();
            btnBorrar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnResta
            // 
            btnResta.BackColor = SystemColors.AppWorkspace;
            btnResta.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnResta.Location = new Point(449, 291);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(98, 58);
            btnResta.TabIndex = 0;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = false;
            btnResta.Click += button1_Click;
            // 
            // btnSuma
            // 
            btnSuma.BackColor = SystemColors.AppWorkspace;
            btnSuma.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSuma.Location = new Point(314, 291);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(108, 58);
            btnSuma.TabIndex = 1;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = false;
            btnSuma.Click += button2_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(492, 498);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(btnBorrar);
            groupBox1.Controls.Add(btnDividir);
            groupBox1.Controls.Add(btnMultiplicar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnResta);
            groupBox1.Controls.Add(btnSuma);
            groupBox1.Controls.Add(txtResulttado);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNumero2);
            groupBox1.Controls.Add(txtNumero1);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(609, 447);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calculadora";
            // 
            // btnDividir
            // 
            btnDividir.BackColor = SystemColors.AppWorkspace;
            btnDividir.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDividir.Location = new Point(453, 367);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(94, 49);
            btnDividir.TabIndex = 7;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = false;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.BackColor = SystemColors.ActiveBorder;
            btnMultiplicar.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiplicar.ForeColor = SystemColors.ActiveCaptionText;
            btnMultiplicar.Location = new Point(314, 367);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(108, 49);
            btnMultiplicar.TabIndex = 6;
            btnMultiplicar.Text = "X";
            btnMultiplicar.UseVisualStyleBackColor = false;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 109);
            label3.Name = "label3";
            label3.Size = new Size(140, 31);
            label3.TabIndex = 5;
            label3.Text = "Operando 2:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 55);
            label2.Name = "label2";
            label2.Size = new Size(140, 31);
            label2.TabIndex = 4;
            label2.Text = "Operando 1:";
            // 
            // txtResulttado
            // 
            txtResulttado.Location = new Point(219, 201);
            txtResulttado.Name = "txtResulttado";
            txtResulttado.Size = new Size(125, 38);
            txtResulttado.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 208);
            label1.Name = "label1";
            label1.Size = new Size(115, 31);
            label1.TabIndex = 2;
            label1.Text = "Resultado";
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(219, 106);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(125, 38);
            txtNumero2.TabIndex = 1;
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(219, 55);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(125, 38);
            txtNumero1.TabIndex = 0;
            txtNumero1.TextChanged += txtNumero1_TextChanged;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = SystemColors.AppWorkspace;
            btnBorrar.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrar.ForeColor = SystemColors.ActiveCaptionText;
            btnBorrar.Location = new Point(46, 330);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(208, 45);
            btnBorrar.TabIndex = 8;
            btnBorrar.Text = "Borrar todo";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(744, 574);
            Controls.Add(groupBox1);
            Controls.Add(btnSalir);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnResta;
        private Button btnSuma;
        private Button btnSalir;
        private GroupBox groupBox1;
        private TextBox txtNumero1;
        private Label label3;
        private Label label2;
        private TextBox txtResulttado;
        private Label label1;
        private TextBox txtNumero2;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button btnBorrar;
    }
}