using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInstserviceMessageNotifyResponse.
    /// </summary>
    public class AlipayEbppInstserviceMessageNotifyResponse : AlipayResponse
    {
        /// <summary>
        /// 机构传入的手机号，户号，卡号等
        /// </summary>
        [JsonPropertyName("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 通知结果状态，S/F 成功/失败
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
