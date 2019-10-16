using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PointLibResult Data Structure.
    /// </summary>
    [Serializable]
    public class PointLibResult : AlipayObject
    {
        /// <summary>
        /// 仓库剩余积分数
        /// </summary>
        [JsonProperty("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 积分库ID
        /// </summary>
        [JsonProperty("library_id")]
        public string LibraryId { get; set; }

        /// <summary>
        /// 积分库名称
        /// </summary>
        [JsonProperty("library_name")]
        public string LibraryName { get; set; }

        /// <summary>
        /// 积分库状态
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 仓库积分总数
        /// </summary>
        [JsonProperty("sum_point")]
        public string SumPoint { get; set; }
    }
}
