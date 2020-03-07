using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserCertifyOpenQueryResponse.
    /// </summary>
    public class AlipayUserCertifyOpenQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 认证错误原因，扩展字段，默认不返回
        /// </summary>
        [JsonPropertyName("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 认证的主体信息，一般的认证场景返回为空
        /// </summary>
        [JsonPropertyName("identity_info")]
        public string IdentityInfo { get; set; }

        /// <summary>
        /// 认证主体附件信息，主要为图片类材料，一般的认证场景都是返回空
        /// </summary>
        [JsonPropertyName("material_info")]
        public string MaterialInfo { get; set; }

        /// <summary>
        /// 是否通过，通过为T，不通过为F
        /// </summary>
        [JsonPropertyName("passed")]
        public List<string> Passed { get; set; }
    }
}
