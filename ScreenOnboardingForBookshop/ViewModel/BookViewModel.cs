using System.Collections.ObjectModel;
using System.ComponentModel;
namespace ScreenOnboardingForBookshop.ViewModel
{
    public class BookViewModel
    {
        public BookViewModel()
        {
            LoadDefaultBooks();
        }
        public ObservableCollection<Book> Books { get; set; } = new ObservableCollection<Book>();

        private void LoadDefaultBooks()
        {
            Books?.Clear();
            Books.Add(new Book() { 
                Id = 1, 
                Image = "image1.png",
                Title = "Everything is straight to the point.",
                Description = "Be the first to know about new releases, exclusive offers, and literary events. Stay connected with your favorite authors and fellow book lovers." });

            Books.Add(new Book() { 
                Id = 2, 
                Image = "image2.png",
                Title = "Pick Every product that you want."!,
                Description = "Ordering your favorite books has never been easier. A few taps, and your next read is on its way to your doorstep."
            });

            Books.Add(new Book() { 
                Id = 3, 
                Image = "image3.png",
                Title ="Flash sale everyday, all of happy now.",
                Description = "Dive into our vast collection of books spanning genres from fiction to non-fiction. Find your next adventure, gain knowledge, and explore diverse narratives."
            });
        }

        
    }
}
