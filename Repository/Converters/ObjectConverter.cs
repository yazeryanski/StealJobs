using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Converters
{
    public class ObjectConverter<TSource, TTarget>
    {
        public static TTarget Convert(TSource obj)
        {
            var retObj = Activator.CreateInstance(typeof(TTarget));

            var sourceType = obj.GetType();
            var targetType = retObj.GetType();

            foreach (var item in targetType.GetProperties())
            {
                var sourceProp = sourceType.GetProperty(item.Name);

                if (sourceProp != null)
                    item.SetValue(retObj, sourceType.GetProperty(item.Name).GetValue(obj));
            }

            return (TTarget)retObj;
        }
    }
}
