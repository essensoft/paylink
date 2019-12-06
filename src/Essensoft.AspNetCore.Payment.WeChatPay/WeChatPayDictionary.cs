using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public class WeChatPayDictionary : SortedDictionary<string, string>
    {
        public WeChatPayDictionary() { }

        public WeChatPayDictionary(IDictionary<string, string> dictionary)
            : base(dictionary)
        { }

        public void Add(string key, int value)
        {
            Add(key, value.ToString());
        }

        public void Add(string key, uint value)
        {
            Add(key, value.ToString());
        }

        public void Add(string key, long value)
        {
            Add(key, value.ToString());
        }

        public string GetValue(string key)
        {
            return TryGetValue(key, out var o) ? o : null;
        }

        public string SetValue(string key, string value)
        {
            return base[key] = value;
        }
    }
}
