using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Dictionary
{
    public class DictionaryManager
    {
        #region Thuộc tính
        private string filePath = "data.xml";
        private DictionaryItem items;

        public DictionaryItem Items
        {
            get { return items; }
            set { items = value; }
        }
        #endregion

        public DictionaryManager()
        {

            items = (DictionaryItem)DeserializeFromXML(filePath);
        }
        //--------Load dữ liệu vào comboBox------------------------------------------------------------------------
        #region Phương thức
        public void LoadDatatoComboBox(ComboBox combo)
        {
            combo.DataSource = items.Items;
        }
        //------------- Tới file XML lấy dữ liệu -------------------------------------------------------------------
        private void SerializeToXML(object data, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            XmlSerializer sr = new XmlSerializer(typeof(DictionaryItem));

            sr.Serialize(fs, data);

            fs.Close();
        }
                         //------Back-up dữ liệu --------------------------------------------------------------------
        public void Serialize()
        {
            SerializeToXML(Items, filePath);
        }
        //---------------Lấy dữ liệu từ file XML ------------------------------------------------------------------
        public object DeserializeFromXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            XmlSerializer sr = new XmlSerializer(typeof(DictionaryItem));

            object obj = sr.Deserialize(fs);
            fs.Close();
            return obj;
        }
        #endregion
    }
}
