using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace CardViewCrash
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; } = new ObservableCollection<string>
        {
            "https://via.placeholder.com/300.png/09f/fff",
            "https://via.placeholder.com/300.png/01f/fff"
        };

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void Select(object sender, EventArgs e)
        {

        }
    }
}
