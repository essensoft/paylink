using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using Essensoft.AspNetCore.Payment.Alipay.Parser;

namespace Essensoft.AspNetCore.Payment.Alipay
{
    public class AlipayDictionary : Dictionary<string, string>
    {
        private const string DATE_TIME_FORMAT = "yyyy-MM-dd HH:mm:ss";

        public AlipayDictionary() { }

        public AlipayDictionary(IDictionary<string, string> dictionary)
            : base(dictionary)
        { }

        /// <summary>
        /// 添加一个新的键值对。空键或者空值的键值对将会被忽略。
        /// </summary>
        /// <param name="key">键名称</param>
        /// <param name="value">键对应的值，目前支持：string, int, long, double, bool, DateTime类型</param>
        public void Add(string key, object value)
        {
            string strValue;

            if (value == null)
            {
                strValue = null;
            }
            else if (value is string str)
            {
                strValue = str;
            }
            else if (value is DateTime?)
            {
                var dateTime = value as DateTime?;
                strValue = dateTime.Value.ToString(DATE_TIME_FORMAT);
            }
            else if (value is int?)
            {
                strValue = (value as int?).Value.ToString();
            }
            else if (value is long?)
            {
                strValue = (value as long?).Value.ToString();
            }
            else if (value is double?)
            {
                strValue = (value as double?).Value.ToString();
            }
            else if (value is bool?)
            {
                strValue = (value as bool?).Value.ToString().ToLowerInvariant();
            }
            else if (value is ICollection)
            {
                strValue = JsonSerializer.Serialize(value, value.GetType(), JsonParser.JsonSerializerOptions);
            }
            else if (value is AlipayObject)
            {
                strValue = JsonSerializer.Serialize(value, value.GetType(), JsonParser.JsonSerializerOptions);
            }
            else
            {
                strValue = value.ToString();
            }

            Add(key, strValue);
        }

        public new void Add(string key, string value)
        {
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
            {
                base.Add(key, value);
            }
        }
    }
}
