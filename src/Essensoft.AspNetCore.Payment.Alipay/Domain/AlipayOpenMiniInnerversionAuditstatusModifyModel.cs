using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionAuditstatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionAuditstatusModifyModel : AlipayObject
    {
        /// <summary>
        /// 小程序版本
        /// </summary>
        [JsonProperty("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 审核结果描述
        /// </summary>
        [JsonProperty("audit_memo")]
        public string AuditMemo { get; set; }

        /// <summary>
        /// 审核结果
        /// </summary>
        [JsonProperty("audit_result")]
        public string AuditResult { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonProperty("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
