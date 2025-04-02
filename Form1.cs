using System.Net.Mail;

namespace WinFormsApp1
{
    public partial class FrmFormulario : Form
    {
        public FrmFormulario()
        {
            InitializeComponent();
            errorProvider.BlinkRate = 0;
        }

        private ErrorProvider errorProvider = new ErrorProvider();

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            bool erroEncontrado = false;

            if (!ValidaNome(txtNome.Text))
            {
                errorProvider.SetError(txtNome, "Nome inválido.");
                erroEncontrado = true;
            }

            if (!ValidaEmail(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "E-mail inválido.");
                erroEncontrado = true;
            }

            if (!ValidaSenha(txtSenha.Text))
            {
                errorProvider.SetError(txtSenha, "Senha inválida (deve ter 6 caracteres).");
                erroEncontrado = true;
            }

            if (string.IsNullOrWhiteSpace(txtConfirmarSenha.Text))
            {
                errorProvider.SetError(txtConfirmarSenha, "Confirme sua senha.");
                erroEncontrado = true;
            }
            else if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                errorProvider.SetError(txtConfirmarSenha, "Senhas não coincidem.");
                erroEncontrado = true;
            }

            if (!ValidaIdade((int)UpDownIdade.Value))
            {
                errorProvider.SetError(UpDownIdade, "A idade deve estar entre 18 e 100 anos.");
                erroEncontrado = true;
            }

            if (!VerificaCheckBox())
            {
                errorProvider.SetError(chkTermos, "Você deve aceitar os termos.");
                erroEncontrado = true;
            }

            if (!ValidaCpf(txtCPF.Text))
            {
                errorProvider.SetError(txtCPF, "CPF inválido.");
                erroEncontrado = true;
            }

            if (!ValidaTelefone(txtTelefone.Text))
            {
                errorProvider.SetError(txtTelefone, "Telefone inválido.");
                erroEncontrado = true;
            }

            if (erroEncontrado)
            {
                return;
            }

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
