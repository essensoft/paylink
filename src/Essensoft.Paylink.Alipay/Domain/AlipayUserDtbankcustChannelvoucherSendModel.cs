using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayUserDtbankcustChannelvoucherSendModel Data Structure.
    /// </summary>
    public class AlipayUserDtbankcustChannelvoucherSendModel : AlipayObject
    {
        /// <summary>
        /// 数字分行活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 登录ID 支付宝用户ID 。user_id, logon_id不能同时为空，优先级依次降低
        /// </summary>
        [JsonPropertyName("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝用户ID 。user_id, logon_id不能同时为空，优先级依次降低
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
