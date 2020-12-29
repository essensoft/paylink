using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCcmAgentGetModel Data Structure.
    /// </summary>
    public class AlipayIserviceCcmAgentGetModel : AlipayObject
    {
        /// <summary>
        /// 客服账号id，当user_channel=ALIPAY时，此id为支付宝2088id external_user_id和user_channel必须配对使用
        /// </summary>
        [JsonPropertyName("external_user_id")]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// 客服id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 客服工号
        /// </summary>
        [JsonPropertyName("job_number")]
        public string JobNumber { get; set; }

        /// <summary>
        /// 客服账号渠道, ALIPAY:支付宝账号 user_channel和external_user_id必须配对使用
        /// </summary>
        [JsonPropertyName("user_channel")]
        public string UserChannel { get; set; }
    }
}
