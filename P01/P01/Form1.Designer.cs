namespace P01
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
            btnLimpiar = new Button();
            btnSalir = new Button();
            grpTransac = new GroupBox();
            label5 = new Label();
            txtSA = new TextBox();
            btnRealizar = new Button();
            label3 = new Label();
            txtRetiroT = new TextBox();
            txtDepT = new TextBox();
            label4 = new Label();
            txtRetiro = new TextBox();
            lblDep = new Label();
            rbtnRetiro = new RadioButton();
            txtDepC = new TextBox();
            lblRetiro = new Label();
            lblOper = new Label();
            rbtnDep = new RadioButton();
            grpDatos = new GroupBox();
            txtMonto = new TextBox();
            lblMonto = new Label();
            txtCliente = new TextBox();
            lblCliente = new Label();
            label1 = new Label();
            grpTransac.SuspendLayout();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(837, 416);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(88, 29);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(837, 364);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(88, 29);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // grpTransac
            // 
            grpTransac.BackColor = Color.FromArgb(192, 255, 255);
            grpTransac.Controls.Add(label5);
            grpTransac.Controls.Add(txtSA);
            grpTransac.Controls.Add(btnRealizar);
            grpTransac.Controls.Add(label3);
            grpTransac.Controls.Add(txtRetiroT);
            grpTransac.Controls.Add(txtDepT);
            grpTransac.Controls.Add(label4);
            grpTransac.Controls.Add(txtRetiro);
            grpTransac.Controls.Add(lblDep);
            grpTransac.Controls.Add(rbtnRetiro);
            grpTransac.Controls.Add(txtDepC);
            grpTransac.Controls.Add(lblRetiro);
            grpTransac.Controls.Add(lblOper);
            grpTransac.Controls.Add(rbtnDep);
            grpTransac.Location = new Point(258, 329);
            grpTransac.Name = "grpTransac";
            grpTransac.Size = new Size(536, 228);
            grpTransac.TabIndex = 17;
            grpTransac.TabStop = false;
            grpTransac.Text = "Transacciones: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(382, 106);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 14;
            label5.Text = "SALDO ACTUAL";
            // 
            // txtSA
            // 
            txtSA.BackColor = Color.FromArgb(192, 255, 192);
            txtSA.Location = new Point(382, 129);
            txtSA.Name = "txtSA";
            txtSA.Size = new Size(125, 27);
            txtSA.TabIndex = 13;
            // 
            // btnRealizar
            // 
            btnRealizar.Location = new Point(364, 38);
            btnRealizar.Name = "btnRealizar";
            btnRealizar.Size = new Size(143, 29);
            btnRealizar.TabIndex = 12;
            btnRealizar.Text = "Realizar Operación ";
            btnRealizar.UseVisualStyleBackColor = true;
            btnRealizar.Click += btnRealizar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(274, 87);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 11;
            label3.Text = "TOTAL";
            // 
            // txtRetiroT
            // 
            txtRetiroT.BackColor = Color.FromArgb(255, 224, 192);
            txtRetiroT.Location = new Point(249, 154);
            txtRetiroT.Name = "txtRetiroT";
            txtRetiroT.Size = new Size(93, 27);
            txtRetiroT.TabIndex = 10;
            // 
            // txtDepT
            // 
            txtDepT.BackColor = Color.FromArgb(255, 224, 192);
            txtDepT.Location = new Point(249, 110);
            txtDepT.Name = "txtDepT";
            txtDepT.Size = new Size(93, 27);
            txtDepT.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(136, 87);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 4;
            label4.Text = "CANTIDAD";
            // 
            // txtRetiro
            // 
            txtRetiro.BackColor = Color.FromArgb(255, 224, 192);
            txtRetiro.Location = new Point(136, 154);
            txtRetiro.Name = "txtRetiro";
            txtRetiro.Size = new Size(93, 27);
            txtRetiro.TabIndex = 5;
            // 
            // lblDep
            // 
            lblDep.AutoSize = true;
            lblDep.Location = new Point(37, 113);
            lblDep.Name = "lblDep";
            lblDep.Size = new Size(73, 20);
            lblDep.TabIndex = 7;
            lblDep.Text = "Depósito:";
            // 
            // rbtnRetiro
            // 
            rbtnRetiro.AutoSize = true;
            rbtnRetiro.Location = new Point(249, 40);
            rbtnRetiro.Name = "rbtnRetiro";
            rbtnRetiro.Size = new Size(70, 24);
            rbtnRetiro.TabIndex = 8;
            rbtnRetiro.TabStop = true;
            rbtnRetiro.Text = "Retiro";
            rbtnRetiro.UseVisualStyleBackColor = true;
            // 
            // txtDepC
            // 
            txtDepC.BackColor = Color.FromArgb(255, 224, 192);
            txtDepC.Location = new Point(136, 110);
            txtDepC.Name = "txtDepC";
            txtDepC.Size = new Size(93, 27);
            txtDepC.TabIndex = 4;
            // 
            // lblRetiro
            // 
            lblRetiro.AutoSize = true;
            lblRetiro.Location = new Point(39, 157);
            lblRetiro.Name = "lblRetiro";
            lblRetiro.Size = new Size(52, 20);
            lblRetiro.TabIndex = 5;
            lblRetiro.Text = "Retiro:";
            // 
            // lblOper
            // 
            lblOper.AutoSize = true;
            lblOper.Location = new Point(28, 42);
            lblOper.Name = "lblOper";
            lblOper.Size = new Size(85, 20);
            lblOper.TabIndex = 7;
            lblOper.Text = "Operación: ";
            // 
            // rbtnDep
            // 
            rbtnDep.AutoSize = true;
            rbtnDep.Location = new Point(136, 40);
            rbtnDep.Name = "rbtnDep";
            rbtnDep.Size = new Size(91, 24);
            rbtnDep.TabIndex = 7;
            rbtnDep.TabStop = true;
            rbtnDep.Text = "Depósito";
            rbtnDep.UseVisualStyleBackColor = true;
            // 
            // grpDatos
            // 
            grpDatos.BackColor = Color.FromArgb(255, 255, 192);
            grpDatos.Controls.Add(txtMonto);
            grpDatos.Controls.Add(lblMonto);
            grpDatos.Controls.Add(txtCliente);
            grpDatos.Controls.Add(lblCliente);
            grpDatos.Location = new Point(258, 134);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(357, 158);
            grpDatos.TabIndex = 16;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos: ";
            // 
            // txtMonto
            // 
            txtMonto.BackColor = Color.FromArgb(255, 224, 192);
            txtMonto.Location = new Point(106, 78);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(125, 27);
            txtMonto.TabIndex = 5;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(28, 81);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(56, 20);
            lblMonto.TabIndex = 5;
            lblMonto.Text = "Monto:";
            // 
            // txtCliente
            // 
            txtCliente.BackColor = Color.FromArgb(255, 224, 192);
            txtCliente.Location = new Point(106, 30);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(218, 27);
            txtCliente.TabIndex = 4;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(28, 33);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(58, 20);
            lblCliente.TabIndex = 4;
            lblCliente.Text = "Cliente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(310, 48);
            label1.Name = "label1";
            label1.Size = new Size(272, 32);
            label1.TabIndex = 15;
            label1.Text = "Operaciones Bancarias";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 604);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSalir);
            Controls.Add(grpTransac);
            Controls.Add(grpDatos);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            grpTransac.ResumeLayout(false);
            grpTransac.PerformLayout();
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiar;
        private Button btnSalir;
        private GroupBox grpTransac;
        private Label label5;
        private TextBox txtSA;
        private Button btnRealizar;
        private Label label3;
        private TextBox txtRetiroT;
        private TextBox txtDepT;
        private Label label4;
        private TextBox txtRetiro;
        private Label lblDep;
        private RadioButton rbtnRetiro;
        private TextBox txtDepC;
        private Label lblRetiro;
        private Label lblOper;
        private RadioButton rbtnDep;
        private GroupBox grpDatos;
        private TextBox txtMonto;
        private Label lblMonto;
        private TextBox txtCliente;
        private Label lblCliente;
        private Label label1;
    }
}