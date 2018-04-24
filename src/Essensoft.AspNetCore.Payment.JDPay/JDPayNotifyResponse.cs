using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.JDPay
{
    public abstract class JDPayNotifyResponse : JDPayResponse
    {
        /// <summary>
        /// 原始参数
        /// </summary>
        [XmlIgnore]
        public JDPayDictionary Parameters { get; internal set; }
    }
}
