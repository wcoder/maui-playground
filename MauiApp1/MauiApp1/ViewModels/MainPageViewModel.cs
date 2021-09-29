using Softeq.XToolkit.Common;
using Softeq.XToolkit.Common.Commands;

using System.Windows.Input;

namespace MauiApp1.ViewModels
{
    public class MainPageViewModel : ObservableObject
    {
        public MainPageViewModel()
        {
            IncrementCommand = new RelayCommand(Increment);
        }

        public int Count { get; private set; }

        public ICommand IncrementCommand { get; }

        private void Increment() => Count += 10;
    }
}
