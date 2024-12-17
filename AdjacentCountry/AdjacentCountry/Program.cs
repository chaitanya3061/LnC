namespace AdjacentCountry
{
    class Program
    {
        static Dictionary<string, List<string>> adjacentCountries = new Dictionary<string, List<string>>()
        {
            { "IN", new List<string> { "Pakistan", "China", "Nepal", "Bhutan", "Bangladesh", "Myanmar" } },
            { "US", new List<string> { "Canada", "Mexico" } },
            { "NZ", new List<string> { "Australia" } },
            { "RU", new List<string> { "Norway", "Finland", "Estonia", "Latvia", "Lithuania", "Poland", "Belarus", "Ukraine", "Georgia", "Azerbaijan", "Kazakhstan", "China", "Mongolia" } },
            { "BR", new List<string> { "Argentina", "Bolivia", "Colombia", "Guyana", "Paraguay", "Peru", "Suriname", "Uruguay", "Venezuela" } },
            { "FR", new List<string> { "Belgium", "Luxembourg", "Germany", "Switzerland", "Italy", "Monaco", "Spain" } },
        };

        static Dictionary<string, string> countryNames = new Dictionary<string, string>()
        {
            { "IN", "India" },
            { "US", "United States" },
            { "NZ", "New Zealand" },
            { "RU", "Russia" },
            { "BR", "Brazil" },
            { "FR", "France" },
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Country Code(Eg: IN/US/NZ ) : ");
            string inputCountryCode = Console.ReadLine();


            if (!string.IsNullOrEmpty(inputCountryCode) && adjacentCountries.ContainsKey(inputCountryCode))
            {
                Console.WriteLine($"The countries adjacent to {countryNames[inputCountryCode]} are:");
                foreach (var country in adjacentCountries[inputCountryCode])
                {
                    Console.WriteLine(country);
                }
            }
            else
            {
                Console.WriteLine("Invalid country code");
            }
        }
    }
}
