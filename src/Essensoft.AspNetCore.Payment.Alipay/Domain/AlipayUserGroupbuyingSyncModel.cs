using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserGroupbuyingSyncModel Data Structure.
    /// </summary>
    public class AlipayUserGroupbuyingSyncModel : AlipayObject
    {
        /// <summary>
        /// 拼团结束时间的timestamp
        /// </summary>
        [JsonPropertyName("group_expire")]
        public string GroupExpire { get; set; }

        /// <summary>
        /// 相关拼团的Id
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 1688处的用户havanaId
        /// </summary>
        [JsonPropertyName("havana_id")]
        public string HavanaId { get; set; }

        /// <summary>
        /// 1688处商品Id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }
    }
}
