using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string SourceText, ResultText;
        readonly CultureInfo myCI = new CultureInfo("ru-RU");
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSwap_Click(object sender, EventArgs e)
        {
            SourceText = txtBoxSource.Text;
            ResultText = txtBoxResult.Text;

            (ResultText, SourceText) = (SourceText, ResultText);

            txtBoxSource.Text = SourceText;
            txtBoxResult.Text = ResultText;
        }

        private void BtnRemoveSpaces_Click(object sender, EventArgs e)
        {
            SourceText = txtBoxSource.Text;

            ResultText = Regex.Replace(SourceText, @"\s+", "");

            txtBoxResult.Text = ResultText;
        }

        private void BtnUperrcase_Click(object sender, EventArgs e)
        {
            SourceText = txtBoxSource.Text;
            TextInfo textInfo = myCI.TextInfo;

            ResultText = textInfo.ToTitleCase(SourceText);

            txtBoxResult.Text = ResultText;
        }

        private void BtnSwapFirstLastLetterInWord_Click(object sender, EventArgs e)
        {
            SourceText = txtBoxSource.Text;

            Regex rx = new Regex(@"([^\w]*)(\w+)([^\w]*)", RegexOptions.Compiled);
            MatchCollection matches = rx.Matches(SourceText);
            string[] words = new string[matches.Count];

            for (int i = 0; i < matches.Count; i++)
            {
                string non_word_before = matches[i].Groups[1].ToString();
                string non_word_after = matches[i].Groups[3].ToString();
                string word = matches[i].Groups[2].ToString();
                string firstchar = (word.Length > 0) ? $"{word[0]}" : "";
                string lastchar = (word.Length > 1) ? $"{word[word.Length - 1]}" : "";
                string middle = (word.Length > 2) ? word.Substring(1, word.Length - 2) : "";
                string newword = lastchar + middle + firstchar;
                words[i] = non_word_before + newword + non_word_after;
            }

            ResultText = string.Join("", words);
            txtBoxResult.Text = ResultText;
        }

        private void BtnAzSort_Click(object sender, EventArgs e)
        {
            SourceText = txtBoxSource.Text;

            string[] words = Regex.Split(SourceText, @"\s+");
            Array.Sort(words, StringComparer.Ordinal);

            ResultText = string.Join("\r\n", words);
            txtBoxResult.Text = ResultText;
        }

        private void BtnSaveTXT_Click(object sender, EventArgs e)
        {
            SourceText = txtBoxSource.Text;

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Test";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            ResultText = path + @"\Result.txt";
            File.WriteAllText(ResultText, SourceText);
            txtBoxResult.Text = ResultText;
        }

        private void BtnModDate_Click(object sender, EventArgs e)
        {
            SourceText = txtBoxSource.Text;
            DateTime dt, now = DateTime.Now;

            try
            {
                dt = DateTime.ParseExact(SourceText, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show(@"Невозможно распознать дату, проверьте корректность ввода.", @"Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ResultText = $@"{dt:dd-MM-yyyy}
Неделя номер: {myCI.Calendar.GetWeekOfYear(dt, myCI.DateTimeFormat.CalendarWeekRule, myCI.DateTimeFormat.FirstDayOfWeek)}
До этой даты: {(int)(dt - now.Date).TotalDays}";

            txtBoxResult.Text = ResultText;
        }
    }
}
