namespace Lesson5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Form2 fr=new Form2();
            // fr.Show();
            //this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add("Seçim: "+comboBox1.Text);
            listBox1.Items.Add("Bashliq: "+textBox1.Text);
            listBox1.Items.Add("Mövzu: "+richTextBox1.Text);
            listBox1.Items.Add("-----------------------------");
        }
    }
}
