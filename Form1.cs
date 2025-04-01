using System.Net.Mail;

namespace WinFormsApp1
{
    public partial class FrmFormulario : Form
    {
        public FrmFormulario()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            if (!ValidaNome(txtNome.Text))
            {
                MessageBox.Show("Nome Inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidaEmail(txtEmail.Text))
            {
                MessageBox.Show("E-mail Inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidaSenha(txtSenha.Text))
            {
                MessageBox.Show("Senha Inválida (deve ter 6 caracteres).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtConfirmarSenha.Text))
            {
                MessageBox.Show("Confirme sua senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("Senhas não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidaIdade((int)UpDownIdade.Value))
            {
                MessageBox.Show("A idade deve estar entre 18 e 100 anos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!VerificaCheckBox())
            {
                MessageBox.Show("Você deve aceitar os termos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidaCpf(txtCPF.Text))
            {
                MessageBox.Show("CPF Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                
            if (!ValidaTelefone(txtTelefone.Text))
            {
                MessageBox.Show("Telefone Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                

            // Exibe mensagem de sucesso se todos os campos estiverem válidos
            MessageBox.Show("Cadastro concluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtConfirmarSenha.Clear();
            chkTermos.Checked = false;
            txtCPF.Clear();
            txtTelefone.Clear();
            UpDownIdade.Value = 18;

            txtNome.Focus();
        }

        private bool ValidaNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                return false;
            }
            return true;
        }

        private bool ValidaSenha(string senha)
        {
            if (string.IsNullOrWhiteSpace(senha) || senha.Length != 6)
            {
                return false;
            }
            return true;
        }

        private bool ValidaIdade(int idade)
        {
            if (idade < 18 || idade > 100)
            {
                return false;
            }
            else
                return true;
        }

        private bool VerificaCheckBox()
        {
            if (!chkTermos.Checked)
            {
                return false;
            }
            else
                return true;
        }

        private bool ValidaEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            try
            {
                var mail = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private bool ValidaTelefone(string telefone)
        {
            if (string.IsNullOrWhiteSpace(telefone)) return false;

            telefone = telefone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

            return telefone.All(char.IsDigit) && telefone.Length == 11;
        }

        private bool ValidaCpf(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf)) return false;

            cpf = cpf.Replace(".", "").Replace("-", "").Replace(" ", "");

            return cpf.All(char.IsDigit) && cpf.Length == 11;
        }
    }
}
