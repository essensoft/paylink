using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AgentOrganization Data Structure.
    /// </summary>
    [Serializable]
    public class AgentOrganization : AlipayObject
    {
        /// <summary>
        /// 经代下面二级商户id
        /// </summary>
        [JsonProperty("agent_merchant_id")]
        public string AgentMerchantId { get; set; }

        /// <summary>
        /// 代理机构(ISV)蚂蚁编码，组织入驻蚂蚁生成的cid
        /// </summary>
        [JsonProperty("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 代理机构(ISV)蚂蚁全称,组织入驻蚂蚂蚁的全称
        /// </summary>
        [JsonProperty("cid_name")]
        public string CidName { get; set; }
    }
}
