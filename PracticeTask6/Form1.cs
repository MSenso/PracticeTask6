using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeTask6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double m;
        const int size = 3;
        static double[] buf = new double[size];
        double Max()
        {
            if (buf[0] > buf[1])
            {
                if (buf[0] > buf[2]) return buf[0];
                else return buf[2];
            }
            else if (buf[1] > buf[2]) return buf[1];
            else return buf[2];
        }
        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                m_input.Text = m_input.Text.Replace('.', ',');
                if (double.TryParse(m_input.Text, out m))
                {
                    if (Math.Abs(buf[2]) <= Math.Pow(10, 10))
                    {
                        if (!double.TryParse(a1_input.Text, out buf[0]))
                            a1_input.Focus();
                        else if (!double.TryParse(a2_input.Text, out buf[1]))
                            a2_input.Focus();
                        else if (!double.TryParse(a3_input.Text, out buf[2]))
                            a3_input.Focus();
                        else
                        {
                            if (buf[1] == 0 && buf[2] == 0)
                            {
                                if (m > Max()) MessageBox.Show("Члены последовательности всегда будут меньше m!", "Вывод", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else Recursion(counter: 0);
                            }
                            else if ((buf[1] == 0 || buf[2] == 0) && buf[0] == 0 && m > Max()) MessageBox.Show("Члены последовательности всегда будут меньше m!", "Вывод", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else Recursion(counter: 0);
                        }
                    }
                    else MessageBox.Show("Введите число, по модулю не превышающее 10^10!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Некорректный ввод числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        string result = string.Empty;
        void Recursion(int counter)
        {
            if (counter < size)
            {
                if (buf[counter] < m)
                {
                    result += buf[counter].ToString() + " ";
                    counter++;
                    Recursion(counter);
                }
                else
                {
                    /*if (buf[counter] == m)*/ result += buf[counter].ToString() + " ";
                    Sequence_output.Text = result;
                    if (buf[counter] == m) Equals_output.Text = "An равно m";
                    else Equals_output.Text = "An не равно m";
                }
            }
            else
            {
                double digit = buf[size - 1] * buf[size - 2] + buf[size - 3];
                if (digit < m)
                {
                    result += digit.ToString() + " ";
                    double temp = buf[size - 1];
                    buf[size - 1] = digit;
                    buf[size - 3] = buf[size - 2];
                    buf[size - 2] = temp;
                    counter++;
                    Recursion(counter);
                }
                else
                {
                    /*if (digit == m)*/ result += digit.ToString() + " ";
                    Sequence_output.Text = result;
                    if (digit == m) Equals_output.Text = "An равно m";
                    else Equals_output.Text = "An не равно m";
                }
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            result = string.Empty;
            Sequence_output.Text = string.Empty;
            Equals_output.Text = string.Empty;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                a1_input.Text = a1_input.Text.Replace('.', ',');
                if (double.TryParse(a1_input.Text, out buf[0]))
                {
                    if (Math.Abs(buf[0]) <= Math.Pow(10, 10))
                    {
                        if (double.TryParse(a2_input.Text, out buf[1]) && double.TryParse(a3_input.Text, out buf[2]) && double.TryParse(m_input.Text, out m))
                        {
                            Sequence_output.Text = string.Empty;
                            Equals_output.Text = string.Empty;
                            if (buf[1] == 0 && buf[2] == 0)
                            {
                                if (m > Max()) MessageBox.Show("Члены последовательности всегда будут меньше m!", "Вывод", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else Recursion(counter: 0);
                            }
                            else if ((buf[1] == 0 || buf[2] == 0) && buf[0] == 0 && m > Max()) MessageBox.Show("Члены последовательности всегда будут меньше m!", "Вывод", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else Recursion(counter: 0);
                        }
                        else a2_input.Focus();
                    }
                    else MessageBox.Show("Введите число, по модулю не превышающее 10^10!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Некорректный ввод числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                a2_input.Text = a2_input.Text.Replace('.', ',');
                if (double.TryParse(a2_input.Text, out buf[1]))
                {
                    if (Math.Abs(buf[1]) <= Math.Pow(10, 10))
                    {
                        if (double.TryParse(a1_input.Text, out buf[0]) && double.TryParse(a3_input.Text, out buf[2]) && double.TryParse(m_input.Text, out m))
                        {
                            Sequence_output.Text = string.Empty;
                            Equals_output.Text = string.Empty;
                            if (buf[1] == 0 && buf[2] == 0)
                            {
                                if (m > Max()) MessageBox.Show("Члены последовательности всегда будут меньше m!", "Вывод", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else Recursion(counter: 0);
                            }
                            else if ((buf[1] == 0 || buf[2] == 0) && buf[0] == 0 && m > Max()) MessageBox.Show("Члены последовательности всегда будут меньше m!", "Вывод", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else Recursion(counter: 0);
                        }
                        else a3_input.Focus();
                    }
                    else MessageBox.Show("Введите число, по модулю не превышающее 10^10!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Некорректный ввод числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                a3_input.Text = a3_input.Text.Replace('.', ',');
                if (double.TryParse(a3_input.Text, out buf[2]))
                {
                    if (Math.Abs(buf[2]) <= Math.Pow(10, 10))
                    {
                        if (double.TryParse(a1_input.Text, out buf[0]) && double.TryParse(a2_input.Text, out buf[1]) && double.TryParse(m_input.Text, out m))
                        {
                            Sequence_output.Text = string.Empty;
                            Equals_output.Text = string.Empty;
                            if (buf[1] == 0 && buf[2] == 0)
                            {
                                if (m > Max()) MessageBox.Show("Члены последовательности всегда будут меньше m!", "Вывод", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else Recursion(counter: 0);
                            }
                            else if ((buf[1] == 0 || buf[2] == 0) && buf[0] == 0 && m > Max()) MessageBox.Show("Члены последовательности всегда будут меньше m!", "Вывод", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else Recursion(counter: 0);
                        }
                        else m_input.Focus();
                    }
                    else MessageBox.Show("Введите число, по модулю не превышающее 10^10!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Некорректный ввод числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void a1_input_TextChanged(object sender, EventArgs e)
        {
            result = string.Empty;
        }

        private void a2_input_TextChanged(object sender, EventArgs e)
        {
            result = string.Empty;
        }

        private void a3_input_TextChanged(object sender, EventArgs e)
        {
            result = string.Empty;
        }
    }
}
