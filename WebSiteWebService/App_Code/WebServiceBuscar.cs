using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;

/// <summary>
/// Summary description for WebServiceBuscar
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebServiceBuscar : System.Web.Services.WebService
{

    public WebServiceBuscar()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }

    [WebMethod]
    public System.Data.DataSet listdoPersona()
    {
        SqlConnection coon = new SqlConnection();
        coon.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=proyectonet;Persist Security Info=True;User ID=mchoc;Password=mchoc";
        SqlDataAdapter da = new SqlDataAdapter("select * from persona.persona", coon);
        System.Data.DataSet ds = new System.Data.DataSet();
        da.Fill(ds);
        return ds;
    }

    [WebMethod]
    public System.Data.DataSet buscarPersonaId(String id)
    {
        SqlConnection coon = new SqlConnection();
        coon.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=proyectonet;Persist Security Info=True;User ID=mchoc;Password=mchoc";
        SqlDataAdapter da = new SqlDataAdapter("select * from persona.persona where id ='"+id+"'", coon);
        System.Data.DataSet ds = new System.Data.DataSet();
        da.Fill(ds);
        return ds;
    }

}
