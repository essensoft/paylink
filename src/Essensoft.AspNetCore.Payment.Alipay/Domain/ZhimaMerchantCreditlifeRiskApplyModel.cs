using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantCreditlifeRiskApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantCreditlifeRiskApplyModel : AlipayObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [JsonProperty("address")]
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 证件号，一般为身份证号码
        /// </summary>
        [JsonProperty("cert_no")]
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 接入信用套餐所分配的产品码
        /// </summary>
        [JsonProperty("item_id")]
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 手机联系方式
        /// </summary>
        [JsonProperty("mobile")]
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 业务流水号，每一笔业务使用一个新的业务流水号，不能重复
        /// </summary>
        [JsonProperty("transaction_id")]
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }
    }
}
