using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lerning_English
{
    public partial class English : Form
    {
        Random rand;
        int count;

        List<string> eng_list;
        List<string> rus_list;

        int numPos;
        bool engOrRus;
        public English()
        {
            InitializeComponent();

            rand = new Random();

            count = 0;
        }
        private void CreateLists()
        {
            if (!File.Exists("lib.txt"))
            {
                var res = MessageBox.Show("Файл пуст. Хотите добавить слова/фразы для изучения?", "Message", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    CreateAddForm();
                }
                else
                {
                    //Close();
                    Application.Exit();
                }
                return;
            }

            eng_list = new List<string>();
            rus_list = new List<string>();

            using (var sr = new StreamReader("lib.txt"))
            {
                string tmp;

                while (!sr.EndOfStream)
                {
                    tmp = sr.ReadLine();

                    if (!string.IsNullOrEmpty(tmp))
                    {
                        eng_list.Add(tmp);
                        rus_list.Add(sr.ReadLine());
                    }
                }
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                CreateLists();
                lbSpace.Text = "-";
            }

            if (eng_list != null)
            {
                UpdateTbForms();
            }
        }
        private void UpdateTbForms()
        {
            if (count / 2 >= eng_list.Count)
            {
                ChangeAgainOrClose();
            }

            if (count / 2 < eng_list.Count)
            {
                if (count % 2 == 0)
                {
                    ShowWord();
                }
                else
                {
                    ShowTranslate();
                }
            }
        }
        private void ChangeAgainOrClose()
        {
            var res = MessageBox.Show("Слова закончились!\nНачать заново?", "Message", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                count = 0;
            }
            else
            {
                Close();
            }
        }
        private void ShowWord()
        {
            numPos = rand.Next(count++ / 2, eng_list.Count);

            if (rand.Next() % 3 == 0)
            {
                lbWord.Text = eng_list[numPos];
                engOrRus = true;
            }
            else
            {
                lbWord.Text = rus_list[numPos];
                engOrRus = false;
            }

            lbTranslate.Text = string.Empty;
        }
        private void ShowTranslate()
        {
            if (engOrRus == true)
            {
                lbTranslate.Text = rus_list[numPos];
            }
            else
            {
                lbTranslate.Text = eng_list[numPos];
            }

            (eng_list[count / 2], eng_list[numPos]) = (eng_list[numPos], eng_list[count / 2]);
            (rus_list[count / 2], rus_list[numPos]) = (rus_list[numPos], rus_list[count / 2]);

            count++;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateAddForm();
        }
        private void CreateAddForm()
        {
            new FormAdd().ShowDialog();

            CreateLists();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Вы действительно хотите выйти?", "Message", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
