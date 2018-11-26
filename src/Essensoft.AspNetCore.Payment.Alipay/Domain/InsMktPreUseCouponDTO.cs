using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsMktPreUseCouponDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsMktPreUseCouponDTO : AlipayObject
    {
        /// <summary>
        /// 资产Id
        /// </summary>
        [JsonProperty("asset_id")]
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 权益id
        /// </summary>
        [JsonProperty("coupon_id")]
        [XmlElement("coupon_id")]
        public string CouponId { get; set; }

        /// <summary>
        /// 权益类型
        /// </summary>
        [JsonProperty("coupon_type")]
        [XmlElement("coupon_type")]
        public string CouponType { get; set; }

        /// <summary>
        /// 权益值
        /// </summary>
        [JsonProperty("coupon_value")]
        [XmlElement("coupon_value")]
        public string CouponValue { get; set; }

        /// <summary>
        /// 是否支持预核销
        /// </summary>
        [JsonProperty("pre_use")]
        [XmlElement("pre_use")]
        public bool PreUse { get; set; }

        /// <summary>
        /// 预核销失败原因
        /// </summary>
        [JsonProperty("reason")]
        [XmlElement("reason")]
        public string Reason { get; set; }
    }
}
