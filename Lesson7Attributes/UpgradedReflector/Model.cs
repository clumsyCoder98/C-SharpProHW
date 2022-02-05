using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace UpgradedReflector
{
    class Model
    {
        Assembly assembly;
        Type[] types;
        public void LoadAssembly(string path)
        {
            assembly = Assembly.LoadFrom(path);
        }
        public string ShowTypes()
        {
            types = assembly.GetTypes();
            string inclTypes = "List of all types included in assembly:\n\n";
            foreach (Type type in types)
            {
                inclTypes += $">>>Type: {type.Name}\n\n";
            }
            return inclTypes;
        }
        public string ShowMethods()
        {
            string inclMethods = "\t\tIncluded methods:\n\n";
            foreach (Type type in types)
            {
                inclMethods += $"\tType: {type.Name}\n\n";
                MethodInfo[] methods = type.GetMethods();
                if (methods != null)
                {
                    foreach (MethodInfo method in methods)
                    {
                        inclMethods += $"Method: {method.Name}\n\n";
                    }
                }
            }
            return inclMethods;
        }
        public string ShowProperties()
        {
            string inclProps = "\t\tIncluded properties:\n\n";
            foreach (Type type in types)
            {
                inclProps += $"\tType: {type.Name}\n\n";
                PropertyInfo[] properties = type.GetProperties();
                if (properties != null)
                {
                    foreach (PropertyInfo property in properties)
                    {
                        inclProps += $"Property: {property.Name}\n\n";
                    }
                }
            }
            return inclProps;
        }
        public string ShowFields()
        {
            string inclFields = "\t\tIncluded fields:\n\n";
            foreach (Type type in types)
            {
                inclFields += $"\tType: {type.Name}\n\n";
                FieldInfo[] fields = type.GetFields();
                if(fields != null)
                {
                    foreach (FieldInfo field in fields)
                    {
                        inclFields += $"Field: {field.Name}, {field.FieldType}\n\n";
                    }
                }
            }
            return inclFields;
        }
        public string ShowAttributes()
        {
            string inclAttributes = "\t\tIncluded attributes:\n\n";
            foreach (Type type in types)
            {
                inclAttributes += $"\t>>>Type: {type.Name}<<<\n\n";
                var attributes = type.GetCustomAttributes(inherit:false);
                if (attributes != null)
                {
                    foreach (var att in attributes)
                    {
                        inclAttributes += $"Attribute: {att.GetType().Name}\n\n";
                    }
                }
                var members = type.GetMembers(); // получение всех членов типа и их атрибутов
                if (members != null)
                {
                    foreach(MemberInfo member in members)
                    {
                        var memAttributes = member.GetCustomAttributes(inherit:false);
                        if(memAttributes != null)
                        {
                            inclAttributes += $"\tMember: {member.Name}, {member.MemberType}\n\n";
                            foreach (var memAtt in memAttributes)
                            {
                                inclAttributes += $"Member Attribute: {memAtt.GetType().Name}\n\n";
                            }
                        }
                    }
                }
            }
            return inclAttributes;
        }
    }

}
