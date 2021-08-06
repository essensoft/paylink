using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceOperationUnofficialMaterialSubmitModel Data Structure.
    /// </summary>
    public class AlipayCommerceOperationUnofficialMaterialSubmitModel : AlipayObject
    {
        /// <summary>
        /// 在支付宝开放平台中，服务商的pid
        /// </summary>
        [JsonPropertyName("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 支付宝小程序的app id。商家的扫码点餐物料对应的小程序的app id。
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 二维码码值。桌码、台码、电子屏等展示的扫码点餐二维码的码值。
        /// </summary>
        [JsonPropertyName("qr_code_url")]
        public string QrCodeUrl { get; set; }

        /// <summary>
        /// 政策返佣的pid。填写isv在支付宝开放平台的pid。
        /// </summary>
        [JsonPropertyName("rebate_pid")]
        public string RebatePid { get; set; }

        /// <summary>
        /// 商家收单的pid（直连商户id）
        /// </summary>
        [JsonPropertyName("seller_checkout_pid")]
        public string SellerCheckoutPid { get; set; }

        /// <summary>
        /// 商家收单的smid（间联商户id）
        /// </summary>
        [JsonPropertyName("seller_checkout_smid")]
        public string SellerCheckoutSmid { get; set; }

        /// <summary>
        /// 商家的支付宝门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
