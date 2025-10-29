namespace frontGYM_.Reportes
{
    partial class Reportes
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
            Volver = new Button();
            label6 = new Label();
            Ganancias = new Button();
            Cliente = new Button();
            SuspendLayout();
            // 
            // Volver
            // 
            Volver.BackColor = Color.Red;
            Volver.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Volver.ForeColor = SystemColors.ControlLightLight;
            Volver.Location = new Point(649, 387);
            Volver.Name = "Volver";
            Volver.Size = new Size(105, 36);
            Volver.TabIndex = 44;
            Volver.Text = "volver!";
            Volver.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(351, 96);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 43;
            label6.Text = "REPORTES";
            // 
            // Ganancias
            // 
            Ganancias.Location = new Point(64, 179);
            Ganancias.Name = "Ganancias";
            Ganancias.Size = new Size(293, 81);
            Ganancias.TabIndex = 47;
            Ganancias.Text = "Ver ganancias";
            Ganancias.UseVisualStyleBackColor = true;
            // 
            // Cliente
            // 
            Cliente.Location = new Point(459, 179);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(293, 81);
            Cliente.TabIndex = 46;
            Cliente.Text = "Ver clientes";
            Cliente.UseVisualStyleBackColor = true;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Ganancias);
            Controls.Add(Cliente);
            Controls.Add(Volver);
            Controls.Add(label6);
            Name = "Reportes";
            Text = "Resportes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Volver;
        private Label label6;
        private Button ABMSuscrip;
        private Button ABMCliente;
        private Button Ganancias;
        private Button Cliente;
    }
}