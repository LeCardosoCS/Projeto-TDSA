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
        public string Data_Nascimento { get; set; }
        public string Situacao { get; set; }
        public string ID { get; set; }


        DAL objDAL = new DAL();

        public DataTable RetListaClientes()
        {
            return objDAL.RetDataTable("select * from cliente");
        }

        public DataTable CarregarCliente(string ID)
        {
            string sql = String.Format("SELECT * FROM cliente WHERE CLI_ID = '{0}'", int.Parse(ID));
            
            return objDAL.RetDataTable(sql);            
        }


        public void CadastrarCliente()
        {
            bool status = (Situacao == "Ativo") ? true : false;
            string sql = "INSERT INTO cliente(CLI_NOME, CLI_DATANASCIMENTO, CLI_ATIVO) " +
                         "VALUES('{0}', '{1}', '{2}')";
            sql = String.Format(sql, Nome, DateTime.Parse(Data_Nascimento), status);
            objDAL.ExecutarComandoSQL(sql);
        }

        public void AlterarCliente(string ID)
        {
            bool status = (Situacao == "Ativo") ? true : false;
            string sql = "UPDATE cliente SET CLI_NOME='{0}', CLI_DATANASCIMENTO='{1}', CLI_ATIVO='{2}' WHERE CLI_ID='{3}'";
            sql = String.Format(sql, Nome, DateTime.Parse(Data_Nascimento), status, int.Parse(ID));
            objDAL.ExecutarComandoSQL(sql);
        }

        public void ExcluirCliente(string ID)
        {
            string sql = "DELETE FROM cliente WHERE CLI_ID=" + int.Parse(ID);
            objDAL.ExecutarComandoSQL(sql);
        }
                
    }

    




}