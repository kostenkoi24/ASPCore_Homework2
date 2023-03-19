namespace SimpleApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public string Categories { get; set; }

        public static string GetStocksStatus(int Stock)
        {
            if (Stock == 0)
            {
                return "немає в наявності";
            }
            if (Stock <= 5)
            {
                return "закінчується";
            }
            if (Stock > 5)
            {
                return "в наявності";
            }
            return "залишок не визначено";

        }

    }
}
