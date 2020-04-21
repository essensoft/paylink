using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotGroupMemberBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotGroupMemberBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 分组id
        /// </summary>
        [JsonPropertyName("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [JsonPropertyName("limit")]
        public string Limit { get; set; }

        /// <summary>
        /// 分页搜索偏移值
        /// </summary>
        [JsonPropertyName("offset")]
        public long Offset { get; set; }
    }
}
