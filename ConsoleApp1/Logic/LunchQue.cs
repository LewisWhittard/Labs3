namespace ConsoleApp1.Logic
{
    public class LunchQue
    {
        private List<string> _lunchItems { get; set; }
        private readonly Parser _parser = new Parser();

        public LunchQue()
        {
            setLunchItems();
        }

        private void setLunchItems()
        {
            _lunchItems = new List<string>();
            _lunchItems.Add("Fish");
            _lunchItems.Add("Burgers");
            _lunchItems.Add("Veg");
        }

        public string ConstuctMeal()
        {
            string Food = AskWhatWouldYouLike();
            int Potatos = PotatoAmmount();
            int Sprouts = SproutAmmount();
            return $"Your lunch {Food} and {Potatos} Potatos and {Sprouts} sprouts";
        }

        public string AskWhatWouldYouLike()
        {
            Console.WriteLine($"What would you like {string.Join(", ",_lunchItems)}");
            string value = Console.ReadLine();
            return value;
        }

        public int PotatoAmmount()
        {
            string value = Console.ReadLine();
            return _parser.GetIntFromString(value);
        }

        public int SproutAmmount()
        {
            string value = Console.ReadLine();
            return _parser.GetIntFromString(value);
        }
    }
}

