using MarvelAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MarvelAPI
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.MarvelManager1.GetTasksAsync();
        }
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Marvel marvel = (Marvel)e.SelectedItem;
            await DisplayAlert("Worthless Info", marvel.Name + "\nHas " + marvel.Description + " characters.", "OK");

        }
    }
}
