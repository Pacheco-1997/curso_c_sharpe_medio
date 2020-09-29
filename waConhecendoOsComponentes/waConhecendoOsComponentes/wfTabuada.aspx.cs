using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace waConhecendoOsComponentes
{
    public partial class wfTabuada : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
            {
                for (int i = 1; i < 11; i++)
                {

                    dlNumeros.Items.Add(i.ToString());

                }
            }
         
        }

        protected void btExecutar_Click(object sender, EventArgs e)
        {
            if (dlNumeros.SelectedValue != "")
            {
           
            lbDados.Items.Clear();
            ListItem li = dlNumeros.SelectedItem;
            int n = Convert.ToInt32(li.Value);
            int result;
            for (int i = 1; i < 11; i++)
            {
                result = n * i;
                lbDados.Items.Add(n.ToString() + " x " + i.ToString() + " = " + result );
            }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Esse não item não é valido, favor selecionar um item valido')", true);
               // Response.Write("<script>alert('Data inserted successfully')</script>");
               // ACHEI ESSAS DUAS MANEIRAS DE USAR O ALERT EM ASP
            }



        }
    }
}