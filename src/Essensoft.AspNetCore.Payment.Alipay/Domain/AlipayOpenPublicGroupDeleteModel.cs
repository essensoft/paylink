using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicGroupDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicGroupDeleteModel : AlipayObject
    {
        /// <summary>
        /// 需要删除的用户分组的id
        /// </summary>
        [JsonProperty("group_id")]
        public string GroupId { get; set; }
    }
}
