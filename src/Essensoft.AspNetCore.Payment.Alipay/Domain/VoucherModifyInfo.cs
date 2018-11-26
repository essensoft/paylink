using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VoucherModifyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherModifyInfo : AlipayObject
    {
        /// <summary>
        /// 追加的适用门店
        /// </summary>
        [JsonProperty("suitable_shops")]
        [XmlArray("suitable_shops")]
        [XmlArrayItem("string")]
        public List<string> SuitableShops { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("voucher_desc")]
        [XmlElement("voucher_desc")]
        public string VoucherDesc { get; set; }

        /// <summary>
        /// 券id
        /// </summary>
        [JsonProperty("voucher_id")]
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [JsonProperty("voucher_name")]
        [XmlElement("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// 使用须知
        /// </summary>
        [JsonProperty("voucher_terms")]
        [XmlArray("voucher_terms")]
        [XmlArrayItem("voucher_term_info")]
        public List<VoucherTermInfo> VoucherTerms { get; set; }
    }
}
