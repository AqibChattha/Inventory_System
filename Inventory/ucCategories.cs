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
    public partial class ucCategories : UserControl
    {
        private static ucCategories _instance;
        public static ucCategories Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucCategories();
                }
                return _instance;
            }
        }
        public ucCategories()
        {
            InitializeComponent();
        }
    }
}
