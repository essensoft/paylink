using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodShopCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotMdeviceprodShopCreateModel : AlipayObject
    {
        /// <summary>
        /// 西湖区文三路国际大厦
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// 创建人PID
        /// </summary>
        [JsonProperty("creator_pid")]
        public string CreatorPid { get; set; }

        /// <summary>
        /// 区县
        /// </summary>
        [JsonProperty("district")]
        public string District { get; set; }

        /// <summary>
        /// {"key":"value"}
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 行业类目
        /// </summary>
        [JsonProperty("industry_category")]
        public string IndustryCategory { get; set; }

        /// <summary>
        /// 门店商户PID
        /// </summary>
        [JsonProperty("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [JsonProperty("province")]
        public string Province { get; set; }

        /// <summary>
        /// 虚拟门店名称
        /// </summary>
        [JsonProperty("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店属性
        /// </summary>
        [JsonProperty("shop_property")]
        public string ShopProperty { get; set; }

        /// <summary>
        /// 门店类型
        /// </summary>
        [JsonProperty("shop_type")]
        public string ShopType { get; set; }
    }
}
