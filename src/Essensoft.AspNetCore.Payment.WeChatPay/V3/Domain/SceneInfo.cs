using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 支付场景描述
    /// </summary>       
    public class SceneInfo : WeChatPayObject
    {
        /// <summary>
        /// 用户终端IP
        /// 调用微信支付API的机器IP，支持IPv4和IPv4两种格式的IP地址。
        /// 示例值：14.23.150.211
        /// </summary>
        [JsonPropertyName("payer_client_ip")]
        public string PayerClientIp { get; set; }

        /// <summary>
        /// 商户端设备号
        /// 商户端设备号（门店号或收银设备ID）。
        /// 示例值：013467007045764
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 商户门店信息
        /// 商户门店信息
        /// </summary>
        [JsonPropertyName("store_info")]
        public StoreInfo StoreInfo { get; set; }
    }
}
