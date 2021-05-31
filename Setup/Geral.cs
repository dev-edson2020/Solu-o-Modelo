using Microsoft.Reporting.WinForms;
using System;
using System.IO;
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
            //Formularios.frmModal modal = new Formularios.frmModal();
            //modal.Show();

            //Na linha abaixo serve para abrir o formulário
            Formularios.frmErro erro = new Formularios.frmErro();
            erro.lblMensagem.Text = Msg;
            erro.Show();

            //modal.Dispose();
        }

        public static void OK(string Msg)
        {
            //Formularios.frmModal modal = new Formularios.frmModal();
            //modal.Show();

            Formularios.frmOK ok = new Formularios.frmOK();
            ok.lblMensagem.Text = Msg;
            ok.ShowDialog();

            //modal.Dispose();
        }

        public static void Pergunta(string Msg)
        {
            Resposta = false;

            //Formularios.frmModal modal = new Formularios.frmModal();
            //modal.Show();

            Formularios.frmPergunta pergunta = new Formularios.frmPergunta();
            pergunta.lblMensagem.Text = Msg;
            pergunta.ShowDialog();

            //modal.Dispose();
        }

        public static bool ValidaCampos(Control Grupo, ErrorProvider erro)
        {
            erro.Clear();

            foreach (Control item in Grupo.Controls)
            {
                if(item.Tag!=null && item.Tag.ToString() != "" && item.Text.Trim()=="")
                {
                    Erro("O campo " + item.Tag.ToString() + " é obrigatório!");
                    item.Focus();
                    erro.SetError(item, "Obrigatório!");
                    return true;
                }
            }

            return false;
        }


        public static void ImprimirPDF(ReportViewer report, string nomeArquivo)
        {
            report.Refresh();
            report.RefreshReport();

            try
            {
                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string filenameExtension;

                byte[] bytes = report.LocalReport.Render(
                "PDF", null, out mimeType, out encoding, out filenameExtension,
                out streamids, out warnings);
                using (FileStream fs = new FileStream(nomeArquivo + ".pdf ", FileMode.Create))
                {
                    fs.Write(bytes, 0, bytes.Length);
                }

                System.Diagnostics.Process.Start(nomeArquivo + ".pdf");
            }
            catch (Exception ex)
            {
                Erro("Erro ao tentar abrir o arquivo!");
                MessageBox.Show(ex.Message);
            }
        }


        public static void ImprimirExcel(ReportViewer report, string nomeArquivo)
        {
            report.Refresh();
            report.RefreshReport();

            try
            {
                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string filenameExtension;

                byte[] bytes = report.LocalReport.Render(
                "Excel", null, out mimeType, out encoding, out filenameExtension,
                out streamids, out warnings);
                using (FileStream fs = new FileStream(nomeArquivo + ".xls", FileMode.Create))
                {
                    fs.Write(bytes, 0, bytes.Length);
                }

                System.Diagnostics.Process.Start(nomeArquivo + ".xls");
            }
            catch (Exception ex)
            {
                Erro("Erro ao tentar abrir o arquivo!");
                Erro(ex.Message);
            }
        }

        public static void LarguraColunas(DataGridView Lista)
        {
            string texto = "";

            foreach (DataGridViewColumn coluna in Lista.Columns)
            {
                texto += coluna.HeaderText + ": " + coluna.Width + "\r\n";
            }
            MessageBox.Show(texto);
        }


        public static double CvDbl(string vValor)
        {
            if (vValor.Trim() == "")
                return 0;
            else
                return Convert.ToDouble(vValor.Replace("R", "").Replace("$", "").Trim());
        }

        public static void ImprimirPDF_2(ReportViewer report, string nomeArquivo, string  Pasta)
        {
            if(!Directory.Exists(Pasta))
            {
                Directory.CreateDirectory(Pasta);
            }

            nomeArquivo = Pasta + "\\" + nomeArquivo;

            report.Refresh();
            report.RefreshReport();

            try
            {
                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string filenameExtension;

                byte[] bytes = report.LocalReport.Render(
                "PDF", null, out mimeType, out encoding, out filenameExtension,
                out streamids, out warnings);
                using (FileStream fs = new FileStream(nomeArquivo + ".pdf", FileMode.Create))
                {
                    fs.Write(bytes, 0, bytes.Length);
                }

                System.Diagnostics.Process.Start(nomeArquivo + ".pdf");
            }
            catch (Exception ex)
            {
                Erro("Erro ao tentar abrir o arquivo!");
                MessageBox.Show(ex.Message);
            }
        }

        public static void ChamaModal(bool Visivel = true)
        {
            if (Visivel == true)
            {
                Formularios.frmModal modal = new Formularios.frmModal();
                modal.Show();
            }           
        }
    }
}
