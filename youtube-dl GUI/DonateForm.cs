using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAYG
{
    public partial class DonateForm : Form
    {
        public DonateForm()
        {
            InitializeComponent();
            donateform_label.Text = "JAYG is a free and open source software\n\r" +
                                    "if you liked it you can buy me a beer!\n\r";
            
        }

        private void DonateForm_Load(object sender, EventArgs e)
        {

        }

       
    }
}
