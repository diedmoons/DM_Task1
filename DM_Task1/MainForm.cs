using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DM_Task1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SetArr_button_Click(object sender, EventArgs e)
        {
            if (CountOfArr_textBox.Text == "")
            {
                MessageBox.Show("Укажите количесво элементов в массиве!");
            }
            else
                Arr_textBox.Lines = Algorithms.RandomArr(Convert.ToInt32(CountOfArr_textBox.Text));
        }

        private void SortArr_button_Click(object sender, EventArgs e)
        {
            if (CountOfArr_textBox.Text == "")
            {
                MessageBox.Show("Укажите количесво элементов в массиве!");
            }
            else
                Arr_textBox.Lines = Algorithms.SortArr(Convert.ToInt32(CountOfArr_textBox.Text));
        }

        private void SequentialSearch_button_Click(object sender, EventArgs e)
        {
            if (FindNumber_textBox.Text == "" || Arr_textBox.Text == "")
            {
                MessageBox.Show(" Задайте массив и укажите искомое число!");
            }
            else
            {
                int result = Algorithms.SequentialSearch((Algorithms.TOINT(Arr_textBox.Lines)), Convert.ToInt32(FindNumber_textBox.Text));
                if (result != 0)
                {
                    Result_textBox.Text = "Число обходов: ";
                    Result_textBox.Text += result.ToString();
                }
                else
                {
                    Result_textBox.Text = ("Искомое число не найдено");


                }
            }
        }

        private void BinarySearch_button_Click(object senкder, EventArgs e)
        {
            if (FindNumber_textBox.Text == "" || Arr_textBox.Text == "")
            {
                MessageBox.Show(" Задайте упорядоченный  массив и укажите искомое число!");
            }
            else
            {

                int result = Algorithms.BinarySearch(
                    (Algorithms.TOINT(Arr_textBox.Lines)), Convert.ToInt32(FindNumber_textBox.Text));
                if (result != 0)
                {
                    Result_textBox.Text = "Число обходов: ";
                    Result_textBox.Text += result.ToString();
                }
                else
                {
                    Result_textBox.Text = "Искомое число не найдено";

                }
            }
        }

        private void button_InsertionSort_Click(object sender, EventArgs e)
        {
            if (Arr_textBox.Text == "")
            {
                MessageBox.Show("Задайте массив!");
            }

            else
            {
                int c = 0;
                SortArr_textBox.Lines = Algorithms.ToString(Sort.InsertionSort(Algorithms.TOINT(Arr_textBox.Lines), out c));
                Result_textBox.Text = "Число обходов: ";
                Result_textBox.Text += c.ToString();
            }
        }


        private void button_BinaryInsertionSort_Click(object sender, EventArgs e)
        {
            if (Arr_textBox.Text == "")
            {
                MessageBox.Show("Задайте массив!");
            }

            else
            {

                int c = 0;
                SortArr_textBox.Lines = Algorithms.ToString(Sort.BinaryInsertionSort(Algorithms.TOINT(Arr_textBox.Lines), out c));
                Result_textBox.Text = "Число обходов: ";
                Result_textBox.Text += c.ToString();

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BackSort_button_Click(object sender, EventArgs e)
        {
            Arr_textBox.Lines = Algorithms.BackSortArr(Convert.ToInt32(CountOfArr_textBox.Text));
        }

        private void Bubble_button_Click(object sender, EventArgs e)
        {
            if (Arr_textBox.Text == "")
            {
                MessageBox.Show("Задайте массив!");
            }

            else
            {
                int c = 0;
                int swap = 0;
                SortArr_textBox.Lines = Algorithms.ToString
                    (Sort.SortBubl(Algorithms.TOINT(Arr_textBox.Lines), out c, out swap));
                Result_textBox.Text = "Число обходов: ";
                Result_textBox.Text += c.ToString();
                Result_textBox.Text += " Число swap: ";
                Result_textBox.Text += swap.ToString();
            }
        }

        private void Shell_button_Click(object sender, EventArgs e)
        {

            if (Arr_textBox.Text == "")
            {
                MessageBox.Show("Задайте массив!");
            }

            else if (Step_textBox.Text == "")
            {
                MessageBox.Show("Задайте шаг!");
            }

            else
            {

                int c = 0;
                int swap = 0;
                SortArr_textBox.Lines = Algorithms.ToString
                    (Sort.ShellSort(Algorithms.TOINT(Arr_textBox.Lines), Convert.ToInt32(Step_textBox.Text), out c, out swap));
                Result_textBox.Text = "Число обходов: ";
                Result_textBox.Text += c.ToString();
                Result_textBox.Text += " Число swap: ";
                Result_textBox.Text += swap.ToString();
            }
        }

        private void button_QuickSort_Click(object sender, EventArgs e)
        {
            int c = 0;
            
            
            SortArr_textBox.Lines = Algorithms.ToString
                (Sort.QuickSort(Algorithms.TOINT(Arr_textBox.Lines), 0, Convert.ToInt32(Arr_textBox.Lines.Length-1), ref c ));
            Result_textBox.Text = "Число обходов: ";
            Result_textBox.Text += c.ToString();

        }

        private void button_MergeSort_Click(object sender, EventArgs e)
        {
            int c = 0;


            SortArr_textBox.Lines = Algorithms.ToString
                (Sort.MergeSort(Algorithms.TOINT(Arr_textBox.Lines), ref c));
            Result_textBox.Text = "Число обходов: ";
            Result_textBox.Text += c.ToString();
        }
    }
}
