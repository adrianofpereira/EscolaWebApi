using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace EscolaWeb
{
    public partial class Curso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                this.ListaCursos();
            }
        }

        private void ListaCursos()
        {
            string strconexao = "server=127.0.0.1; port=3307; user id =root; persistsecurityinfo=True; database=escola; password=Mysql1523#";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(strconexao);
            conn.Open();
            MySql.Data.MySqlClient.MySqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * FROM curso";
            DataSet ds = new DataSet();
            try 
            {
                MySql.Data.MySqlClient.MySqlDataAdapter da = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (Exception)
            {
                ds = null;
            } 
            //Preencgimento Controle de tela
            this.grdCursos.DataSource = ds;
            this.grdCursos.DataBind();

        }

    }
}