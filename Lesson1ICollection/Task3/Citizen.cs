
namespace Task3
{
    abstract class Citizen
    {
        // абстр свойства нужно переопределить в производном классе
        public abstract string Name { get; set; }
        public abstract string Id { get; set; }

        // екземпляр абстр класа создать нельзя, но конст можно вызвать в производном классе
        public Citizen (string name, string id)
        {
            Name = name;
            Id = id;
        }
        public override bool Equals(object obj) // переопределения для сравнения по ID
        {
            if (obj is Citizen)
            {
                if (((Citizen)obj).Id == this.Id)
                    return true;
            }
            return false;
        }
        public override int GetHashCode() //переопределять с Equals в паре
        {
            return base.GetHashCode();
        }
    }
}
