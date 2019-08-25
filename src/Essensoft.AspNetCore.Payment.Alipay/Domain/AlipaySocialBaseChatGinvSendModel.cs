using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseChatGinvSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseChatGinvSendModel : AlipayObject
    {
        /// <summary>
        /// 群id
        /// </summary>
        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 邀请的好友id列表，最多50人
        /// </summary>
        [JsonProperty("uids")]
        public List<string> Uids { get; set; }
    }
}
