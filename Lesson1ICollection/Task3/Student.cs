
namespace Task3
{
    class Student : Citizen
    {
        public Student (string name, string id) : base(name, id) { }
        // реализация свойств возможна и автосвойством
        public override string Name { get; set; }
        public override string Id { get; set; }
    }
}
