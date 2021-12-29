using System.Collections.Generic;

namespace Essensoft.Paylink.WeChatPay
{
    public class WeChatPayDictionary : SortedDictionary<string, string>
    {
        public WeChatPayDictionary() { }

        public WeChatPayDictionary(IDictionary<string, string> dictionary)
            : base(dictionary)
        { }

        public void Add(string key, object value)
        {
            string strValue;

            if (value == null)
            {
                return;
            }
            else if (value is string str)
            {
                strValue = str;
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
            else if (value is V2.WeChatPaySignType)
            {
                strValue = value switch
                {
                    V2.WeChatPaySignType.MD5 => WeChatPayConsts.MD5,
                    V2.WeChatPaySignType.HMAC_SHA256 => WeChatPayConsts.HMAC_SHA256,
                    _ => throw new WeChatPayException("未知签名类型！")
                };
            }
            else
            {
                strValue = value.ToString();
            }

            if (!string.IsNullOrEmpty(strValue))
            {
                base.Add(key, strValue);
            }
        }

        public string GetValue(string key)
        {
            return TryGetValue(key, out var o) ? o : null;
        }

        public string SetValue(string key, string value)
        {
            return this[key] = value;
        }
    }
}
