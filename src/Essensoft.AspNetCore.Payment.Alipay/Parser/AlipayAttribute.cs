using System;
using System.Reflection;

namespace Essensoft.AspNetCore.Payment.Alipay.Parser
{
    public class AlipayAttribute
    {
        public string ItemName { get; set; }
        public Type ItemType { get; set; }
        public string ListName { get; set; }
        public Type ListType { get; set; }
        public MethodInfo Method { get; set; }
    }
}
