using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 合单下单H5支付场景描述
    /// </summary>       
    public class CombineH5SceneInfo : WeChatPayObject
    {
        /// <summary>
        /// 商户端设备号
        /// </summary>
        /// <remarks>
        /// 终端设备号（门店号或收银设备ID）。
        /// 特殊规则：长度最小7个字节
        /// <para>示例值：POS1:1</para>
        /// </remarks>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 用户终端IP
        /// </summary>
        /// <remarks>
        /// 格式: ip(ipv4+ipv6)
        /// <para>示例值：14.17.22.32</para>
        /// </remarks>
        [JsonPropertyName("payer_client_ip")]
        public string PayerClientIp { get; set; }

        /// <summary>
        /// H5场景信息
        /// </summary>
        /// <remarks>
        /// H5场景信息
        /// </remarks>
        [JsonPropertyName("h5_info")]
        public H5Info H5Info { get; set; }
    }
}
