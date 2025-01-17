namespace Fase2_IsaccMestra
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtid = new TextBox();
            txtcosto = new TextBox();
            txtclases = new TextBox();
            txtnombre = new TextBox();
            cbintrumento = new ComboBox();
            Genero = new Label();
            label6 = new Label();
            rdfemenino = new RadioButton();
            rdmasculino = new RadioButton();
            grbgenero = new GroupBox();
            btnguardar = new Button();
            btncalcular = new Button();
            btnsalir = new Button();
            grbgenero.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(85, 63);
            label1.Name = "label1";
            label1.Size = new Size(40, 25);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(85, 121);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(85, 192);
            label3.Name = "label3";
            label3.Size = new Size(153, 25);
            label3.TabIndex = 2;
            label3.Text = "Instrumento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(85, 261);
            label4.Name = "label4";
            label4.Size = new Size(184, 25);
            label4.TabIndex = 3;
            label4.Text = "Costo por clase";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(85, 335);
            label5.Name = "label5";
            label5.Size = new Size(211, 25);
            label5.TabIndex = 4;
            label5.Text = "Número de clases";
            // 
            // txtid
            // 
            txtid.Location = new Point(316, 57);
            txtid.Name = "txtid";
            txtid.Size = new Size(284, 31);
            txtid.TabIndex = 5;
            // 
            // txtcosto
            // 
            txtcosto.Location = new Point(316, 261);
            txtcosto.Name = "txtcosto";
            txtcosto.ReadOnly = true;
            txtcosto.Size = new Size(227, 31);
            txtcosto.TabIndex = 6;
            // 
            // txtclases
            // 
            txtclases.Location = new Point(316, 335);
            txtclases.Name = "txtclases";
            txtclases.Size = new Size(227, 31);
            txtclases.TabIndex = 7;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(316, 115);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(284, 31);
            txtnombre.TabIndex = 8;
            // 
            // cbintrumento
            // 
            cbintrumento.FormattingEnabled = true;
            cbintrumento.Items.AddRange(new object[] { "Piano", "Guitarra", "Violín", "Batería", "Canto" });
            cbintrumento.Location = new Point(316, 192);
            cbintrumento.Name = "cbintrumento";
            cbintrumento.Size = new Size(227, 33);
            cbintrumento.TabIndex = 9;
            cbintrumento.SelectedIndexChanged += cbintrumento_SelectedIndexChanged;
            // 
            // Genero
            // 
            Genero.AutoSize = true;
            Genero.Location = new Point(92, 182);
            Genero.Name = "Genero";
            Genero.Size = new Size(0, 25);
            Genero.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(622, 259);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 12;
            // 
            // rdfemenino
            // 
            rdfemenino.AutoSize = true;
            rdfemenino.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rdfemenino.Location = new Point(114, 84);
            rdfemenino.Name = "rdfemenino";
            rdfemenino.Size = new Size(123, 26);
            rdfemenino.TabIndex = 13;
            rdfemenino.TabStop = true;
            rdfemenino.Text = "Femenino";
            rdfemenino.UseVisualStyleBackColor = true;
            // 
            // rdmasculino
            // 
            rdmasculino.AutoSize = true;
            rdmasculino.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rdmasculino.Location = new Point(114, 37);
            rdmasculino.Name = "rdmasculino";
            rdmasculino.Size = new Size(122, 26);
            rdmasculino.TabIndex = 14;
            rdmasculino.TabStop = true;
            rdmasculino.Text = "Masculino";
            rdmasculino.UseVisualStyleBackColor = true;
            // 
            // grbgenero
            // 
            grbgenero.Controls.Add(rdfemenino);
            grbgenero.Controls.Add(rdmasculino);
            grbgenero.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            grbgenero.Location = new Point(628, 235);
            grbgenero.Name = "grbgenero";
            grbgenero.Size = new Size(263, 131);
            grbgenero.TabIndex = 15;
            grbgenero.TabStop = false;
            grbgenero.Text = "Género";
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.FromArgb(0, 192, 192);
            btnguardar.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnguardar.Location = new Point(147, 507);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(161, 53);
            btnguardar.TabIndex = 16;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // btncalcular
            // 
            btncalcular.BackColor = Color.FromArgb(0, 192, 192);
            btncalcular.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btncalcular.Location = new Point(409, 507);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(161, 53);
            btncalcular.TabIndex = 17;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = false;
            btncalcular.Click += btncalcular_Click;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.FromArgb(0, 192, 192);
            btnsalir.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnsalir.Location = new Point(670, 507);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(161, 53);
            btnsalir.TabIndex = 18;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(941, 641);
            Controls.Add(btnsalir);
            Controls.Add(btncalcular);
            Controls.Add(btnguardar);
            Controls.Add(grbgenero);
            Controls.Add(label6);
            Controls.Add(Genero);
            Controls.Add(cbintrumento);
            Controls.Add(txtnombre);
            Controls.Add(txtclases);
            Controls.Add(txtcosto);
            Controls.Add(txtid);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Ingreso de datos";
            grbgenero.ResumeLayout(false);
            grbgenero.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtid;
        private TextBox txtcosto;
        private TextBox txtclases;
        private TextBox txtnombre;
        private ComboBox cbintrumento;
        private Label Genero;
        private Label label6;
        private RadioButton rdfemenino;
        private RadioButton rdmasculino;
        private GroupBox grbgenero;
        private Button btnguardar;
        private Button btncalcular;
        private Button btnsalir;
    }
}