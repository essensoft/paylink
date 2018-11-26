using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAuthUserinfoApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAuthUserinfoApplyModel : AlipayObject
    {
        /// <summary>
        /// 业务号
        /// </summary>
        [JsonProperty("biz_no")]
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonProperty("biz_type")]
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 扩展数据
        /// </summary>
        [JsonProperty("ext_data")]
        [XmlElement("ext_data")]
        public string ExtData { get; set; }
    }
}
