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
using System.Web;
using CASVPN.Model;
using System.Net.Http;
using System.Text.Json;

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
            httpRequest();
        }
       private void httpRequest()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://webservice.casvpn.com/serverlist.php");
            HttpResponseMessage response = client.GetAsync("").Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var obj = JsonSerializer.Deserialize<ServerModel>(result);
            }
        }




    }
}
