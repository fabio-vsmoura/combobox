namespace combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lista.Text == string.Empty)
            {
                MessageBox.Show("Escolha um valor da lista");
            }
            else
            {
                MessageBox.Show(lista.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lista.Text = "Ativado";
       
        }
    }
}
