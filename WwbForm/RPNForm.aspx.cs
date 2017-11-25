using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RPNCalculator;

namespace WwbForm
{
    public partial class RPNForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) {
                RPNCal obj = new RPNCal();
                int? result = obj.GetRPN(inputRPN.Text);

                outputRPN.Text = result.ToString();
            }

        }
    }
}