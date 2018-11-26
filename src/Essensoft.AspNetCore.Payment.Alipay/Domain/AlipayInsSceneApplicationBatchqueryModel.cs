using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneApplicationBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneApplicationBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 投保人
        /// </summary>
        [JsonProperty("applicant")]
        [XmlElement("applicant")]
        public InsPerson Applicant { get; set; }

        /// <summary>
        /// 商户生成的外部投保业务号
        /// </summary>
        [JsonProperty("out_biz_no")]
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 渠道来源
        /// </summary>
        [JsonProperty("source")]
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
