using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayBossCsChannelQueryModel Data Structure.
    /// </summary>
    public class AlipayBossCsChannelQueryModel : AlipayObject
    {
        /// <summary>
        /// 平均通话时长的qualifier
        /// </summary>
        [JsonProperty("att")]
        public string Att { get; set; }

        /// <summary>
        /// 总接通率的qualifier
        /// </summary>
        [JsonProperty("connectionrate")]
        public string Connectionrate { get; set; }

        /// <summary>
        /// 在线小二人数的qualifier
        /// </summary>
        [JsonProperty("curragentsloggedin")]
        public string Curragentsloggedin { get; set; }

        /// <summary>
        /// 通话中人数的qualifier
        /// </summary>
        [JsonProperty("curragenttalking")]
        public string Curragenttalking { get; set; }

        /// <summary>
        /// 小休人数的qualifier
        /// </summary>
        [JsonProperty("currentnotreadyagents")]
        public string Currentnotreadyagents { get; set; }

        /// <summary>
        /// 等待人数的qualifier
        /// </summary>
        [JsonProperty("currentreadyagents")]
        public string Currentreadyagents { get; set; }

        /// <summary>
        /// 总排队数的Qualifier
        /// </summary>
        [JsonProperty("currnumberwaitingcalls")]
        public string Currnumberwaitingcalls { get; set; }

        /// <summary>
        /// 查询hbase的rowkey
        /// </summary>
        [JsonProperty("endkey")]
        public string Endkey { get; set; }

        /// <summary>
        /// 查询hbase的rowkey
        /// </summary>
        [JsonProperty("startkey")]
        public string Startkey { get; set; }

        /// <summary>
        /// 总流入量的qualifier
        /// </summary>
        [JsonProperty("visitorinflow")]
        public string Visitorinflow { get; set; }

        /// <summary>
        /// 总应答量的qualifier
        /// </summary>
        [JsonProperty("visitorresponse")]
        public string Visitorresponse { get; set; }

        /// <summary>
        /// 应答量[转接] 的qualifier
        /// </summary>
        [JsonProperty("visitorresponsetransfer")]
        public string Visitorresponsetransfer { get; set; }
    }
}
