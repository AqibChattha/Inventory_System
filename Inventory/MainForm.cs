using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            loadUcTableView();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadUcTableView()
        {
            if (!panel2.Controls.Contains(ucTableView.Instance))
            {
                panel2.Controls.Add(ucTableView.Instance);
                ucTableView.Instance.Dock = DockStyle.Fill;
                ucTableView.Instance.BringToFront();
            }
            else
            {
                ucTableView.Instance.BringToFront();
            }
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            ucTableView.Instance.loadUcItems();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ucTableView.Instance.loadUcCategories();
        }
    }
}
