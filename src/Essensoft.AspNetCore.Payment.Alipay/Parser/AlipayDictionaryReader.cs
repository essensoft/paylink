using System;
using System.Collections;

namespace Essensoft.AspNetCore.Payment.Alipay.Parser
{
    public class AlipayDictionaryReader : IAlipayReader
    {
        private IDictionary dictionary;

        public AlipayDictionaryReader(IDictionary dictionary)
        {
            this.dictionary = dictionary;
        }

        public bool HasReturnField(object name)
        {
            return dictionary.Contains(name);
        }

        public object GetPrimitiveObject(object name)
        {
            return dictionary[name];
        }

        public object GetReferenceObject(object name, Type type, DAlipayConvert convert)
        {
            if (dictionary[name] is IDictionary dict && dict.Count > 0)
            {
                return convert(new AlipayDictionaryReader(dict), type);
            }
            else
            {
                return null;
            }
        }

        public IList GetListObjects(string listName, string itemName, Type type, DAlipayConvert convert)
        {
            throw new NotImplementedException();
        }
    }
}
