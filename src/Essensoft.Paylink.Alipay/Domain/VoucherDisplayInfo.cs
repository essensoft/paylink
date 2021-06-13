using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// VoucherDisplayInfo Data Structure.
    /// </summary>
    public class VoucherDisplayInfo : AlipayObject
    {
        /// <summary>
        /// 商户品牌名称。  如果不设置品牌名称，则默认使用支付宝商家系统中维护的商家别名。  如果没有维护商家别名，则使用默认名称：  商家优惠。  用户领取优惠券后，品牌名称会对用户进行展示
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 券详细使用说明。
        /// </summary>
        [JsonPropertyName("voucher_description")]
        public string VoucherDescription { get; set; }
    }
}
