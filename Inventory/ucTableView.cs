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
    public partial class ucTableView : UserControl
    {
        private static ucTableView _instance;
        public static ucTableView Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucTableView();
                }
                return _instance;
            }
        }
        public ucTableView()
        {
            InitializeComponent();
            loadUcItems();
        }

        public void loadUcItems()
        {
            if (!panel2.Controls.Contains(ucItems.Instance))
            {
                panel2.Controls.Add(ucItems.Instance);
                ucItems.Instance.Dock = DockStyle.Fill;
                ucItems.Instance.BringToFront();
            }
            else
            {
                ucItems.Instance.BringToFront();
            }
        }

        public void loadUcCategories()
        {
            if (!panel2.Controls.Contains(ucCategories.Instance))
            {
                panel2.Controls.Add(ucCategories.Instance);
                ucCategories.Instance.Dock = DockStyle.Fill;
                ucCategories.Instance.BringToFront();
            }
            else
            {
                ucCategories.Instance.BringToFront();
            }
        }

    }
}
