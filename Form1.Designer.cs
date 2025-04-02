namespace WinFormsApp1
{
    partial class FrmFormulario
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
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            txtConfirmarSenha = new TextBox();
            lblNome = new Label();
            lblEmail = new Label();
            txtIdade = new Label();
            lblConfirmarSenha = new Label();
            UpDownIdade = new NumericUpDown();
            lblSenha = new Label();
            lblTitulo = new Label();
            btnLimpar = new Button();
            btnEnviar = new Button();
            chkTermos = new CheckBox();
            txtCPF = new MaskedTextBox();
            txtTelefone = new MaskedTextBox();
            lblCpf = new Label();
            lblTelefone = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)UpDownIdade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(238, 104);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Informe seu nome";
            txtNome.Size = new Size(258, 23);
            txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(238, 155);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Informe seu email";
            txtEmail.Size = new Size(258, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(238, 251);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Insira sua senha";
            txtSenha.Size = new Size(120, 23);
            txtSenha.TabIndex = 3;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(378, 251);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '*';
            txtConfirmarSenha.PlaceholderText = "Repita";
            txtConfirmarSenha.Size = new Size(118, 23);
            txtConfirmarSenha.TabIndex = 4;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(241, 85);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 6;
            lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(242, 136);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // txtIdade
            // 
            txtIdade.AutoSize = true;
            txtIdade.Location = new Point(241, 284);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(36, 15);
            txtIdade.TabIndex = 9;
            txtIdade.Text = "Idade";
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.Location = new Point(369, 233);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(95, 15);
            lblConfirmarSenha.TabIndex = 10;
            lblConfirmarSenha.Text = "Confirmar senha";
            // 
            // UpDownIdade
            // 
            UpDownIdade.Location = new Point(238, 302);
            UpDownIdade.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            UpDownIdade.Name = "UpDownIdade";
            UpDownIdade.Size = new Size(50, 23);
            UpDownIdade.TabIndex = 11;
            UpDownIdade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(238, 233);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 12;
            lblSenha.Text = "Senha";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(262, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(222, 40);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "Formulário";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(326, 358);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 14;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(421, 358);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 15;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // chkTermos
            // 
            chkTermos.AutoSize = true;
            chkTermos.Location = new Point(313, 295);
            chkTermos.Name = "chkTermos";
            chkTermos.Size = new Size(183, 34);
            chkTermos.TabIndex = 16;
            chkTermos.Text = "Eu aceito termos e condições \r\nde uso";
            chkTermos.UseVisualStyleBackColor = true;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(241, 204);
            txtCPF.Mask = "000,000,000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(117, 23);
            txtCPF.TabIndex = 17;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(378, 204);
            txtTelefone.Mask = "(00)00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(118, 23);
            txtTelefone.TabIndex = 18;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(241, 186);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
            lblCpf.TabIndex = 19;
            lblCpf.Text = "CPF";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(378, 186);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 20;
            lblTelefone.Text = "Telefone";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.alien;
            pictureBox1.Location = new Point(12, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 357);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.alien;
            pictureBox2.Location = new Point(526, 49);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(202, 357);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // FrmFormulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(740, 418);
            Controls.Add(lblTitulo);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblTelefone);
            Controls.Add(lblCpf);
            Controls.Add(txtTelefone);
            Controls.Add(txtCPF);
            Controls.Add(chkTermos);
            Controls.Add(btnEnviar);
            Controls.Add(btnLimpar);
            Controls.Add(lblSenha);
            Controls.Add(UpDownIdade);
            Controls.Add(lblConfirmarSenha);
            Controls.Add(txtIdade);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Name = "FrmFormulario";
            Text = "Formulário com validação";
            ((System.ComponentModel.ISupportInitialize)UpDownIdade).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox textBox2;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private TextBox txtConfirmarSenha;
        private CheckBox checkBox1;
        private Label lblNome;
        private Label lblEmail;
        private Label label3;
        private Label txtIdade;
        private Label lblConfirmarSenha;
        private NumericUpDown UpDownIdade;
        private Label lblSenha;
        private Label lblTitulo;
        private Button btnLimpar;
        private Button btnEnviar;
        private CheckBox chkTermos;
        private MaskedTextBox txtCPF;
        private MaskedTextBox txtTelefone;
        private Label lblCpf;
        private Label lblTelefone;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
