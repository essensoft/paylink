using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RelationVO Data Structure.
    /// </summary>
    [Serializable]
    public class RelationVO : AlipayObject
    {
        /// <summary>
        /// 支付宝账户名称（脱敏）
        /// </summary>
        [JsonProperty("oppo_account_name")]
        public string OppoAccountName { get; set; }

        /// <summary>
        /// 唯一标记一个儿童的业务id
        /// </summary>
        [JsonProperty("oppo_child_id")]
        public string OppoChildId { get; set; }

        /// <summary>
        /// 头像路径
        /// </summary>
        [JsonProperty("oppo_head_url")]
        public string OppoHeadUrl { get; set; }

        /// <summary>
        /// 儿童昵称
        /// </summary>
        [JsonProperty("oppo_nick_name")]
        public string OppoNickName { get; set; }

        /// <summary>
        /// 对方真实姓名（脱敏）
        /// </summary>
        [JsonProperty("oppo_real_name")]
        public string OppoRealName { get; set; }
    }
}
