using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CarRentalMerchantInfo Data Structure.
    /// </summary>
    public class CarRentalMerchantInfo : AlipayObject
    {
        /// <summary>
        /// 品牌名称
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 品牌统一的服务电话
        /// </summary>
        [JsonPropertyName("merchant_contact")]
        public string MerchantContact { get; set; }

        /// <summary>
        /// 直连商户id
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 间联商户
        /// </summary>
        [JsonPropertyName("smid")]
        public string Smid { get; set; }
    }
}
