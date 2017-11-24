using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Parser
{
    public class AlipayDictionaryParser<T> where T : AlipayObject
    {
        private static readonly Dictionary<string, Dictionary<string, AlipayAttribute>> attrs = new Dictionary<string, Dictionary<string, AlipayAttribute>>();

        public T Parse(IDictionary parameters)
        {
            IAlipayReader reader = new AlipayDictionaryReader(parameters);
            return (T)AlipayDictionaryConvert(reader, typeof(T));
        }

        private static Dictionary<string, AlipayAttribute> GetAlipayAttributes(Type type)
        {
            var inc = attrs.TryGetValue(type.FullName, out var tas);

            if (inc && tas != null) // 从缓存中获取类属性元数据
            {
                return tas;
            }
            else // 创建新的类属性元数据缓存
            {
                tas = new Dictionary<string, AlipayAttribute>();
            }

            var pis = type.GetRuntimeProperties();
            foreach (var pi in pis)
            {
                var ta = new AlipayAttribute()
                {
                    Method = pi.GetSetMethod()
                };

                // 获取对象属性名称
                if (pi.GetCustomAttributes(typeof(JsonPropertyAttribute), true) is JsonPropertyAttribute[] xeas && xeas.Length > 0)
                {
                    ta.ItemName = xeas[0].PropertyName;
                }

                // 获取列表属性名称
                //if (ta.ItemName == null)
                //{
                //    if (pi.GetCustomAttributes(typeof(JsonPropertyItemAttribute), true) is JsonPropertyItemAttribute[] xaias && xaias.Length > 0)
                //    {
                //        ta.ItemName = xaias[0].ElementName;
                //    }
                //    if (pi.GetCustomAttributes(typeof(JsonPropertyAttribute), true) is JsonPropertyAttribute[] xaas && xaas.Length > 0)
                //    {
                //        ta.ListName = xaas[0].ElementName;
                //    }
                //    if (ta.ListName == null)
                //    {
                //        continue;
                //    }
                //}

                // 获取属性类型
                if (pi.PropertyType.IsConstructedGenericType)
                {
                    var types = pi.PropertyType.GenericTypeArguments;
                    ta.ListType = types[0];
                }
                else
                {
                    ta.ItemType = pi.PropertyType;
                }

                tas.Add(pi.Name + ta.ItemType + ta.ListType, ta);
            }

            attrs[type.FullName] = tas;
            return tas;
        }

        protected static readonly DAlipayConvert AlipayDictionaryConvert = delegate (IAlipayReader reader, Type type)
        {
            object rsp = null;
            var pas = GetAlipayAttributes(type);

            var em = pas.GetEnumerator();
            while (em.MoveNext())
            {
                var kvp = em.Current;
                var ta = kvp.Value;
                var itemName = ta.ItemName;
                var listName = ta.ListName;

                if (!reader.HasReturnField(itemName) && (string.IsNullOrEmpty(listName) || !reader.HasReturnField(listName)))
                {
                    continue;
                }

                object value = null;

                if (typeof(string) == ta.ItemType)
                {
                    var tmp = reader.GetPrimitiveObject(itemName);
                    if (tmp != null)
                    {
                        value = tmp.ToString();
                    }
                }
                else if (typeof(long) == ta.ItemType)
                {
                    var tmp = reader.GetPrimitiveObject(itemName);
                    if (tmp != null)
                    {
                        value = ((IConvertible)tmp).ToInt64(null);
                    }
                }
                else if (typeof(bool) == ta.ItemType)
                {
                    value = reader.GetPrimitiveObject(itemName);
                }
                else
                {
                    value = reader.GetReferenceObject(itemName, ta.ItemType, AlipayDictionaryConvert);
                }

                if (value != null)
                {
                    if (rsp == null)
                    {
                        rsp = Activator.CreateInstance(type);
                    }
                    ta.Method.Invoke(rsp, new object[] { value });
                }
            }

            return rsp;
        };
    }
}
