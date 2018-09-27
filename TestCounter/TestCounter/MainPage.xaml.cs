using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestCounter
{
	public partial class MainPage : ContentPage
	{
        public static int counter;

        //Label label;
        public MainPage()
		{
            counter = 0;
			InitializeComponent();
            label.Text = "Pill: " + counter;
            //label = new Label
            //{
            //    Text = "" + counter,
            //    FontSize = 20,
            //    VerticalOptions = LayoutOptions.Start,
            //    HorizontalOptions = LayoutOptions.Center,
            //    Margin = 100,

            //};

        }

        public int Counter { get => counter; set => counter = value; }

        public void OnButtonClicked(object sender, EventArgs e)
        {
            counter++;
            label.Text = "Pill: " + counter;
            Console.WriteLine("onbtnclck");
        }

        public void OnDecreaseClicked(object sender, EventArgs e)
        {
            counter--;
            label.Text = "Pill: " + counter;
            Console.WriteLine("decremsntclck");
        }
    }
}
