using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AgentOrganization Data Structure.
    /// </summary>
    public class AgentOrganization : AlipayObject
    {
        /// <summary>
        /// 经代下面二级商户id
        /// </summary>
        [JsonPropertyName("agent_merchant_id")]
        public string AgentMerchantId { get; set; }

        /// <summary>
        /// 代理机构(ISV)蚂蚁编码，组织入驻蚂蚁生成的cid
        /// </summary>
        [JsonPropertyName("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 代理机构(ISV)蚂蚁全称,组织入驻蚂蚂蚁的全称
        /// </summary>
        [JsonPropertyName("cid_name")]
        public string CidName { get; set; }
    }
}
