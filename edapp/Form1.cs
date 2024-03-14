using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace edapp
{
    public partial class Form1 : Form
    {

        int question_count;
        int correct_answers;
        int wrong_answers;

        string[] array;

        int correct_answers_number;
        int selected_response;


        System.IO.StreamReader Read;

        public Form1()
        {
            InitializeComponent();
        }
        void start()
        {
            var Encoding = System.Text.Encoding.GetEncoding(65001);
            try
            {

                Read = new System.IO.StreamReader(
                System.IO.Directory.GetCurrentDirectory() +
                                               @"\t.txt", Encoding);
                this.Text = Read.ReadLine();

                question_count = 0;
                correct_answers = 0;
                wrong_answers = 0;

                array = new String[23];
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка 1");
            }
            вопрос();

        }


        void вопрос()
        {
            label1.Text = Read.ReadLine();
            radioButton1.Text = Read.ReadLine(); 
            radioButton2.Text = Read.ReadLine();
            radioButton3.Text = Read.ReadLine();
            var temp = Read.ReadLine(); 
            if (Read.EndOfStream || string.IsNullOrEmpty(temp)) {
                question_count++;
                button1.Text = "Завершить";
                return; 
            } 
            if (int.TryParse(temp, out correct_answers_number))
            {
                radioButton1.Checked = false; 
                radioButton2.Checked = false;
                radioButton3.Checked = false; 
                button1.Enabled = false;
                question_count++; if (Read.EndOfStream)
                    button1.Text = "Завершить";
            }
            else
            {
                MessageBox.Show("Ошибка чтения номера правильного ответа. Проверьте файл вопросов.", "Ошибка");
            }


        }

        void состаяниеперключение(object sender, EventArgs e)
        {

            button1.Enabled = true; button1.Focus();
            RadioButton Переключатель = (RadioButton)sender;
            var tmp = Переключатель.Name;
            if (int.TryParse(tmp.Substring(11), out int result))
            {
                selected_response = result;
            }
            else
            {
                MessageBox.Show("Ошибка преобразования выбранного ответа в число", "Ошибка");
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Следующий вопрос";
            button2.Text = "Выход";
            

            radioButton1.CheckedChanged += new EventHandler(состаяниеперключение);
            radioButton2.CheckedChanged += new EventHandler(состаяниеперключение);
            radioButton3.CheckedChanged += new EventHandler(состаяниеперключение);
            start();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selected_response == correct_answers_number)
            {
                correct_answers += 1;
            }
            else
            {
                wrong_answers += 1;
                array[wrong_answers] = label1.Text;
            }


            if (button1.Text == "Начать тестирование сначала")
            {
                button1.Text = "Следующий вопрос";
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                start();
                return;
            }

            if (button1.Text == "Завершить")
            {
                Read.Close();
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;

                label1.Text = string.Format("Тестирование завершено.\n" +
                    "Правильных ответов: {0} из {1}.\n" +
                    "Набранные баллы: {2:f2}.", correct_answers,
                    question_count, (correct_answers * 5.0f) / question_count);

                button1.Text = "Начать тестирование сначала";

                var str = "Список ошибок:\n\n";
                for (int i = 1; i <= wrong_answers; i++)
                    str = str + array[i] + "\n";

                if (wrong_answers != 0)
                {
                    MessageBox.Show(str, "Тестирование завершено");
                }
            }

            if (button1.Text == "Следующий вопрос")
            {
                вопрос();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm p1 = new MainForm();
            p1.Show();
        }

        
    }
}
