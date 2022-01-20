
namespace Task2
{
    class Customer
    {
        public Customer(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var comparable = obj as Customer;
            if(comparable == null)
            {
                return false;
            }
            return comparable.Name == Name;
        }
    }
}
