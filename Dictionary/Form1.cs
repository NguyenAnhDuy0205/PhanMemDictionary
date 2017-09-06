using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class Form1 : Form
    {
        DictionaryManager dictionary;
        SpeakTest speakVietNamese;
        SpeakTest speakEnglish;
        bool isLoading1 = true;
        bool isLoading2 = true;
        public Form1()
        {
            InitializeComponent();
            ChangeLoading();

            comboBoxWord.DisplayMember = "Key";

            WebBrowser VietName = new WebBrowser();
            VietName.Width = 0;
            VietName.Height = 0;
            VietName.Visible = false;
            VietName.ScriptErrorsSuppressed = true;
            VietName.Navigate(Content.VietNamelink);
            VietName.DocumentCompleted += VietName_DocumentCompleted;
            this.Controls.Add(VietName);

            WebBrowser English = new WebBrowser();
            English.Width = 0;
            English.Height = 0;
            English.Visible = false;
            English.ScriptErrorsSuppressed = true;
            English.Navigate(Content.Englishlink);
            English.DocumentCompleted+=English_DocumentCompleted;
            this.Controls.Add(English);

            

            speakVietNamese = new SpeakTest(VietName);
            speakEnglish = new SpeakTest(English);

            dictionary = new DictionaryManager();
            dictionary.LoadDatatoComboBox(comboBoxWord);
        }

        private void English_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            isLoading1 = false;
            ChangeLoading();
        }

        private void VietName_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            isLoading2 = false;
            ChangeLoading();
        }

        void ChangeLoading()
        {
            this.Enabled = !(isLoading1 && isLoading2);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo!!!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
                return;
            }
            dictionary.Serialize();
        }

        private void comboBoxWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.DataSource == null)
           
                return;
            DictionaryData data = cb.SelectedItem as DictionaryData;

            textBoxMeaning.Text = data.Meaning;
            textBoxExplaination.Text = data.Explaination;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            dictionary.Serialize();
        }

        private void buttonSpeaker1_Click(object sender, EventArgs e)
        {
            
            speakEnglish.Speakdata((comboBoxWord.SelectedItem as DictionaryData).Key);
        }

        private void buttonSpeaker2_Click(object sender, EventArgs e)
        {


            speakVietNamese.Speakdata(textBoxMeaning.Text);
        }

        private void buttonSpeaker3_Click(object sender, EventArgs e)
        {


            speakVietNamese.Speakdata(textBoxExplaination.Text);
        }
    }
}
