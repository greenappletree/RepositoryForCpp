using System;
using System.Configuration;
using System.Data;
//using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
//using System.Xml.Linq;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string selectFlag = selectOper.Value;
        localhost.Service web = new localhost.Service();
        if (selectFlag.Equals("+"))
        {
            Result.Text = (web.addition(double.Parse(Num1.Text), double.Parse(Num2.Text))).ToString();
        }
        else if (selectFlag.Equals("-"))
        {
            Result.Text = (web.subtract(double.Parse(Num1.Text), double.Parse(Num2.Text))).ToString();
        }
        else if (selectFlag.Equals("*"))
        {
            Result.Text = (web.multiplication(double.Parse(Num1.Text), double.Parse(Num2.Text))).ToString();
        }
        else if (selectFlag.Equals("/"))
        {
            Result.Text = (web.division(double.Parse(Num1.Text), double.Parse(Num2.Text))).ToString();
        }
    }
}