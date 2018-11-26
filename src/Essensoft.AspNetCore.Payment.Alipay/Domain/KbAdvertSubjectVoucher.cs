using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertSubjectVoucher Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertSubjectVoucher : AlipayObject
    {
        /// <summary>
        /// 品牌名称(支持模糊匹配)
        /// </summary>
        [JsonProperty("brand_name")]
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 适用城市(命中一个即可搜出)
        /// </summary>
        [JsonProperty("city_ids")]
        [XmlArray("city_ids")]
        [XmlArrayItem("string")]
        public List<string> CityIds { get; set; }

        /// <summary>
        /// 商家名称(支持模糊匹配)
        /// </summary>
        [JsonProperty("merchant_name")]
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// OBTAIN：认领（默认值）  BUY：购买
        /// </summary>
        [JsonProperty("purchase_mode")]
        [XmlElement("purchase_mode")]
        public string PurchaseMode { get; set; }

        /// <summary>
        /// 券ID
        /// </summary>
        [JsonProperty("voucher_id")]
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 券名称(支持模糊匹配)
        /// </summary>
        [JsonProperty("voucher_name")]
        [XmlElement("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// 券类型  LIMIT-单品券  NO_LIMIT_DISCOUNT-全场折扣券  NO_LIMIT_CASH-全场代金券
        /// </summary>
        [JsonProperty("voucher_type")]
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }
    }
}
