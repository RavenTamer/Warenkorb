using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warenkorb
{
    public partial class CartForm : Form
    {
        List<OrderItem> orderlist = new List<OrderItem>();
        public CartForm(List<OrderItem> ordereditems)
        {
            InitializeComponent();
            orderlist = ordereditems;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cartbox_Load(object sender, EventArgs e)
        {

        }
    }
}
