using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;



public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ServicePersona.WebServiceBuscarSoapClient ws = new ServicePersona.WebServiceBuscarSoapClient();
        DataSet ds = ws.listdoPersona();
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ServicePersona.WebServiceBuscarSoapClient ws = new ServicePersona.WebServiceBuscarSoapClient();
        DataSet ds = ws.buscarPersonaId(TextBox1.Text);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }
}