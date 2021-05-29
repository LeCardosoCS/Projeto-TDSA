using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TDSA_v2._0
{
    public partial class Cliente : System.Web.UI.Page
    {

        ClienteBLL objCliente = new ClienteBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarGridView();

        }

        private void CarregarGridView()
        {
            gridClientes.DataSource = objCliente.RetListaClientes();
            gridClientes.DataBind();
        }

        protected void Cadastrar_Click(object sender, EventArgs e)
        {
            objCliente.Nome = TextNome.Text;
            objCliente.Data_Nascimento = Convert.ToDateTime(TextNasc.Text);

            if (String.IsNullOrEmpty(intID.Text))
            {
                objCliente.CadastrarCliente();
                CarregarGridView();
            }
            else
            {
                objCliente.AlterarCliente(intID.Text);
                CarregarGridView();
            }
        }

        protected void Carregar_Click(object sender, EventArgs e)
        {
            DataTable data = objCliente.CarregarClientePorID(intID.Text);
            intID.Text = data.Rows[0]["CLI_ID"].ToString();
            TextNome.Text = data.Rows[0]["CLI_NOME"].ToString();
            TextNasc.Text = data.Rows[0]["CLI_DATANASCIMENTO"].ToString();
        }

        protected void Excluir_Click(object sender, EventArgs e)
        {
            objCliente.ExcluirCliente(intID.Text);
            CarregarGridView();
        }
    }
}