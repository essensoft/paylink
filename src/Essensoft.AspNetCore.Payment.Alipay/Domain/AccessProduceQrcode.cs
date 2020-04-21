using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AccessProduceQrcode Data Structure.
    /// </summary>
    public class AccessProduceQrcode : AlipayObject
    {
        /// <summary>
        /// 口碑码批次号
        /// </summary>
        [JsonPropertyName("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 码url
        /// </summary>
        [JsonPropertyName("core_url")]
        public string CoreUrl { get; set; }

        /// <summary>
        /// 生产单号
        /// </summary>
        [JsonPropertyName("produce_order_id")]
        public string ProduceOrderId { get; set; }

        /// <summary>
        /// 二维码编码
        /// </summary>
        [JsonPropertyName("qrcode")]
        public string Qrcode { get; set; }
    }
}
