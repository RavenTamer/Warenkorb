using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Warenkorb
{
    public partial class OrderForm : Form
    {
        List<OrderItem> ordereditems = new List<OrderItem>();
        
        
        public OrderForm()
        {
            InitializeComponent();
        }

        public void addbutton_Click(object sender, EventArgs e)
        {
            OrderItem oi = new();
            oi.ProductName = productbox.Text;
            oi.Amount = (int)quantitynum.Value;
            ordereditems.Add(oi);
            cartcountlabel.Text = "("+Convert.ToString(ordereditems.Count)+")";
        }

        public void cartlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CartForm cart = new CartForm(ordereditems);
            foreach (OrderItem orderitem in ordereditems)
            {
                cart.cartbox.Text += orderitem.ToString();
            }
            
            cart.ShowDialog();
        }
    }
}