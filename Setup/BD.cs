using FirebirdSql.Data.FirebirdClient;
using System;
using System.Data;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Setup
{
    public class BD
    {
        public static string UsuarioLogado;
        public static int tentativaLogin;
        public static string UsuarioAdmin;
        public static string funcao;
        public static string UsuarioId;

        public static bool AcessoLiberado(string func)
        {
            funcao = func;
            //if (UsuarioAdmin == "N")
            //{
            UsuarioAdmin = "N";
            Formularios.frmLiberaAcesso frm = new Formularios.frmLiberaAcesso();
            frm.ShowDialog();

            if (UsuarioAdmin == "N")
            {
                if (tentativaLogin == 3)
                {
                    Geral.Erro("O sistema será fechado!");
                    Application.Exit();
                }
                return false;
            }
            else
            {
                UsuarioAdmin = "N";
                tentativaLogin = 0;
                return true;
            }
            //}
            //else
            //return true;
        }

        private static FbConnection Conectar()
        {
            ConfigurationManager.RefreshSection("appSettings");

            string Caminho = ConfigurationManager.AppSettings["Banco"].ToString();
            string Servidor = ConfigurationManager.AppSettings["Servidor"].ToString();
            string Porta = ConfigurationManager.AppSettings["Porta"].ToString();
            string Usuario = "SYSDBA";
            string Senha = "masterkey";

            return new FbConnection("User=" + Usuario + ";Password=" + Senha + ";Database=" + Caminho + ";DataSource=" + Servidor + ";Port=" + Porta);
        }

        public static void TestarConexao()
        {
            using (FbConnection ConexaoFB = Conectar())
            {
                try
                {
                    ConexaoFB.Open();
                }
                catch (FbException ex)
                {
                    throw new Exception(ex.ToString());
                }
                finally
                {
                    ConexaoFB.Dispose();
                }
            }
        }

        public static int ExecutarSQL(string SQL)
        {
            using (FbConnection ConexaoFB = Conectar())
            {
                try
                {
                    ConexaoFB.Open();
                    FbCommand cmd = new FbCommand(SQL, ConexaoFB);
                    return cmd.ExecuteNonQuery();
                }
                
                catch (FbException ex)
                {
                    throw new Exception(ex.ToString());
                }
                finally
                {
                    ConexaoFB.Dispose();
                }
            }
        }

        public static int SalvarImagem(string Tabela, string Campo, string id, byte[] foto)
        {
            using (FbConnection ConexaoFB = Conectar())
            {
                try
                {
                    string sql = "UPDATE " + Tabela + " SET " + Campo + " = @foto WHERE " + Tabela + "_ID = " + id;

                    ConexaoFB.Open();
                    FbCommand cmd = new FbCommand(sql, ConexaoFB);
                    cmd.Parameters.Add("@foto", FbDbType.Binary).Value = foto;
                    return cmd.ExecuteNonQuery();
                }
                catch (FbException ex)
                {
                    throw new Exception(ex.ToString());
                }
                finally
                {
                    ConexaoFB.Dispose();
                }
            }
        }

        public static string CvData(string data)
        {
            if (data == "")
                return "null";
            else
            {
                data = data.Replace("/", ".").Replace("00:00:00", "").Trim();
                return data;
            }
        }

        public static string cvNum(string num)
        {
            if (num == "")
                return "0";
            else
            {
                num = num.Replace("R", "").Replace("$", "");
                num = num.Trim();
                num = num.Replace(".", "");
                num = num.Replace(",", ".");
                return num;
            }
        }

        private static string Insert(string Tabela, string[] Campos, string[] Valores)
        {
            string sql = "insert into " + Tabela + "(";

            foreach (string item in Campos)
            {
                sql += item + ", ";
            }

            sql += ")";
            sql = sql.Replace(", )", ")");

            sql += " values(";

            foreach (string item in Valores)
            {
                if (item == "null")
                    sql += "null, ";
                else
                    sql += "'" + item.Replace("'", "''") + "', ";
            }

            sql += ")";
            sql = sql.Replace(", )", ")");

            return sql;
        }

        private static string Update(string Tabela, string[] Campos, string[] Valores, string id)
        {
            string sql = "update " + Tabela + " SET ";

            int total = Campos.Length;

            for (int i = 0; i < total; i++)
            {
                if (Valores[i] == "null")
                    sql += Campos[i] + " = null, ";
                else
                    sql += Campos[i] + " = '" + Valores[i].Replace("'", "''") + "', ";
            }

            sql += "WHERE";
            sql = sql.Replace(", WHERE", " WHERE ");

            sql += Tabela + "_id = " + id;

            return sql;
        }

        public static void Salvar(string Tabela, string[] Campos, string[] Valores, string id = "")
        {
            if (id == "")
                ExecutarSQL(Insert(Tabela, Campos, Valores));
            else
                ExecutarSQL(Update(Tabela, Campos, Valores, id));
        }

        public static string ExecutarProcedure(string nome, string[] Valores, string Mensagem = "")
        {
            string sql = "SELECT ID FROM " + nome + "(";

            int i = 0;

            foreach (string item in Valores)
            {
                //Tratamento para o paramêtro ID
                if (i == 0)
                {
                    i = 1;
                    if (item == "")
                        sql += "null, ";
                    else
                        sql += item + ", ";
                }
                else
                {
                    if (item == "null")
                        sql += "null, ";
                    else
                        sql += "'" + item.Replace("'", "''") + "', ";
                }

            }

            sql += ")";
            sql = sql.Replace(", )", ")");

            //aqui é o ponto onde o sql será construido
            //assims endo dá para copiar ele por aqui
            //vou apertar F5 para rodar até esse ponto
            //prtonto agora basta deixa o mouse emcima da variavel sql
            //copiar seu valor

            string id = Buscar(sql).Rows[0][0].ToString();

            if (Convert.ToInt32(id) > 0 && Mensagem != "")
            {
                if (Valores[0] == "")
                    Geral.OK(Mensagem + " Salvo com Sucesso!");
                else
                    Geral.OK(Mensagem + " Alterado com Sucesso!");
            }

            return id;
        }

        public static bool Excluir(string Tabela, string id)
        {
            Geral.Pergunta("Deseja realmente excluir esse registro?");

            if (!Geral.Resposta)
                return false;

            string sql = "delete from " + Tabela;
            sql += " where " + Tabela + "_id = " + id;
            ExecutarSQL(sql);

            return true;
        }

        public static void Ativar(string Tabela, string id, string status)
        {
            Geral.Pergunta("Deseja alterar o status desse registro?");

            if (!Geral.Resposta)
                return;

            string sql = "update " + Tabela;
            sql += " SET ativo = '" + status;
            sql += "' where " + Tabela + "_id = " + id;

            ExecutarSQL(sql);
        }

        public static DataTable Buscar(string sql)
        {
            using (FbConnection Conexao = Conectar())
            {
                try
                {
                    DataTable dt = new DataTable();
                    Conexao.Open();
                    FbCommand cmd = new FbCommand(sql, Conexao);
                    FbDataAdapter da = new FbDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch (FbException ex)
                {
                    throw new Exception(ex.ToString());
                }
                finally
                {
                    Conexao.Dispose();
                }
            }
        }

        public static string Criptografar(string senha)
        {
            MD5 md5Hash = MD5.Create();

            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        public static void EmailAdmin(string Login, string Senha, string acao)
        {
            using (SmtpClient s = new SmtpClient())
            {
                s.Host = "smtp.gmail.com";
                s.Port = 587;
                s.EnableSsl = true;
                s.UseDefaultCredentials = false;
                s.Credentials = new NetworkCredential("edianga@gmail.com", "romanateamo010");

                using (MailMessage m = new MailMessage())
                {
                    m.From = new MailAddress("edsonanga@hotmail.com");
                    m.To.Add(new MailAddress("edsonanga@hotmail.com"));
                    m.Subject = "Tentativa de " + acao + " Nº " + tentativaLogin;
                    m.IsBodyHtml = true;
                    m.Body = "<h1>Informações!</h1><p><strong>Login: </strong>" + Login +
                        "</p><p><strong>Senha: </strong>" + Senha +
                        "</p><p><strong>Computador de Acesso: </strong>" + Environment.MachineName +
                        "</p><p><strong>Função Solicitada: </strong>" + funcao +
                        "</p><strong>Data e Hora: </strong>" + DateTime.Now + "</p>";

                    s.Send(m);
                }

                string[] c = new string[7];
                string[] v = new string[7];

                c[0] = "COMPUTADOR";
                v[0] = Environment.MachineName;

                c[1] = "USUARIO_ID";
                v[1] = UsuarioId;

                c[2] = "LOGIN";
                v[2] = Login;

                c[3] = "SENHA";
                v[3] = Senha;

                c[4] = "ACAO";
                v[4] = acao;

                c[5] = "FUNCAO";
                v[5] = funcao;

                c[6] = "TENTATIVA";
                v[6] = tentativaLogin.ToString();

                Salvar("LOG_ACESSO", c, v);
            }
        }
    }
}
