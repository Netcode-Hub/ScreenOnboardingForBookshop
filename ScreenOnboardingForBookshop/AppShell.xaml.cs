namespace ScreenOnboardingForBookshop
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(BooksHomePage), typeof(BooksHomePage));
        }
    }
}
