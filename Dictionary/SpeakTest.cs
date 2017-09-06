using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public class SpeakTest
    {
        private WebBrowser wb;

        public WebBrowser Wb
        {
            get { return wb; }
            set { wb = value; }
        }

        public SpeakTest(WebBrowser w)
        {
            this.Wb = w;
        }
        private void setText(string data)
        {
            HtmlElement element = Wb.Document.GetElementById("text");
            element.SetAttribute("value", data);
        }

        private void Speak()
        {
            HtmlElement element = Wb.Document.GetElementById("playbutton");
            element.InvokeMember("click");
        }
        public  void Speakdata(string data)
        {
           
             setText(data);
             Speak();
        }
    }
}
