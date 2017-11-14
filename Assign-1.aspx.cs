using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SodingTest_1
{
    public partial class Assign_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            sum();
        }
        public void sum()
        {
            int i = 1, j = 1, sum = 0;
            while (i < 4000000)
            {
                i = i + j;
                j = i - j;
                if (i % 2 == 0)
                    sum += i;
            }
            Response.Write(sum);
       }
    }
}