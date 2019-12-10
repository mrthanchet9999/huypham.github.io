using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace qlnt.UI
{
    public partial class APIWeather : Form
    {
        public APIWeather()
        {
            InitializeComponent();
        }
        private const string API_KEY = "96d1895c2c68b23d0f37dd7ad5bb5bff";


        private const string CurrentUrl =
            "http://api.openweathermap.org/data/2.5/weather?" +
            "@QUERY@=@LOC@&mode=xml&units=imperial&APPID=" + API_KEY;
        private const string ForecastUrl =
            "http://api.openweathermap.org/data/2.5/forecast?" +
            "@QUERY@=@LOC@&mode=xml&units=imperial&APPID=" + API_KEY;

        private string[] QueryCodes = { "q", "zip", "id", };

        Dictionary<string, string> icon=new Dictionary<string, string>();
        public void createDictionary()
        {
            int j = 0;
            List<string> name = new List<string>() { "Quang đãng", "Ít mây", "Nhiều mây", "Mây rải rác", "", "", "", "", "Mưa rào", "Mưa", "Có sấm" };
            for (int i = 1; i <= 11; i++)
            {
                string h = "";
                if (i < 10)
                    h = "0";
                string d = String.Concat(h, i.ToString(), "d");
                string n = String.Concat(h, i.ToString(), "n");
                icon.Add(d, name.ElementAt(j));
                icon.Add(n, name.ElementAt(j));
                j++;

            }
        }
        private void APIWeather_Load(object sender, EventArgs e)
        {
            createDictionary();
            load();
        }
        public void load()
        {

            string url = ForecastUrl.Replace("@LOC@", "Thành phố Hồ chí Minh");
            url = url.Replace("@QUERY@", QueryCodes[0]);


            using (WebClient client = new WebClient())
            {

                try
                {
                    DisplayForecast(client.DownloadString(url));
                }
                catch (WebException ex)
                {
                    DisplayError(ex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unknown error\n" + ex.Message);
                }
            }
        }

        private void btnForecast_Click(object sender, EventArgs e)
        {

        }


        private void DisplayForecast(string xml)
        {




            XmlDocument xml_doc = new XmlDocument();
            xml_doc.LoadXml(xml);

            XmlNode loc_node = xml_doc.SelectSingleNode("weatherdata/location");
            labelViTri.Text = "Thành phố Hồ Chí Minh, "+loc_node.SelectSingleNode("country").InnerText;


            // lvwForecast.Items.Clear();
            string degrees = (char)176 + "C";



            foreach (XmlNode time_node in xml_doc.SelectNodes("//time"))
            {

                DateTime time =
                    DateTime.Parse(time_node.Attributes["from"].Value,
                        null, DateTimeStyles.AssumeUniversal);

                if (DateTime.Compare(DateTime.Now, time) == 1)
                {
                    //Lấy nhiệt độ
                    XmlNode temp_node = time_node.SelectSingleNode("temperature");
                    string temp = temp_node.Attributes["value"].Value;
                    //chuyển từ độ F sang C
                    double tempC = (Convert.ToDouble(temp) * 1.0 - 32) / 1.8;
                    temp = tempC.ToString();

                    // Lấy biểu tượng thời tiết hiện tại
                    XmlNode sym_node = time_node.SelectSingleNode("symbol");
                    string var = sym_node.Attributes["var"].Value;
                    string path = var + ".png";
                    string state = icon.SingleOrDefault(p=>p.Key == var).Value;
                    labelTinhTrang.Text = state;

                    pictureBox1.Image = new Bitmap(Application.StartupPath + "\\iconWeather\\"+path);
                    break;
                }
            }
        }


        private void DisplayError(WebException exception)
        {
            try
            {
                StreamReader reader = new StreamReader(exception.Response.GetResponseStream());
                XmlDocument response_doc = new XmlDocument();
                response_doc.LoadXml(reader.ReadToEnd());
                XmlNode message_node = response_doc.SelectSingleNode("//message");
                MessageBox.Show(message_node.InnerText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown error\n" + ex.Message);
            }
        }
    }
}
