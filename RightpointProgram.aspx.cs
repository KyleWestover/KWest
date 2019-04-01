using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RightpointProgram : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 != 0 && i % 5 != 0)
            {
                lbl100.Text += i.ToString() + "<br />"; 
            }
            else if (i % 3 == 0 && i % 5 == 0)
            {
                lbl100.Text += "rightpoint" + "<br />";
            }
            else if (i % 3 == 0)
            {
                lbl100.Text += "right" + "<br />";
            }
            else if (i % 5 == 0)
            {
                lbl100.Text += "point" + "<br />";
            }
        }
    }
}