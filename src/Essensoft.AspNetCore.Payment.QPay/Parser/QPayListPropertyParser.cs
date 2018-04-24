using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.QPay.Parser
{
    public class QPayListPropertyParser
    {
        public List<T> Parse<T, TChildren>(QPayDictionary dic, int index = -1)
        {
            var flag = true;
            var list = new List<T>();
            var i = 0;

            while (flag)
            {
                var type = typeof(T);
                var obj = Activator.CreateInstance(type);
                var properties = type.GetProperties();
                var isFirstProperty = true;

                foreach (var item in properties)
                {
                    if (item.PropertyType == typeof(List<TChildren>))
                    {
                        var chidrenList = Parse<TChildren, object>(dic, i);
                        item.SetValue(obj, chidrenList);
                        continue;
                    }

                    var renameAttribute = item.GetCustomAttributes(typeof(XmlElementAttribute), true);
                    if (renameAttribute.Length > 0)
                    {
                        var key = ((XmlElementAttribute)renameAttribute[0]).ElementName;

                        if (index > -1)
                        {
                            key += $"_{index}";
                        }
                        key += $"_{i}";

                        var value = dic.GetValue(key);
                        if (value == null)
                        {
                            if (isFirstProperty)
                            {
                                flag = false;
                                break;
                            }
                            continue;
                        }

                        isFirstProperty = false;
                        item.SetValue(obj, Convert.ChangeType(value, item.PropertyType));
                    }
                }

                if (!flag)
                {
                    return list;
                }

                list.Add((T)obj);
                i++;
            }

            return list;
        }
    }
}