namespace PjtAtivdadedeLogica
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
            lblNota1 = new Label();
            txtNota1 = new TextBox();
            lblNota2 = new Label();
            lblNota3 = new Label();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            lblFaltas = new Label();
            BtnVerificacao = new Button();
            txtFaltas = new TextBox();
            lblMensagem = new Label();
            SuspendLayout();
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.BackColor = SystemColors.ButtonFace;
            lblNota1.BorderStyle = BorderStyle.Fixed3D;
            lblNota1.Font = new Font("Baskerville Old Face", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblNota1.ForeColor = Color.Black;
            lblNota1.Location = new Point(46, 67);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(225, 25);
            lblNota1.TabIndex = 0;
            lblNota1.Text = "Nota da primeira prova:";
            // 
            // txtNota1
            // 
            txtNota1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtNota1.Location = new Point(338, 67);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(266, 32);
            txtNota1.TabIndex = 1;
            txtNota1.TextChanged += textBox1_TextChanged;
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.BackColor = SystemColors.ButtonFace;
            lblNota2.BorderStyle = BorderStyle.Fixed3D;
            lblNota2.Font = new Font("Baskerville Old Face", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblNota2.ForeColor = Color.Black;
            lblNota2.Location = new Point(46, 144);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(219, 25);
            lblNota2.TabIndex = 2;
            lblNota2.Text = "Nota da segunda prova:";
            // 
            // lblNota3
            // 
            lblNota3.AutoSize = true;
            lblNota3.BackColor = SystemColors.ButtonFace;
            lblNota3.BorderStyle = BorderStyle.Fixed3D;
            lblNota3.Font = new Font("Baskerville Old Face", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblNota3.ForeColor = Color.Black;
            lblNota3.Location = new Point(46, 221);
            lblNota3.Name = "lblNota3";
            lblNota3.Size = new Size(216, 25);
            lblNota3.TabIndex = 3;
            lblNota3.Text = "Nota da terceira prova:";
            lblNota3.Click += label2_Click;
            // 
            // txtNota2
            // 
            txtNota2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtNota2.Location = new Point(338, 144);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(266, 32);
            txtNota2.TabIndex = 4;
            // 
            // txtNota3
            // 
            txtNota3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtNota3.Location = new Point(338, 221);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(266, 32);
            txtNota3.TabIndex = 5;
            txtNota3.TextChanged += textBox2_TextChanged;
            // 
            // lblFaltas
            // 
            lblFaltas.AutoSize = true;
            lblFaltas.BackColor = SystemColors.ButtonFace;
            lblFaltas.BorderStyle = BorderStyle.Fixed3D;
            lblFaltas.Font = new Font("Baskerville Old Face", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblFaltas.ForeColor = Color.Black;
            lblFaltas.Location = new Point(46, 301);
            lblFaltas.Name = "lblFaltas";
            lblFaltas.Size = new Size(64, 25);
            lblFaltas.TabIndex = 6;
            lblFaltas.Text = "Faltas";
            // 
            // BtnVerificacao
            // 
            BtnVerificacao.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnVerificacao.Location = new Point(305, 390);
            BtnVerificacao.Name = "BtnVerificacao";
            BtnVerificacao.Size = new Size(299, 23);
            BtnVerificacao.TabIndex = 7;
            BtnVerificacao.Text = "Verificar Situação do Aluno";
            BtnVerificacao.UseVisualStyleBackColor = true;
            BtnVerificacao.Click += button1_Click;
            // 
            // txtFaltas
            // 
            txtFaltas.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtFaltas.Location = new Point(338, 294);
            txtFaltas.Name = "txtFaltas";
            txtFaltas.Size = new Size(266, 32);
            txtFaltas.TabIndex = 8;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.BackColor = SystemColors.ButtonFace;
            lblMensagem.BorderStyle = BorderStyle.Fixed3D;
            lblMensagem.Font = new Font("Leelawadee", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblMensagem.ForeColor = Color.Black;
            lblMensagem.Location = new Point(46, 367);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(2, 26);
            lblMensagem.TabIndex = 9;
            lblMensagem.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMensagem);
            Controls.Add(txtFaltas);
            Controls.Add(BtnVerificacao);
            Controls.Add(lblFaltas);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(lblNota3);
            Controls.Add(lblNota2);
            Controls.Add(txtNota1);
            Controls.Add(lblNota1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNota1;
        private TextBox txtNota1;
        private Label lblNota2;
        private Label lblNota3;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private Label lblFaltas;
        private Button BtnVerificacao;
        private TextBox txtFaltas;
        private Label lblMensagem;
    }
}