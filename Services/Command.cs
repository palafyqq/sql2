using ksyusha.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ksyusha
{
    internal class Command : DatabaseService
    {
        private SqlDataAdapter sqlDataAdapter = null;
        public DataTable MainTable = new DataTable();
        private DataSet DataSet = null;

        private List<ParametersSql> parametr = new List<ParametersSql>();
        public void LoadData(string _command)
        {
            OpenConnection();

            try
            {
                SqlCommand newcommand = new SqlCommand(_command, GetConnection());

                DataSet = new DataSet();
                sqlDataAdapter = new SqlDataAdapter();

                sqlDataAdapter.SelectCommand = newcommand;
                sqlDataAdapter.Fill(DataSet, "Load");

                MainTable = DataSet.Tables["Load"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SendCommand(string command)
        {
            OpenConnection();
            try
            {
                SqlCommand Scommand = new SqlCommand(command, GetConnection());
                foreach (ParametersSql parS in parametr)
                { Scommand.Parameters.Add(parS.Title, parS.TypeSql).Value = parS.Value; }
                Scommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CloseConnection();
            parametr.Clear();
        }
        public void AddParameter(string _title, SqlDbType _type, string _value)
        {
            ParametersSql parameterSql = new ParametersSql();
            parameterSql.Title = _title;
            parameterSql.TypeSql = _type;
            parameterSql.Value = _value;
            parametr.Add(parameterSql);

        }
        public class ParametersSql
        {
            public string Title;
            public SqlDbType TypeSql;
            public string Value;
        }


    }
}