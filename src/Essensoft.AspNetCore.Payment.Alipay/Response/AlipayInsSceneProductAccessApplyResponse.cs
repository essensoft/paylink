using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneProductAccessApplyResponse.
    /// </summary>
    public class AlipayInsSceneProductAccessApplyResponse : AlipayResponse
    {
        /// <summary>
        /// true 表示可以准入， false表示不可以准入。  当准入结果为false的时候需要提示用户当前不能购买该产品
        /// </summary>
        [JsonPropertyName("is_access")]
        public bool IsAccess { get; set; }

        /// <summary>
        /// 产品信息(保险标准查询信息)
        /// </summary>
        [JsonPropertyName("product")]
        public InsProduct Product { get; set; }

        /// <summary>
        /// 不准入原因，该原因为统一的风控原因，用于上游日志使用，不能直接提示给用户，建议给用户的提示文案和蚂蚁PD沟通后给出。  该字段在系统异常的情况下为空
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
