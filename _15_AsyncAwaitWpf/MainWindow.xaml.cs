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

namespace _15_AsyncAwaitWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // See https://aka.ms/new-console-template for more information
            //Synchronous Program execution
            //execute line by line, one at time
            //when a function is called, program execution has to wait until the function returns

            //When a function is called, program execution continues to next line, without waiting for the function to complete

            //whats the difference?
            //async programming improves responsiveness

            //real world examples
            //windows media player
            //browser
            //when to use?
            //accessing the web
            //working with file and databases
            //working with images

            //How?
            //traditional approaches
            //multi-threading
            //callbacks

            //new approach since .NET 4.5
            //async / await


        }

        private async void MyButton_Click(object sender, RoutedEventArgs e)
        {
            //DownloadHtml("https://msdn.microsoft.com");
            //await DownloadHtmlAsync("https://msdn.microsoft.com");
            //var html = GetHtml("https://msdn.microsoft.com");
            var getHtml =  GetHtmlAsync("https://msdn.microsoft.com");
            MessageBox.Show("Waiting for the task to be completed");
            var html = await getHtml;
            MessageBox.Show(html.Substring(0,10));
        }

        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);
            using (var streamWriter = new StreamWriter(@"c:\projects\result.html"))
            {
               await streamWriter.WriteAsync(html);
            }
        }

        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);
            using (var streamWriter = new StreamWriter(@"c:\projects\result.html"))
            {
                streamWriter.Write(html);
            }
        }


        public string GetHtml(string url)
        {
            var webClient = new WebClient();
            return webClient.DownloadString(url);
        }

        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(url);
        }
    }
}
