using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using ArabiaExtensions;
using ArabiaExtensions.Extensions;

namespace ArabiaMvc.Helper
{
    public class ArabiaJavaScriptConverter : JavaScriptConverter
    {
        public override object Deserialize(IDictionary<string, object> dictionary, Type type, JavaScriptSerializer serializer)
        {
            throw new NotImplementedException();
        }


        public override IDictionary<string, object> Serialize(object obj, JavaScriptSerializer serializer)
        {
            if (obj is DateTime)
                return new Dictionary<string, object>() { { "Value", ((DateTime)obj).ToArabiaString() } };
            else
                return new Dictionary<string, object> { { "Value", Helpers.NumberToArabicString(obj.ToString()) } };
        }


        public override IEnumerable<Type> SupportedTypes => new Type[] { typeof(byte), typeof(short), typeof(ushort), typeof(int), typeof(uint), typeof(long), typeof(ulong), typeof(float), typeof(double), typeof(decimal), typeof(DateTime) };
    }
}
