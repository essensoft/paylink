using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserGroupbuyingSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserGroupbuyingSyncModel : AlipayObject
    {
        /// <summary>
        /// 拼团结束时间的timestamp
        /// </summary>
        [JsonProperty("group_expire")]
        public string GroupExpire { get; set; }

        /// <summary>
        /// 相关拼团的Id
        /// </summary>
        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 1688处的用户havanaId
        /// </summary>
        [JsonProperty("havana_id")]
        public string HavanaId { get; set; }

        /// <summary>
        /// 1688处商品Id
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }
    }
}
