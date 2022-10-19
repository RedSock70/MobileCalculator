using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using org.mariuszgromada.math.mxparser;

namespace Calculator101
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            {
                InitializeComponent();
               
            } 


            
        }

        void ClickyNumber(object sender, EventArgs e)
        {
            Button D = (Button)sender;
            DisplayText.Text += D.Text;

        }

        void ClickySign(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            DisplayText.Text += B.Text;

        }
        void ClickyEqual(object sender, EventArgs e)
        {
            Expression a = new Expression(DisplayText.Text);
            DisplayText.Text = a.calculate().ToString();
        }

        void ClickyClear(object sender, EventArgs e)
      
        {
            if (!string.IsNullOrEmpty(DisplayText.Text))
            {
                DisplayText.Text = string.Empty;
            }

             
        }

    }
}
