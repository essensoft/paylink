using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppEbppPdeductCzsignUpgradeResponse.
    /// </summary>
    public class AlipayEbppEbppPdeductCzsignUpgradeResponse : AlipayResponse
    {
        /// <summary>
        /// 错误信息文案
        /// </summary>
        [JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 升级后新的协议ID
        /// </summary>
        [JsonPropertyName("new_agreement_id")]
        public string NewAgreementId { get; set; }

        /// <summary>
        /// 当前更新结果是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
