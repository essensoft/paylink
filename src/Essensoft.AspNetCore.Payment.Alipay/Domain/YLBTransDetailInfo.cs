using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// YLBTransDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class YLBTransDetailInfo : AlipayObject
    {
        /// <summary>
        /// 余利宝交易金额，单位为元
        /// </summary>
        [JsonProperty("amount")]
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        [JsonProperty("biz_no")]
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("memo")]
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 交易到账时间
        /// </summary>
        [JsonProperty("trans_account_date")]
        [XmlElement("trans_account_date")]
        public string TransAccountDate { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [JsonProperty("trans_date")]
        [XmlElement("trans_date")]
        public string TransDate { get; set; }

        /// <summary>
        /// 交易名称，如正常申购、正常赎回、收益发放、份额强增、份额强减
        /// </summary>
        [JsonProperty("trans_name")]
        [XmlElement("trans_name")]
        public string TransName { get; set; }

        /// <summary>
        /// 交易状态，如success-成功、failure-失败、inprocess-进行中等
        /// </summary>
        [JsonProperty("trans_status")]
        [XmlElement("trans_status")]
        public string TransStatus { get; set; }

        /// <summary>
        /// 交易类型，如正常申购、正常赎回、收益发放、份额强增、份额强减
        /// </summary>
        [JsonProperty("trans_type")]
        [XmlElement("trans_type")]
        public string TransType { get; set; }
    }
}
