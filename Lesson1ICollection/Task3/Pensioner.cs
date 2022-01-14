
namespace Task3
{
    class Pensioner : Citizen
    {
        string name;
        string id;
        public Pensioner(string name, string id) : base (name, id) { } // перевызов констр из базового

        // реализация свойств возможна пользовательская
        public override string Name
        {
            get
            { return name; }
            set
            { name = value; }
        }

        public override string Id
        { 
            get 
            { return id; }
            set 
            { id = value; }
        }

    }
}
