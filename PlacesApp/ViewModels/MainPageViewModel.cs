using PlacesApp.Interfaces;
using PlacesApp.Models;

using Softeq.XToolkit.Common;
using Softeq.XToolkit.Common.Collections;
using Softeq.XToolkit.Common.Commands;

using System.Windows.Input;

namespace PlacesApp.ViewModels
{
    public class MainPageViewModel : ObservableObject
    {
        private readonly IGoogleMapsApiService _googleMapsApi;

        private string _query;

        public MainPageViewModel(
            IGoogleMapsApiService googleMapsApi)
        {
            _googleMapsApi = googleMapsApi;

            Places = new ObservableRangeCollection<GooglePlaceAutoCompletePrediction>();
            GetPlacesCommand = new AsyncCommand<string>(GetPlacesByName);
        }

        public ICommand GetPlacesCommand { get; set; }

        public ObservableRangeCollection<GooglePlaceAutoCompletePrediction> Places { get; }

        public bool ShowRecentPlaces { get; set; }

        public string Query
        {
            get => _query;
            set
            {
                if (Set(ref _query, value))
                {
                    GetPlacesCommand.Execute(value);
                }
            }
        }

        private async Task GetPlacesByName(string placeText)
        {
            if (string.IsNullOrEmpty(placeText?.Trim()))
            {
                Places.Clear();
                return;
            }

            // TODO YP: add cancellation token
            var places = await _googleMapsApi.GetPlaces(placeText);
            var placeResult = places.AutoCompletePlaces;

            if (placeResult != null && placeResult.Count > 0)
            {
                Places.ReplaceRange(placeResult);
            }
        }
    }
}
