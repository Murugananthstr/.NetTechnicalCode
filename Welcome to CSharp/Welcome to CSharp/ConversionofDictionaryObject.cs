using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel;

namespace Welcome_to_CSharp
{


    public static class ObjectToDictionaryHelper
    {
        //public static IDictionary<string, object> ToDictionary(this object source)
        //{
        //    return source.ToDictionary<object>();
        //}

        public static IDictionary<string, string> ToDictionary<T>(this object source)
        {
            if (source == null)
                ThrowExceptionWhenSourceArgumentIsNull();

            var dictionary = new Dictionary<string, string>();
            foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(source))
                AddPropertyToDictionary<T>(property, source, dictionary);

            return dictionary;
        }

        private static void AddPropertyToDictionary<T>(PropertyDescriptor property, object source, Dictionary<string, string> dictionary)
        {
            object value = property.GetValue(source);

            string stval = value.ToString();

            //if (property.PropertyType == typeof(String) || property.PropertyType == typeof(Int32) )
            //    {
            //    stval=value.ToString();
            //}

            //if (property.PropertyType)
            //{
            //    stval = value.ToString();
            //}

            //if (property.PropertyType == typeof(List<>))
            //{
            //    stval = value.ToString();
            //}

            // if (IsOfType<T>(value))
            dictionary.Add(property.Name, stval);
        }

        private static bool IsOfType<T>(object value)
        {
            return value is T;
        }

        private static void ThrowExceptionWhenSourceArgumentIsNull()
        {
            throw new ArgumentNullException("source", "Unable to convert object to a dictionary. The source object is null.");
        }
    }


    class ConversionofDictionaryObject
    {

        static void Main()
        {

            FullTimeEmployee ft = new FullTimeEmployee();
            ft.FirstName = "Muruganantham";
            ft.SecondName = "D";
            ft.ID = 10000;
            Console.WriteLine(ft.FullName());
            Console.WriteLine(ft.GetSalaray());

            List<string> sfd = new List<string>();

            sfd.Add("a");
            sfd.Add("b");

            ft.listvar = sfd;
            IDictionary<string, string> dtva = ObjectToDictionaryHelper.ToDictionary<FullTimeEmployee>(ft);
            //var fff= ObjectToDictionaryHelper.ToDictionary<FullTimeEmployee>(ft);

            var dtva1 = ObjectToDictionaryHelper.ToDictionary<FullTimeEmployee>(ft);

            Dictionary<string, string> dtva2 = new Dictionary<string, string>();

            foreach(var ob in dtva)
            {
                dtva2.Add(ob.Key, ob.Value);
            }


                //ConversionofDictionaryObject.CastFrom(JsonConvert.SerializeObject(ft));


            //foreach(var obj in ft.GetType().GetProperties())
            //{

            //    //Console.WriteLine("Key = {0}, Value = {1}",  obj.Name, obj.GetValue();
            //    //var a = new KeyValuePair<string, string>(obj.Name, obj.GetValue(ft.ID.GetType(), null));


            //    dtva.Add(a.Key.ToString(),a.Value.ToString());


            //   // dtva.Add(new KeyValuePair<string, string>(obj.Name.ToString(), "ii"));
            //}

            Console.ReadLine();

        }


        //public static KeyValuePair<object, object> Cast<K, V>(this KeyValuePair<K, V> kvp)
        //{
        //    return new KeyValuePair<object, object>(kvp.Key, kvp.Value);
        //}

        public static KeyValuePair<T, V> CastFrom<T, V>(Object obj)
        {
            return (KeyValuePair<T, V>)obj;
        }

        public static KeyValuePair<object, object> CastFrom(Object obj)
        {
            var type = obj.GetType();
            if (type.IsGenericType)
            {
                if (type == typeof(KeyValuePair<,>))
                {
                    var key = type.GetProperty("Key");
                    var value = type.GetProperty("Value");
                    var keyObj = key.GetValue(obj, null);
                    var valueObj = value.GetValue(obj, null);
                    return new KeyValuePair<object, object>(keyObj, valueObj);
                }
            }
            throw new ArgumentException(" ### -> public static KeyValuePair<object , object > CastFrom(Object obj) :   Error: obj argument must be KeyValuePair <,> ");
        }


        public static IEnumerable<KeyValuePair<string, T>> PropertiesOfType<T>(object obj)
        {
            //var kk = obj.GetType().GetProperties();
            //var tt = kk.GetType();
            //var valll = (kk.GetType())(kk.GetValue(kk.GetType()));


            var pv = from p in obj.GetType().GetProperties()
                     where p.PropertyType == typeof(T)
                     select p.PropertyType;

            var kk= from p in obj.GetType().GetProperties()
                   where p.PropertyType == typeof(T)
                   select new KeyValuePair<string, T>(p.Name, (T)p.GetValue(obj));

            return kk;
        }
        public static IEnumerable<KeyValuePair<string, string>> StringProperties(object obj)
        {
            return from p in obj.GetType().GetProperties()
                   where p.PropertyType == typeof(string)
                   select new KeyValuePair<string, string>(p.Name, (string)p.GetValue(obj));
        }
    }
}
