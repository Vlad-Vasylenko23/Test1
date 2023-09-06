namespace Calculator
{
    public partial class Form1 : Form
    {
        string di;
        int num1;
        int num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label20_MouseEnter(object sender, EventArgs e)
        {
            label20.BackColor = Color.Red;
        }

        private void label20_MouseLeave(object sender, EventArgs e)
        {
            label20.BackColor = Color.Transparent;
        }

        private void label19_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label19_MouseEnter(object sender, EventArgs e)
        {
            label19.BackColor = Color.Green;
        }

        private void label19_MouseLeave(object sender, EventArgs e)
        {
            label19.BackColor = Color.Transparent;
        }

        Point lastPoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(label1.Text);
            di = " / ";
            label2.Text = label1.Text + di;
            label1.Text = null;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
        }

        private void label12_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
        }

        private void label13_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
        }

        private void label14_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
        }

        private void label15_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
        }

        private void label16_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }

        private void label17_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
        }

        private void label18_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
        }

        private void label11_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(label1.Text);
            di = " + ";
            label2.Text = label1.Text+ di;
            label1.Text = null;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label2.Text= null;
            label1.Text= null;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(label1.Text);
            di = " - ";
            label2.Text = label1.Text + di;
            label1.Text = null;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(label1.Text);
            di = " õ ";
            label2.Text = label1.Text + di;
            label1.Text = null;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(label1.Text);
            if (di == " + ")
            {
                int summ = num1 + num2;
                label2.Text += num2 + " = " + summ;
                label1.Text = null;
            }
            else if (di == " - ")
            {
                int summ = num1 - num2;
                label2.Text += num2 + " = " + summ;
                label1.Text = null;
            }
            else if (di == " / ")
            {
                int summ = num1 / num2;
                label2.Text += num2 + " = " + summ;
                label1.Text = null;
            }
            else if (di == " õ ")
            {
                int summ = num1 * num2;
                label2.Text += num2 + " = " + summ;
                label1.Text = null;
            }
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            label11.BackColor = Color.LimeGreen;
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            label11.BackColor = Color.Transparent;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.BackColor = Color.LimeGreen;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.BackColor = Color.Transparent;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.BackColor = Color.LimeGreen;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = Color.Transparent;
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            label9.BackColor = Color.LimeGreen;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.BackColor = Color.Transparent;
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.BackColor = Color.LimeGreen;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.BackColor = Color.Transparent;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.BackColor = Color.LimeGreen;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.Transparent;
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            label12.BackColor = Color.LimeGreen;
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            label12.BackColor = Color.Transparent;
        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            label13.BackColor = Color.LimeGreen;
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            label13.BackColor = Color.Transparent;
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            label10.BackColor = Color.LimeGreen;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.BackColor = Color.Transparent;
        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            label14.BackColor = Color.LimeGreen;
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            label14.BackColor = Color.Transparent;
        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            label15.BackColor = Color.LimeGreen;
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            label15.BackColor = Color.Transparent;
        }

        private void label16_MouseEnter(object sender, EventArgs e)
        {
            label16.BackColor = Color.LimeGreen;
        }

        private void label16_MouseLeave(object sender, EventArgs e)
        {
            label16.BackColor = Color.Transparent;
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label8.BackColor = Color.LimeGreen;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.BackColor = Color.Transparent;
        }

        private void label17_MouseEnter(object sender, EventArgs e)
        {
            label17.BackColor = Color.LimeGreen;
        }

        private void label17_MouseLeave(object sender, EventArgs e)
        {
            label17.BackColor = Color.Transparent;
        }

        private void label18_MouseEnter(object sender, EventArgs e)
        {
            label18.BackColor = Color.LimeGreen;
        }

        private void label18_MouseLeave(object sender, EventArgs e)
        {
            label18.BackColor = Color.Transparent;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.BackColor = Color.LimeGreen;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.Transparent;
        }
    }
}