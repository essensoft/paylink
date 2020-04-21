using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEprintActionNotifyModel Data Structure.
    /// </summary>
    public class AlipayEcoEprintActionNotifyModel : AlipayObject
    {
        /// <summary>
        /// 签名
        /// </summary>
        [JsonPropertyName("eprint_sign")]
        public string EprintSign { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        [JsonPropertyName("machine_code")]
        public string MachineCode { get; set; }

        /// <summary>
        /// 授权类型：0=自有应用授权、1=开放应用授权
        /// </summary>
        [JsonPropertyName("oauth_type")]
        public long OauthType { get; set; }

        /// <summary>
        /// 云平台订单ID
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 回调时间
        /// </summary>
        [JsonPropertyName("push_time")]
        public string PushTime { get; set; }

        /// <summary>
        /// 按键行为 0=拒单 1=接单
        /// </summary>
        [JsonPropertyName("state")]
        public long State { get; set; }
    }
}
