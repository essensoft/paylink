using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// QrCodeBusinessParam Data Structure.
    /// </summary>
    public class QrCodeBusinessParam : AlipayObject
    {
        /// <summary>
        /// 商户PID
        /// </summary>
        [JsonPropertyName("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 商户SMID
        /// </summary>
        [JsonPropertyName("merchant_smid")]
        public string MerchantSmid { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [JsonPropertyName("merhcant_name")]
        public string MerhcantName { get; set; }

        /// <summary>
        /// 门店地址
        /// </summary>
        [JsonPropertyName("shop_address")]
        public string ShopAddress { get; set; }

        /// <summary>
        /// 商户支付宝门店编号
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 商户门店编号
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [JsonPropertyName("store_name")]
        public string StoreName { get; set; }
    }
}
