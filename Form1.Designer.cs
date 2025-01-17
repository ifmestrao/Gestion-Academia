namespace Fase2_IsaccMestra
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txbcontraseña = new TextBox();
            btnacceder = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(209, 43);
            label1.Name = "label1";
            label1.Size = new Size(379, 40);
            label1.TabIndex = 0;
            label1.Text = "Gestor - Melodías Perfectas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(263, 115);
            label2.Name = "label2";
            label2.Size = new Size(270, 32);
            label2.TabIndex = 1;
            label2.Text = "Isacc Fidel Mestra Ochoa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(199, 251);
            label3.Name = "label3";
            label3.Size = new Size(189, 27);
            label3.TabIndex = 2;
            label3.Text = "Ingresar Contraseña:";
            // 
            // txbcontraseña
            // 
            txbcontraseña.Location = new Point(420, 247);
            txbcontraseña.Name = "txbcontraseña";
            txbcontraseña.PasswordChar = '*';
            txbcontraseña.Size = new Size(194, 31);
            txbcontraseña.TabIndex = 3;
            // 
            // btnacceder
            // 
            btnacceder.BackColor = Color.FromArgb(0, 192, 192);
            btnacceder.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnacceder.Location = new Point(348, 347);
            btnacceder.Name = "btnacceder";
            btnacceder.Size = new Size(124, 44);
            btnacceder.TabIndex = 4;
            btnacceder.Text = "Acceder";
            btnacceder.UseVisualStyleBackColor = false;
            btnacceder.Click += btnacceder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnacceder);
            Controls.Add(txbcontraseña);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ingreso al sistema";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txbcontraseña;
        private Button btnacceder;
    }
}