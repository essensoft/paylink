using System;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.QPay
{
    [Serializable]
    public abstract class QPayObject
    {
        /// <summary>
        /// 原始内容
        /// </summary>
        [XmlIgnore]
        public string ResponseBody { get; set; }

        /// <summary>
        /// 原始参数
        /// </summary>
        [XmlIgnore]
        public QPayDictionary ResponseParameters { get; internal set; }

        /// <summary>
        /// 处理 _$n
        /// </summary>
        internal virtual void Execute() { }
    }
}
