using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2
{
    /// <summary>
    /// WeChatPay V2 响应对象
    /// </summary>
    public abstract class WeChatPayResponse : WeChatPayObject
    {
        /// <summary>
        /// 原始内容
        /// </summary>
        [XmlIgnore]
        public string Body { get; set; }

        /// <summary>
        /// 原始参数
        /// </summary>
        [XmlIgnore]
        public WeChatPayDictionary Parameters { get; internal set; }

        /// <summary>
        /// 处理 _$n / _$n_$m
        /// </summary>
        internal virtual void Execute() { }
    }
}
