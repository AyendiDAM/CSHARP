namespace HolaMundo2
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
            btnPruebas = new Button();
            btnVentana = new Button();
            SuspendLayout();
            // 
            // btnPruebas
            // 
            btnPruebas.Location = new Point(93, 41);
            btnPruebas.Name = "btnPruebas";
            btnPruebas.Size = new Size(173, 50);
            btnPruebas.TabIndex = 0;
            btnPruebas.Text = "pruebas";
            btnPruebas.UseVisualStyleBackColor = true;
            btnPruebas.Click += btnPruebas_Click;
            // 
            // btnVentana
            // 
            btnVentana.Location = new Point(248, 188);
            btnVentana.Name = "btnVentana";
            btnVentana.Size = new Size(224, 47);
            btnVentana.TabIndex = 1;
            btnVentana.Text = "Crear ventana";
            btnVentana.UseVisualStyleBackColor = true;
            btnVentana.Click += btnVentana_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVentana);
            Controls.Add(btnPruebas);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPruebas;
        private Button btnVentana;
    }
}