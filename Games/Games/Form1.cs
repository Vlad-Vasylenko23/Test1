namespace Games
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Playerbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
        private void label8_Click(object sender, EventArgs e)
        {
            
            Form3 form3 = new Form3();
            form3.Show();
        }  
        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "This is snake bro!";
        }
        private void label8_MouseLeave(object sender, EventArgs e)
        {  
            label1.Text = "";
        }
    }
}