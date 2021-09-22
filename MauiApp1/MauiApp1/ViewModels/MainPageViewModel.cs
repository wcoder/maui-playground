namespace MauiApp1.ViewModels
{
    public class MainPageViewModel
    {
        public int Count { get; private set; }

        public void Increment() => Count += 10;
    }
}
