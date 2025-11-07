using Restaurant.Models;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        private Employee employee = new();
        private object order;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(amountQuantity.Text);
            string text = "";
            if (EggRadio.Checked == true)
            {
                text = "Egg";
            }
            else if (ChickenRadio.Checked == true)
            {
                text = "Chicken";
            }
            else
            {
                throw new Exception("We does not have its Order");
            }
            try
            {
                if (amount <= 0)
                {
                    throw new Exception("Amount cannot be small by zero ");
                }
                order = employee.NewRequest(amount, text);
                listResults.Text += employee.Inspect(order) + Environment.NewLine;
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var order = employee.CopyWithRequest();
                listResults.Text += employee + Environment.NewLine;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var result = employee.PrepareFood();
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
