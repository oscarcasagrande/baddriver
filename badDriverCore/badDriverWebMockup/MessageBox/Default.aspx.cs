using System;
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

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        MessageBox1.ShowMessage("Exibe uma mensagem");
    }
    
    protected void Button2_Click(object sender, EventArgs e)
    {
        MessageBox1.ShowConfirmation("Condição: Ok ou Cancel", "Confirm", true, false);
    }
    
    protected void MessageBox1_YesChoosed(object sender, string Key)
    {
        if (Key == "Confirm")
        {
            MessageBox1.ShowMessage("Clicou no botão OK");
        }
    }
}
