using System.Windows.Forms;


namespace Setup
{
    public class Geral
    {
        public static bool Resposta;

        /// <summary>
        /// Função para mostrar mensagens de erro na tela
        /// para usar escreva Geral.Erro e entre parentsese passe a mensagem
        /// </summary>
        /// <param name="Msg">Aqui vai o texto que será mostrado na mensagem</param>
        public static void Erro(string Msg)
        {
            //Na linha abaixo serve para abrir o formulário
            Formularios.frmErro erro = new Formularios.frmErro();
            erro.lblMensagem.Text = Msg;
            erro.ShowDialog();
        }

        public static void OK(string Msg)
        {
            Formularios.frmOK ok = new Formularios.frmOK();
            ok.lblMensagem.Text = Msg;
            ok.ShowDialog();
        }

        public static void Pergunta(string Msg)
        {
            Resposta = false;

            Formularios.frmPergunta pergunta = new Formularios.frmPergunta();
            pergunta.lblMensagem.Text = Msg;
            pergunta.ShowDialog();
        }

        public static bool ValidaCampos(Panel Grupo, ErrorProvider erro)
        {
            erro.Clear();

            foreach (Control item in Grupo.Controls)
            {
                if(item.Tag!=null)
                {
                    if (item.Text.Trim() == "")
                    {
                        Erro("O campo " + item.Tag.ToString() + " é obrigatório!");
                        item.Focus();
                        erro.SetError(item, "Obrigatório!");
                        return true;
                    }

                    //Validar tamanho do CPF
                    if(item.Tag.ToString().ToUpper().Contains("CPF") && item.Text.Length != 14)
                    {
                        Erro("CPF incompleto!");
                        item.Focus();
                        erro.SetError(item, "CPF deve ter 11 digitos!");
                        return true;
                    }

                    //Validar tamanho do CNPJ
                    if (item.Tag.ToString().ToUpper().Contains("CNPJ") && item.Text.Length != 18)
                    {
                        Erro("CNPJ incompleto!");
                        item.Focus();
                        erro.SetError(item, "CNPJ deve ter 14 digitos!");
                        return true;
                    }

                    //Validar tamanho do CEP
                    if (item.Tag.ToString().ToUpper().Contains("CEP") && item.Text.Length != 9)
                    {
                        Erro("CEP incompleto!");
                        item.Focus();
                        erro.SetError(item, "CEP deve ter 8 digitos!");
                        return true;
                    }

                    //Validar tamanho do telefone
                    if (item.Tag.ToString().ToUpper().Contains("TELEFONE") && item.Text.Length != 14)
                    {
                        Erro("Telefone incompleto!");
                        item.Focus();
                        erro.SetError(item, "Telefone deve ter 10 digitos!");
                        return true;
                    }

                    //Validar tamanho do CELULAR
                    if (item.Tag.ToString().ToUpper().Contains("CELULAR") && item.Text.Length != 15)
                    {
                        Erro("Celular incompleto!");
                        item.Focus();
                        erro.SetError(item, "Celular deve ter 11 digitos!");
                        return true;
                    }
                }
            }

            return false;
        }

    }
}
