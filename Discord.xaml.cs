using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Assignment_2
{
    /// <summary>
    /// Interaction logic for SocialMedia.xaml
    /// </summary>
    public partial class Discord : Window
    {
        public Discord()
        {
            InitializeComponent();
        }

        public static void sendWebHook(string url, string msg, string username)
        {
            Http.Post(url, new System.Collections.Specialized.NameValueCollection()
            {
                {
                    "username", username
                },
                {
                    "content", msg
                },
                {
                    "avatar_url", "https://i.imgur.com/4M34hi2.png"
                },
            });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sendWebHook("https://discord.com/api/webhooks/770515438969815050/3fUQaEAuYPELn3_xVD-_fImEzmqUwSbQrTjVIHomeaSRVcyCt0QmQqLE3SH23N7NrYVK", textBox.Text, nameTextBox.Text);
            MessageBox.Show("Your message has been sent!");
        }
    }
}
