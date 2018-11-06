using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransAacollectBatchCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransAacollectBatchCloseModel : AlipayObject
    {
        /// <summary>
        /// 批次号
        /// </summary>
        [JsonProperty("batch_no")]
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 创建批次返回 的token
        /// </summary>
        [JsonProperty("batch_token")]
        [XmlElement("batch_token")]
        public string BatchToken { get; set; }

        /// <summary>
        /// 当前支付宝用户id
        /// </summary>
        [JsonProperty("current_user_id")]
        [XmlElement("current_user_id")]
        public string CurrentUserId { get; set; }
    }
}
