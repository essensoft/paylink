using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    /// <summary>
    /// WeChatPay 基础对象。
    /// </summary>
    public abstract class WeChatPayObject
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
