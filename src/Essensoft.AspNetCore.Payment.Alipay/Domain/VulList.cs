using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VulList Data Structure.
    /// </summary>
    [Serializable]
    public class VulList : AlipayObject
    {
        /// <summary>
        /// 漏洞奖励
        /// </summary>
        [JsonProperty("coin")]
        public long Coin { get; set; }

        /// <summary>
        /// 漏洞等级
        /// </summary>
        [JsonProperty("level")]
        public long Level { get; set; }

        /// <summary>
        /// 漏洞信息标题
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 漏洞提交修复状态
        /// </summary>
        [JsonProperty("status")]
        public long Status { get; set; }

        /// <summary>
        /// 漏洞提交时间
        /// </summary>
        [JsonProperty("submit_time")]
        public string SubmitTime { get; set; }

        /// <summary>
        /// 漏洞id
        /// </summary>
        [JsonProperty("vul_id")]
        public long VulId { get; set; }
    }
}
