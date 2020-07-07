using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 合单下单支付场景描述
    /// </summary>       
    public class CombineSceneInfoResponse : WeChatPayObject
    {
        /// <summary>
        /// 商户端设备号
        /// 终端设备号（门店号或收银设备ID） 。
        /// 特殊规则：长度最小7个字节
        /// 示例值：POS1:1
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }
    }
}
