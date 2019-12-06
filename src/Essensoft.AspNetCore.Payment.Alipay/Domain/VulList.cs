using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VulList Data Structure.
    /// </summary>
    public class VulList : AlipayObject
    {
        /// <summary>
        /// 漏洞奖励
        /// </summary>
        [JsonPropertyName("coin")]
        public long Coin { get; set; }

        /// <summary>
        /// 漏洞等级
        /// </summary>
        [JsonPropertyName("level")]
        public long Level { get; set; }

        /// <summary>
        /// 漏洞信息标题
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 漏洞提交修复状态
        /// </summary>
        [JsonPropertyName("status")]
        public long Status { get; set; }

        /// <summary>
        /// 漏洞提交时间
        /// </summary>
        [JsonPropertyName("submit_time")]
        public string SubmitTime { get; set; }

        /// <summary>
        /// 漏洞id
        /// </summary>
        [JsonPropertyName("vul_id")]
        public long VulId { get; set; }
    }
}
