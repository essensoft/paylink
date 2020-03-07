using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppOrderItemCreateResponse.
    /// </summary>
    public class AlipayEbppOrderItemCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 已创建的订单子项
        /// </summary>
        [JsonPropertyName("item")]
        public EbppOrderItem Item { get; set; }

        /// <summary>
        /// 用于支付相应订单子项的二维码码串，可以用二维码生成工具根据该码串值生成对应的二维码，用户扫码后会拉起收银台支付。  仅当入参qrcode_required为true时才会返回此参数。
        /// </summary>
        [JsonPropertyName("qr_code")]
        public string QrCode { get; set; }
    }
}
