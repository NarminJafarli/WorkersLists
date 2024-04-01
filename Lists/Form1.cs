namespace Lists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text + "  " + textBox2.Text + " " + textBox3.Text);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int delete = listBox1.SelectedIndex;

            if (delete == -1)
            {
                listBox1.Items.RemoveAt(delete);
            }
            else
            {
                MessageBox.Show("Please select items");
            }
        }
    }
}
