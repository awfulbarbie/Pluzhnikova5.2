namespace lab5._1_graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double f(double x)
        {
            try
            {
                if (x == Math.Sqrt(2) || x == Math.Sqrt(-2) ||  x < 1) //если условие выполняется возникает исключение
                {
                    throw new Exception();
                }
                else
                {
                    return (x + 4) / (Math.Pow(x, 2) - 2) + Math.Sqrt(Math.Pow(x, 3) - 1);
                }
            }
            catch
            {
                throw;  //Исключение передано внешнему блоку catch
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
                {
                    double a = 0;
                    double b = 0;
                    double h = 0;

                if (numericUpDown1.Value > numericUpDown2.Value)
                {
                    MessageBox.Show("Ошибка. Начало диапозона не может быть больше конца диапозона. Повторите попытку!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (numericUpDown3.Value <= 0)
                {
                    MessageBox.Show("Ошибка. Шаг не может быть отрицательным или равным 0. Повторите попытку!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                a = (double)numericUpDown1.Value;
                b = (double)numericUpDown2.Value;
                h = (double)numericUpDown3.Value;


                for (double i = a; i <= b; i += h)
                    {
                        try
                        {
                            textBox1.Text += $"y({i}) = {f(i):f4}" + Environment.NewLine;
                        }
                        catch
                        {
                            textBox1.Text += $"y({i}) = Возникло исключение! Переменная x имеет недопустимое значение" + Environment.NewLine;
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ошибка! Неверный формат ввода данных", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);  //внешний catch
                }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }
    }
}