
using Microsoft.Maui.Controls;
namespace ScreenOnboardingForBookshop.CustomViews
{
    public class IconButton : ContentView
    {
        public IconButton(string iconPath, string buttonText)
        {
            var image = new Image
            {
                Source = iconPath,
                WidthRequest = 24, // Adjust as needed
                HeightRequest = 24 // Adjust as needed
            };

            var label = new Label
            {
                Text = buttonText,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            Content = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Spacing = 8, // Adjust as needed
                Children = { image, label }
            };

            // Add your tap gesture or command handling logic here
            // For example, you can add a TapGestureRecognizer
            var tapGesture = new TapGestureRecognizer();
            tapGesture.Tapped += OnButtonClicked;
            GestureRecognizers.Add(tapGesture);
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            // Handle button click event
            // You can expose a Command property or use an event
            // For simplicity, this example uses a method
        }

    }

}
