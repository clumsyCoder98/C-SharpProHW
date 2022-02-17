using System;
using System.Runtime.Serialization;

namespace Additional_Task
{
    [Serializable]
    class TestClass : ISerializable
    {
        public string name;
        public int age;
        [NonSerialized]
        public string nameAge;
        public TestClass(string name, int age)
        {
            this.name = name;
            this.age = age;
            nameAge = this.name + this.age;
        }

        private TestClass(SerializationInfo entries, StreamingContext context)
        {
            name = entries.GetString("name");
            age = entries.GetInt32("age");
            nameAge = name + age;
        }

        void ISerializable.GetObjectData(SerializationInfo entries, StreamingContext context)
        {
            entries.AddValue("name", name);
            entries.AddValue("age", age);
        }

    }
}
