using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RecruitShopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitShopInfo : AlipayObject
    {
        /// <summary>
        /// 已确认还是未确认
        /// </summary>
        [JsonProperty("confirm_status")]
        [XmlElement("confirm_status")]
        public string ConfirmStatus { get; set; }

        /// <summary>
        /// 一级和二级类目名称
        /// </summary>
        [JsonProperty("shop_category")]
        [XmlElement("shop_category")]
        public string ShopCategory { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [JsonProperty("shop_id")]
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [JsonProperty("shop_name")]
        [XmlElement("shop_name")]
        public string ShopName { get; set; }
    }
}
