using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntfortuneContentCommunityOpenSecuaiQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneContentCommunityOpenSecuaiQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务的请求参数
        /// </summary>
        [JsonProperty("biz_request")]
        public string BizRequest { get; set; }

        /// <summary>
        /// 请求的业务类型
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonProperty("tenant_id")]
        public string TenantId { get; set; }
    }
}
