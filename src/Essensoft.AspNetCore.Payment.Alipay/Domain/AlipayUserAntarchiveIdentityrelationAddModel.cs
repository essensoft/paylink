using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAntarchiveIdentityrelationAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntarchiveIdentityrelationAddModel : AlipayObject
    {
        /// <summary>
        /// 扩展信息,Map格式JSON序列化表示
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 关系业务类型
        /// </summary>
        [JsonProperty("rel_biz_type")]
        public string RelBizType { get; set; }

        /// <summary>
        /// 关系类型
        /// </summary>
        [JsonProperty("rel_type")]
        public string RelType { get; set; }

        /// <summary>
        /// 源身份信息
        /// </summary>
        [JsonProperty("source_identity_certificate")]
        public AntArchiveIdentityCertificate SourceIdentityCertificate { get; set; }

        /// <summary>
        /// 目标身份信息
        /// </summary>
        [JsonProperty("target_identity_certificate")]
        public AntArchiveIdentityCertificate TargetIdentityCertificate { get; set; }
    }
}
