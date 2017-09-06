using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        e.Cancel = true;  
        //pega a chave para excluir no evento YesChoosed do MessageBox
        Session["ID"] = e.Keys[0];
        MessageBox1.ShowConfirmation("Tem certeza que deseja excluir: " + 
            GridView1.Rows[e.RowIndex].Cells[2].Text, "Grid", true, false);
    }
    protected void MessageBox1_YesChoosed(object sender, string Key)
    {
        if (Key == "Grid")
        {
            //exclusão do registro
            MessageBox1.ShowMessage(Session["ID"].ToString());
        }
    }
}
