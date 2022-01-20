
namespace Task2
{
    class Product
    {
        public Product(string category)
        {
            Category = category;
        }
        public string Category { get; set; }

        public override bool Equals(object obj)
        {
            var comparable = obj as Product;
            if (comparable.Category == null)
            {
                return false;
            }
            return comparable.Category == Category;
        }

        public override int GetHashCode()
        {
            return Category.GetHashCode();
        }
    }
}
