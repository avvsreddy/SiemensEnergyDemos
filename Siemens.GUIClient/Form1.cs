using Siemens.CodeLibrary;

namespace Siemens.GUIClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            SimpleMath sm = new SimpleMath();
            int max = sm.FindMax(num1, num2);
            MessageBox.Show("The maximum is: " + max);
        }
    }
}
