using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace waConhecendoOsComponentes
{
    public partial class wfComponents1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btInserir_Click(object sender, EventArgs e)
        {
            
                ListItem item = new ListItem(txtSite.Text, txtEndereco.Text);
                lbEndereco.Items.Add(item);
                txtSite.Text = "";
                txtEndereco.Text = "";            
            
        }

        protected void btSelecionar_Click(object sender, EventArgs e)
        {
            ListItem item = dlSite.SelectedItem;
            txtSite.Text = item.Text;
            item = lbEndereco.SelectedItem;
            txtEndereco.Text = item.Text;
        }
    }
}