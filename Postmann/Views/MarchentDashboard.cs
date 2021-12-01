using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Postmann.marchent;

namespace Postmann
{
    public partial class MarchentDashboard : Form
    {
        private Form activeForm = null;
        public MarchentDashboard()
        {
            InitializeComponent();
            hideSubMenu();
            openChildForm(new StatusAdminDashboard());
        }

       private void hideSubMenu()
        {
            accountSubmenu.Visible = false;
            dashboardSubMenu.Visible = false;
            parcelSubMenu.Visible = false;
        }


        private void openSubMenu(Panel panel)
        {
            if (panel.Visible == false)
            {
                hideSubMenu();
                panel.Visible = true;
            }
            else panel.Visible = true;
        }

        private void MarchentDashboard_Load(object sender, EventArgs e)
        {

        }

        private void openChildForm ( Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            marchentPanelContainer.Controls.Add(childForm);
            marchentPanelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void dashboardPanelButton_Click(object sender, EventArgs e)
        {
            openSubMenu(dashboardSubMenu);
        }

        private void parcelPanelButton_Click(object sender, EventArgs e)
        {
            openSubMenu(parcelSubMenu);
        }

        private void accountPanelButtn_Click(object sender, EventArgs e)
        {
            openSubMenu(accountSubmenu);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new BalanceAdminDashboard());
        }

        private void marchentPanelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new addParcelMarchent());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            openChildForm(new Checkbalance());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new StatusAdminDashboard());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openChildForm(new withdraw());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openChildForm(new AllWithdrawlMarchent());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openChildForm(new LoginForm());
        }
    }
}
