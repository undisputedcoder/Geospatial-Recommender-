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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        private CollaboratorDB CDB;
        public SignUp()
        {
            InitializeComponent();
            CDB = new CollaboratorDB();
        }

        //display value of slider in textbox
        private void svalue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int val = Convert.ToInt32(e.NewValue);
            string distance = String.Format("{0}", val);
            sliderValue.Text = distance;
        }

        private void SignUp1_Click(object sender, RoutedEventArgs e)
        {
            if(!CDB.AddCollaborator(firstName.Text, lastName.Text, state.Text, location.Text, email.Text, mobile.Text, sliderValue.Text, instagram.Text))
            {
                MessageBox.Show("Cannot add collaborator!");
            }
            else
            {
                MessageBox.Show("Sign Up successful!");
                Clear();
            }
        }

        //clear all fields in form after submit
        private void Clear()
        {
            firstName.Text = string.Empty;
            lastName.Text = string.Empty;
            state.Text = string.Empty;
            location.Clear();
            email.Clear();
            mobile.Text = "";
            sliderValue.Text = "";
            instagram.Text = "";
        }
    }
}
