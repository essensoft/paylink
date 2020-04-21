using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppOrderItemCreateModel Data Structure.
    /// </summary>
    public class AlipayEbppOrderItemCreateModel : AlipayObject
    {
        /// <summary>
        /// 预创单失效时间，此时间点后不允许再支付。  格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("expire_at")]
        public string ExpireAt { get; set; }

        /// <summary>
        /// 需要创建的订单子项
        /// </summary>
        [JsonPropertyName("item_to_create")]
        public EbppOrderItemToCreate ItemToCreate { get; set; }

        /// <summary>
        /// 要求创建支付宝二维码，可供用户扫码后直接支付.  默认值为false
        /// </summary>
        [JsonPropertyName("qrcode_required")]
        public bool QrcodeRequired { get; set; }
    }
}
