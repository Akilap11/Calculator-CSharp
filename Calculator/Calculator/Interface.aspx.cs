using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class Interface : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CalculatorWebApplication.WebService1SoapClient client = new
                CalculatorWebApplication.WebService1SoapClient();
            int result = client.addd(Convert.ToInt32(DropDownList1.SelectedItem.Value), Convert.ToInt32(DropDownList2.SelectedItem.Value));
            Label.Text = result.ToString();
        }
    }
}