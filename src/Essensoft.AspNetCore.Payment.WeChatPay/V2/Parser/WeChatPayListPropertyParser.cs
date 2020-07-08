using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Parser
{
    public static class WeChatPayListPropertyParser
    {
        public static List<T> Parse<T>(WeChatPayDictionary dictionary) where T : new()
        {
            var list = new List<T>();
            var properties = typeof(T).GetProperties();
            var keyfirst = properties[0];
            var count = dictionary.Keys.Where(p => Regex.IsMatch(p, $@"{GetKeyName(keyfirst)}_\d")).Count();

            for (var i = 0; i < count; i++)
            {
                var item = new T();
                foreach (var field in properties)
                {
                    var name = $"{GetKeyName(field)}_{i}";
                    var value = dictionary.GetValue(name);
                    if (!string.IsNullOrEmpty(value))
                    {
                        field.SetValue(item, Convert.ChangeType(value, field.PropertyType));
                    }
                }
                list.Add(item);
            }

            return list;
        }

        public static List<T> Parse<T, TChildren>(WeChatPayDictionary dictionary) where T : new() where TChildren : new()
        {
            var list = new List<T>();
            var properties = typeof(T).GetProperties();
            var keyfirst = properties[0];
            var count = dictionary.Keys.Where(p => Regex.IsMatch(p, $@"{GetKeyName(keyfirst)}_\d")).Count();

            for (var i = 0; i < count; i++)
            {
                var item = new T();
                foreach (var field in properties)
                {
                    if (field.PropertyType == typeof(List<TChildren>))
                    {
                        var sublist = new List<TChildren>();
                        var subProperties = typeof(TChildren).GetProperties();
                        var subFirstkey = subProperties[0];
                        var SubFirstName = GetKeyName(subFirstkey);
                        var subCount = dictionary.Keys.Where(p => Regex.IsMatch(p, $@"{SubFirstName}_{i}_\d")).Count();
                        for (var j = 0; j < subCount; j++)
                        {
                            var subItem = new TChildren();
                            foreach (var subfield in subProperties)
                            {
                                var name = $"{GetKeyName(subfield)}_{i}_{j}";
                                var value = dictionary.GetValue(name);
                                if (!string.IsNullOrEmpty(value))
                                {
                                    subfield.SetValue(item, Convert.ChangeType(value, subfield.PropertyType));
                                }
                            }
                            sublist.Add(subItem);
                        }
                        field.SetValue(item, sublist);
                    }
                    else
                    {
                        var name = $"{GetKeyName(field)}_{i}";
                        var value = dictionary.GetValue(name);
                        if (!string.IsNullOrEmpty(value))
                        {
                            field.SetValue(item, Convert.ChangeType(value, field.PropertyType));
                        }
                    }
                }
                list.Add(item);
            }

            return list;
        }

        public static List<T> Parse<T, TChildren>(WeChatPayDictionary dictionary, int index) where T : new() where TChildren : new()
        {
            var flag = true;
            var list = new List<T>();
            var i = 0;
            while (flag)
            {
                var type = typeof(T);
                var obj = new T();
                var properties = type.GetProperties();
                var isFirstProperty = true;

                foreach (var item in properties)
                {
                    if (item.PropertyType == typeof(List<TChildren>))
                    {
                        var chidrenList = Parse<TChildren, object>(dictionary, i);
                        item.SetValue(obj, chidrenList);
                        continue;
                    }

                    var key = GetKeyName(item);
                    if (index > -1)
                    {
                        key += $"_{index}";
                    }
                    key += $"_{i}";

                    var value = dictionary.GetValue(key);
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

                if (!flag)
                {
                    return list;
                }

                list.Add(obj);
                i++;
            }

            return list;
        }

        private static string GetKeyName(PropertyInfo item)
        {
            var key = item.GetCustomAttributes(typeof(XmlElementAttribute), true);
            if (key.Length > 0)
            {
                return ((XmlElementAttribute)key[0]).ElementName;
            }
            else
            {
                throw new WeChatPayException($"{item.Name} undefined key name.");
            }
        }
    }
}
