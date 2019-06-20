using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FaceMerchantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FaceMerchantInfo : AlipayObject
    {
        /// <summary>
        /// 区域编码
        /// </summary>
        [JsonProperty("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 品牌编码
        /// </summary>
        [JsonProperty("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 机具Mac地址
        /// </summary>
        [JsonProperty("device_mac")]
        public string DeviceMac { get; set; }

        /// <summary>
        /// 机具编码
        /// </summary>
        [JsonProperty("device_num")]
        public string DeviceNum { get; set; }

        /// <summary>
        /// 经纬度
        /// </summary>
        [JsonProperty("geo")]
        public string Geo { get; set; }

        /// <summary>
        /// 机具分组编码
        /// </summary>
        [JsonProperty("group")]
        public string Group { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonProperty("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// ISV ID
        /// </summary>
        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 门店编码
        /// </summary>
        [JsonProperty("store_code")]
        public string StoreCode { get; set; }

        /// <summary>
        /// WI-FI Mac地址
        /// </summary>
        [JsonProperty("wifimac")]
        public string Wifimac { get; set; }

        /// <summary>
        /// WI-FI 名称
        /// </summary>
        [JsonProperty("wifiname")]
        public string Wifiname { get; set; }
    }
}
