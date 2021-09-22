using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

using System;

using MauiApp1.ViewModels;

namespace MauiApp1.Pages
{
    public partial class MainPage : ContentPage
    {
        private readonly MainPageViewModel _viewModel;

        public MainPage(MainPageViewModel viewModel)
        {
            _viewModel = viewModel;

            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            _viewModel.Increment();
            CounterLabel.Text = $"Current count: {_viewModel.Count}";

            SemanticScreenReader.Announce(CounterLabel.Text);
        }
    }
}
