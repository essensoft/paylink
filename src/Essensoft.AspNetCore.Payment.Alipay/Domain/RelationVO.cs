using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RelationVO Data Structure.
    /// </summary>
    public class RelationVO : AlipayObject
    {
        /// <summary>
        /// 支付宝账户名称（脱敏）
        /// </summary>
        [JsonPropertyName("oppo_account_name")]
        public string OppoAccountName { get; set; }

        /// <summary>
        /// 唯一标记一个儿童的业务id
        /// </summary>
        [JsonPropertyName("oppo_child_id")]
        public string OppoChildId { get; set; }

        /// <summary>
        /// 头像路径
        /// </summary>
        [JsonPropertyName("oppo_head_url")]
        public string OppoHeadUrl { get; set; }

        /// <summary>
        /// 儿童昵称
        /// </summary>
        [JsonPropertyName("oppo_nick_name")]
        public string OppoNickName { get; set; }

        /// <summary>
        /// 对方真实姓名（脱敏）
        /// </summary>
        [JsonPropertyName("oppo_real_name")]
        public string OppoRealName { get; set; }
    }
}
