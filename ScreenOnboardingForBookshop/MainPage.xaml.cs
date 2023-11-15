using ScreenOnboardingForBookshop.ViewModel;

namespace ScreenOnboardingForBookshop
{
    public partial class MainPage : ContentPage
    {
        public MainPage(BookViewModel bookViewModel)
        {
            InitializeComponent();
            BindingContext = bookViewModel; 
            MyButton.Text = "Check Next Feature";
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (myCarousel.CurrentItem == myCarousel.ItemsSource.Cast<object>().Last())
            {
                await Shell.Current.GoToAsync(nameof(BooksHomePage));
            }
            else
            {
                // Otherwise, move to the next item
                myCarousel.CurrentItem = myCarousel.ItemsSource.Cast<object>()
                    .SkipWhile(item => item != myCarousel.CurrentItem)
                    .Skip(1)
                    .First();
            }
        }

        private void myCarousel_PositionChanged(object sender, PositionChangedEventArgs e)
        {
            if(e.CurrentPosition == (int)myCarousel.ItemsSource.Cast<object>().Count() - 1)
            {
                MyButton.BackgroundColor = Color.FromRgb(24, 106, 185);
                MyButton.Text = "Getting Started";
            }
            else
            {
                MyButton.BackgroundColor = Color.FromRgb(255, 134, 99);
                MyButton.Text = "Check Next Feature";
            }
        }
    }

}
