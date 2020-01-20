using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string basURI = "https://webservice.casvpn.com/serverlist.php";
            WebRequest request = WebRequest.Create(basURI);
            request.Method = "GET";
            HttpWebResponse response = null;
            response = (HttpWebResponse)request.GetResponse();
            string strresulttest = null;

            using(Stream stream= response.GetResponseStream())
            {
                StreamReader read = new StreamReader(stream);
                strresulttest = read.ReadToEnd();
                read.Close();
            }





        }
    }
}
