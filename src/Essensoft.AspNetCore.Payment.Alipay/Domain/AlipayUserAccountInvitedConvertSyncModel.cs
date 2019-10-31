using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAccountInvitedConvertSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAccountInvitedConvertSyncModel : AlipayObject
    {
        /// <summary>
        /// 转化标签
        /// </summary>
        [JsonProperty("convert_tag")]
        public string ConvertTag { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
