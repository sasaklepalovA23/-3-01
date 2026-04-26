namespace ЛАБА_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double y, x, a;

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                try
                {
                    a = Convert.ToDouble(textBox1.Text);
                    x = Convert.ToDouble(textBox2.Text);

                    if (checkBox1.Checked)
                    {
                        if (radioButton1.Checked)
                            y = Math.Pow(Math.Abs(x), 5) * (1.0 / Math.Tan(Math.Abs(x)));
                        else if (radioButton2.Checked)
                            y = Math.Log(x * x + 1);
                        else if (radioButton3.Checked)
                            y = Math.Exp(-2 * x) - Math.Pow(Math.Abs(x + 1), 1.0 / 3.0);
                        else
                        {
                            MessageBox.Show("Выберите одну из функций!");
                            return;
                        }
                    }
                    else
                    {
                        if (x <= 0)
                            y = Math.Pow(Math.Abs(x), 5) * (1.0 / Math.Tan(Math.Abs(x)));
                        else if (x > 0 && x <= a)
                            y = Math.Log(x * x + 1);
                        else
                            y = Math.Exp(-2 * x) - Math.Pow(Math.Abs(x + 1), 1.0 / 3.0);
                    }

                    textBox3.Text = y.ToString("F4");
                }
                catch
                {
                    MessageBox.Show("Ошибка! Введите корректные числовые значения.", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Введите пожалуйста данные А и Х", "Ошибка ввода данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = checkBox1.Checked;
        }
    }
}
        