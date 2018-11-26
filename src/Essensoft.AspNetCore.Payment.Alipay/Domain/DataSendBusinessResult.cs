using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DataSendBusinessResult Data Structure.
    /// </summary>
    [Serializable]
    public class DataSendBusinessResult : AlipayObject
    {
        /// <summary>
        /// 数据发送业务处理结果码
        /// </summary>
        [JsonProperty("biz_code")]
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 数据发送业务处理结果描述
        /// </summary>
        [JsonProperty("biz_msg")]
        [XmlElement("biz_msg")]
        public string BizMsg { get; set; }
    }
}
