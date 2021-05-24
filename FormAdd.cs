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
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();

            if (!File.Exists("lib.txt"))
            {
                File.Create("lib.txt");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbWord.Text) || string.IsNullOrEmpty(tbTranslate.Text))
            {
                MessageBox.Show("Заполните все поля перед добавлением!", "Message");
                return;
            }

            WritingToFile();
        }
        private void WritingToFile()
        {
            using (var sw = File.AppendText("lib.txt"))
            {
                sw.WriteLine(tbWord.Text);
                tbWord.Text = string.Empty;

                sw.WriteLine(tbTranslate.Text);
                tbTranslate.Text = string.Empty;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
