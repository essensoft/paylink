using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MerchantApplyResultRecord Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantApplyResultRecord : AlipayObject
    {
        /// <summary>
        /// 签约产品名称
        /// </summary>
        [JsonProperty("prod_name")]
        [XmlElement("prod_name")]
        public string ProdName { get; set; }

        /// <summary>
        /// 如审核失败，表示该字段引发的审核失败
        /// </summary>
        [JsonProperty("prop_input_key")]
        [XmlElement("prop_input_key")]
        public string PropInputKey { get; set; }

        /// <summary>
        /// 认证、产品签约审核失败原因
        /// </summary>
        [JsonProperty("result_msg")]
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 认证审核、产品签约审核状态
        /// </summary>
        [JsonProperty("result_status")]
        [XmlElement("result_status")]
        public string ResultStatus { get; set; }

        /// <summary>
        /// 详情类型，CETIFY为认证，PROD为产品签约，COMMENT为认证审核批注
        /// </summary>
        [JsonProperty("result_type")]
        [XmlElement("result_type")]
        public string ResultType { get; set; }
    }
}
