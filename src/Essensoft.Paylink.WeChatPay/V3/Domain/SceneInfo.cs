using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 场景信息
    /// </summary>       
    public class SceneInfo : WeChatPayObject
    {
        /// <summary>
        /// 用户终端IP
        /// </summary>
        /// <remarks>
        /// 调用微信支付API的机器IP，支持IPv4和IPv6两种格式的IP地址。
        /// <para>示例值：14.23.150.211</para>
        /// </remarks>
        [JsonPropertyName("payer_client_ip")]
        public string PayerClientIp { get; set; }

        /// <summary>
        /// 商户端设备号
        /// </summary>
        /// <remarks>
        /// 商户端设备号（门店号或收银设备ID）。
        /// <para>示例值：013467007045764</para>
        /// </remarks>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 商户门店信息
        /// </summary>
        /// <remarks>
        /// 商户门店信息
        /// </remarks>
        [JsonPropertyName("store_info")]
        public StoreInfo StoreInfo { get; set; }
    }
}
