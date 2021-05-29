using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace TDSA_v2._0
{
    public class ClienteBLL
    {
        public string Nome { get; set; }
        public DateTime Data_Nascimento { get; set; }
              
        DAL objDAL = new DAL();

        public DataTable RetListaClientes()
        {
            return objDAL.RetDataTable("select * from cliente");
        }

        public DataTable CarregarClientePorID(string ID)
        {
            return objDAL.RetDataTable("select * from cliente where CLI_ID=" + int.Parse(ID));
        }

        public void CadastrarCliente()
        {
            string sql = "INSERT INTO cliente(CLI_NOME, CLI_DATANASCIMENTO) " +
                         "VALUES('{0}','{1}')";
            sql = String.Format(sql, Nome, Data_Nascimento);
            objDAL.ExecutarComandoSQL(sql);
        }

        public void AlterarCliente(string ID)
        {
            string sql = "UPDATE cliente SET CLI_NOME='{0}', CLI_DATANASCIMENTO='{1}' WHERE CLI_ID='{2}'";
            sql = String.Format(sql, Nome, Data_Nascimento, int.Parse(ID));
            objDAL.ExecutarComandoSQL(sql);
        }

        public void ExcluirCliente(string ID)
        {
            string sql = "DELETE FROM cliente WHERE CLI_ID=" + int.Parse(ID);
            objDAL.ExecutarComandoSQL(sql);
        }
                
    }

    




}