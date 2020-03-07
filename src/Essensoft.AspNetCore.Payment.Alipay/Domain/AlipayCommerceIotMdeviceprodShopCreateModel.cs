using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodShopCreateModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotMdeviceprodShopCreateModel : AlipayObject
    {
        /// <summary>
        /// 西湖区文三路国际大厦
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 创建人PID
        /// </summary>
        [JsonPropertyName("creator_pid")]
        public string CreatorPid { get; set; }

        /// <summary>
        /// 区县
        /// </summary>
        [JsonPropertyName("district")]
        public string District { get; set; }

        /// <summary>
        /// {"key":"value"}
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 行业类目
        /// </summary>
        [JsonPropertyName("industry_category")]
        public string IndustryCategory { get; set; }

        /// <summary>
        /// 门店商户PID
        /// </summary>
        [JsonPropertyName("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [JsonPropertyName("province")]
        public string Province { get; set; }

        /// <summary>
        /// 虚拟门店名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店属性
        /// </summary>
        [JsonPropertyName("shop_property")]
        public string ShopProperty { get; set; }

        /// <summary>
        /// 门店类型
        /// </summary>
        [JsonPropertyName("shop_type")]
        public string ShopType { get; set; }
    }
}
