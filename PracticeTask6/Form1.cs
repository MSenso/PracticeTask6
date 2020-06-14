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
        public double m;
        const int size = 3;
        public double[] buf = new double[size]; // Три введенных числа
        string result = string.Empty;
        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Нажат энтер
            {
                m_input.Text = m_input.Text.Replace('.', ','); // Замена точки на запятую для корректного парса строки
                if (double.TryParse(m_input.Text, out m)) // Введено вещественное число
                {
                    if (Math.Abs(m) <= Math.Pow(10, 10)) // Введено число, не превосходящее 10 в 10
                    {
                        if (!double.TryParse(a1_input.Text, out buf[0])) // Введено не вещественное число
                            a1_input.Focus();
                        else if (!double.TryParse(a2_input.Text, out buf[1])) // Введено не вещественное число
                            a2_input.Focus();
                        else if (!double.TryParse(a3_input.Text, out buf[2])) // Введено не вещественное число
                            a3_input.Focus();
                        else
                        {
                            // Очистка результатов
                            Sequence_output.Text = string.Empty;
                            Equals_output.Text = string.Empty;
                            Compare_With_M(); // Сравнение введенных а1-а3 с М
                        }
                    }
                    else MessageBox.Show("Введите число, по модулю не превышающее 10^10!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Некорректный ввод числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        double Recursion(int x) // Рекурсия
        {
            if (x < size)
            {
                return buf[x]; // Возвращается ax
            }
            else
            {
                double res = Recursion(x - 1) * Recursion(x - 2) + Recursion(x - 3); // Подсчет по формуле
                return res;
            }
        }
        public void Calculating() // Вычисление последовательности
        {
            int count = 0; // Счетчик элементов
            int x = 0; // Текущий номер элемента
            double result_value = 0; // Полученное значение
            result = string.Empty;
            do
            {
                result_value = Recursion(x);
                result += result_value.ToString() + " "; // Запись полученного значения в выходную строку
                x++; // Номер увеличивается
                count++; // Количество элементов увеличивается
            } while (result_value < m); // Пока полученное значение меньше M
            Sequence_output.Text = result;
            Equals_output.Text = "Количество элементов: " + count + "\n";
            if (result_value == m) Equals_output.Text += "An равно m";
            else Equals_output.Text += "An не равно m";
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Очистка результатов
            result = string.Empty;
            Sequence_output.Text = string.Empty;
            Equals_output.Text = string.Empty;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Нажат энтер
            {
                a1_input.Text = a1_input.Text.Replace('.', ','); // Замена точки на запятую для корректного парса строки
                if (double.TryParse(a1_input.Text, out buf[0])) // Введено вещественное число
                {
                    if (Math.Abs(buf[0]) <= Math.Pow(10, 10)) // Введенное число не превосходит 10 в 10
                    {
                        if (double.TryParse(a2_input.Text, out buf[1]) && double.TryParse(a3_input.Text, out buf[2]) && double.TryParse(m_input.Text, out m)) // Остальные числа тоже корректно введены
                        {
                            // Очистка результатов
                            Sequence_output.Text = string.Empty;
                            Equals_output.Text = string.Empty;
                            Compare_With_M(); // Сравнение а1-а3 с М
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
            if (e.KeyCode == Keys.Enter) // Нажат энтер
            {
                a2_input.Text = a2_input.Text.Replace('.', ','); // Замена точки на запятую для корректного парса строки
                if (double.TryParse(a2_input.Text, out buf[1])) // Введено вещественное число
                {
                    if (Math.Abs(buf[1]) <= Math.Pow(10, 10)) // Введенное число не превосходит 10 в 10
                    {
                        if (double.TryParse(a1_input.Text, out buf[0]) && double.TryParse(a3_input.Text, out buf[2]) && double.TryParse(m_input.Text, out m)) // Остальные числа тоже корректно введены
                        {
                            // Очистка результатов
                            Sequence_output.Text = string.Empty;
                            Equals_output.Text = string.Empty;
                            Compare_With_M(); // Сравнение а1-а3 с М
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
            if (e.KeyCode == Keys.Enter) // Нажат энтер
            {
                a3_input.Text = a3_input.Text.Replace('.', ','); // Замена точки на запятую для корректного парса строки
                if (double.TryParse(a3_input.Text, out buf[2])) // Введено вещественное число
                {
                    if (Math.Abs(buf[2]) <= Math.Pow(10, 10)) // Введенное число не превосходит 10 в 10
                    {
                        if (double.TryParse(a1_input.Text, out buf[0]) && double.TryParse(a2_input.Text, out buf[1]) && double.TryParse(m_input.Text, out m)) // Остальные числа тоже корректно введены
                        {
                            // Очистка результатов
                            Sequence_output.Text = string.Empty;
                            Equals_output.Text = string.Empty;
                            Compare_With_M(); // Сравнение а1-а3 с М
                        }
                        else m_input.Focus();
                    }
                    else MessageBox.Show("Введите число, по модулю не превышающее 10^10!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Некорректный ввод числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void Compare_With_M()
        {
            if (buf[1] == 0 && buf[2] == 0) // а2 и а3 равны нулю
            {
                if (m > buf[0]) MessageBox.Show("Члены последовательности всегда будут меньше m!", "Вывод", MessageBoxButtons.OK, MessageBoxIcon.Information); // Последовательность не закончится
                else Calculating(); // Подсчет
            }
            else if (buf[1] == 0 && buf[0] == 0) // а2 и а1 равны нулю
            {
                if (m > buf[2]) MessageBox.Show("Члены последовательности всегда будут меньше m!", "Вывод", MessageBoxButtons.OK, MessageBoxIcon.Information); // Последовательность не закончится
                else Calculating(); // Подсчет
            }
            else Calculating(); // Подсчет
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void a1_input_TextChanged(object sender, EventArgs e)
        {
            // Очищение результатов
            result = string.Empty;
        }

        private void a2_input_TextChanged(object sender, EventArgs e)
        {
            // Очищение результатов
            result = string.Empty;
        }

        private void a3_input_TextChanged(object sender, EventArgs e)
        {
            // Очищение результатов
            result = string.Empty;
        }
    }
}
