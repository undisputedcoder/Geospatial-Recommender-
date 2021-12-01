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
using InstagramApiSharp;
using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Logger;

namespace Assignment_2
{
    /// <summary>
    /// Interaction logic for Instagram.xaml
    /// </summary>
    public partial class Instagram : Window
    {
        private const string username = "mikeevans3045";
        private const string password = "B7qXDqkxAjy8tGk";
        private static IInstaApi api;
        private static UserSessionData user;

        public Instagram()
        {
            InitializeComponent();
            user = new UserSessionData();
            user.UserName = username;
            user.Password = password;
        }

        public static async void Login(string username, string text)
        {
            api = InstaApiBuilder.CreateBuilder()
                .SetUser(user)
                .UseLogger(new DebugLogger(LogLevel.Exceptions))
                .Build();

            var loginRequest = await api.LoginAsync();
            var iguser = await api.UserProcessor.GetUserAsync(username);
            var userid = iguser.Value.Pk.ToString();
            var directText = await api.MessagingProcessor.SendDirectTextAsync(userid, null, text);
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Login(ig.Text, directMessage.Text);
            MessageBox.Show("Message Sent!");
        }
    }
}
