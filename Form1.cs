namespace üçgenÇizimiApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = int.Parse(textBox1.Text);
            richTextBox1.Text = "";
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    richTextBox1.Text += "*";
                }

                richTextBox1.Text += "\n";

            }

        }
    }
}