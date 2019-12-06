using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionAuditstatusModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerversionAuditstatusModifyModel : AlipayObject
    {
        /// <summary>
        /// 小程序版本
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 审核结果描述
        /// </summary>
        [JsonPropertyName("audit_memo")]
        public string AuditMemo { get; set; }

        /// <summary>
        /// 审核结果
        /// </summary>
        [JsonPropertyName("audit_result")]
        public string AuditResult { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
