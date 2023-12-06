using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace cadastroFunc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //(NOME, CPF, TELEFONE, EMAIL, ENDERECO, DATA_NASCIMENTO, DATA_CONTRATACAO) values(@nome, @cpf, @telefone, @email, @endereco, @dataNascimento, @dataContratacao)";
        bd bd = new bd(); //variavel usada para consumir a classe banco criada previamente
        string sql; //será usado para usar os comandos do MySql
        MySqlCommand cmd;

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bd.abrirConn();
            sql = "update funcionario set `NOME`=@nome,`CPF`=@cpf,`TELEFONE`=@telefone,`EMAIL`=@email,`CEP`=@endereco,`DATA_NASCIMENTO`=@dataNascimento,`DATA_CONTRATACAO`=@dataContratacao WHERE ID = @id";
            cmd = new MySqlCommand(sql, bd.conn);
            cmd.Parameters.AddWithValue("@nome", tbNome.Text);
            cmd.Parameters.AddWithValue("@cpf", tbCpf.Text);
            cmd.Parameters.AddWithValue("@telefone", tbTelefone.Text);
            cmd.Parameters.AddWithValue("@email", tbEmail.Text);
            cmd.Parameters.AddWithValue("@endereco", tbEndereco.Text);
            cmd.Parameters.AddWithValue("@dataNascimento", monthCalendarNasc.TodayDate);
            cmd.Parameters.AddWithValue("@dataContratacao", monthCalendarAdmissao.TodayDate);
            cmd.Parameters.AddWithValue("@id", tbId.Text);
            cmd.ExecuteNonQuery();
        }
    }
}
