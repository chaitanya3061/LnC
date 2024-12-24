
namespace BookPrintingApp.Models
{
    public class BookLocation
    {
        private string ShelfNumber { get; set; }
        private string RoomNumber { get; set; }

        public BookLocation(string shelfNumber, string roomNumber)
        {
            ShelfNumber = shelfNumber;
            RoomNumber = roomNumber;
        }

        public string getLocation()
        {
            return $"Shelf: {ShelfNumber}, Room: {RoomNumber}";
        }
    }
}
