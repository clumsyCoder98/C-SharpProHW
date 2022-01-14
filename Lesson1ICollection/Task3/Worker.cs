
namespace Task3
{
    class Worker : Citizen
    {
        public Worker (string name, string id) : base(name,id) { }
        public override string Name { get; set; }
        public override string Id { get; set; }
    }
}
