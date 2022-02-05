using System;

namespace Additional_Task
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
    class AccesLevelAttribute : System.Attribute
    {
        private readonly string accesLevel; // позиционный атр
        public string AccesLevel { get { return accesLevel; } }
        public AccesLevelAttribute (string accesLevel)
        {
            this.accesLevel = accesLevel.ToLowerInvariant();
        }

        public int Id { get; set; } // именованый (не обязательный) атр
    }
}
