using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Presenter
{
    public static class FloodDataFormatter
    {
        public static StringBuilder Serialize(object obj)
        {
            var sb = new StringBuilder();
            var type = obj.GetType();
            IList<PropertyInfo> properties = new List<PropertyInfo>(type.GetProperties());
            foreach(var prop in properties)
            {
                var value = prop.GetValue(obj);
                sb.AppendLine();
                if(prop.PropertyType == typeof(bool))
                    sb.Append(prop.Name);
                else
                    sb.Append($"{prop.Name} {value.ToString()}");
            }
            return sb;
        }
        /*
        public T Deserialize<T>(StringBuilder content) where T: new()
        {
            T result = new T();
            var dictionaryResult = new Dictionary<string, string>();
            foreach (var str in content.ToString().Split(Environment.NewLine.ToCharArray()))
            {
                var kvp = str.Split(' ').Where(x => x.Length > 0);
                if (kvp.Count() != 2)
                    throw new InvalidCastException("Can't read parameters");

            }


            return result;
        }

        private bool IsCorrectContent(string content)
        {
            foreach(var str in content.Split(Environment.NewLine.ToCharArray()))
            {
                if (str.Split(' ').Where(x => x.Length > 0).Count() != 2) return false;
            }
            return true;
        }

    */
    }
}
