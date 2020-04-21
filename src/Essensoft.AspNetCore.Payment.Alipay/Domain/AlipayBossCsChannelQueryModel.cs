using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossCsChannelQueryModel Data Structure.
    /// </summary>
    public class AlipayBossCsChannelQueryModel : AlipayObject
    {
        /// <summary>
        /// 平均通话时长的qualifier
        /// </summary>
        [JsonPropertyName("att")]
        public string Att { get; set; }

        /// <summary>
        /// 总接通率的qualifier
        /// </summary>
        [JsonPropertyName("connectionrate")]
        public string Connectionrate { get; set; }

        /// <summary>
        /// 在线小二人数的qualifier
        /// </summary>
        [JsonPropertyName("curragentsloggedin")]
        public string Curragentsloggedin { get; set; }

        /// <summary>
        /// 通话中人数的qualifier
        /// </summary>
        [JsonPropertyName("curragenttalking")]
        public string Curragenttalking { get; set; }

        /// <summary>
        /// 小休人数的qualifier
        /// </summary>
        [JsonPropertyName("currentnotreadyagents")]
        public string Currentnotreadyagents { get; set; }

        /// <summary>
        /// 等待人数的qualifier
        /// </summary>
        [JsonPropertyName("currentreadyagents")]
        public string Currentreadyagents { get; set; }

        /// <summary>
        /// 总排队数的Qualifier
        /// </summary>
        [JsonPropertyName("currnumberwaitingcalls")]
        public string Currnumberwaitingcalls { get; set; }

        /// <summary>
        /// 查询hbase的rowkey
        /// </summary>
        [JsonPropertyName("endkey")]
        public string Endkey { get; set; }

        /// <summary>
        /// 查询hbase的rowkey
        /// </summary>
        [JsonPropertyName("startkey")]
        public string Startkey { get; set; }

        /// <summary>
        /// 总流入量的qualifier
        /// </summary>
        [JsonPropertyName("visitorinflow")]
        public string Visitorinflow { get; set; }

        /// <summary>
        /// 总应答量的qualifier
        /// </summary>
        [JsonPropertyName("visitorresponse")]
        public string Visitorresponse { get; set; }

        /// <summary>
        /// 应答量[转接] 的qualifier
        /// </summary>
        [JsonPropertyName("visitorresponsetransfer")]
        public string Visitorresponsetransfer { get; set; }
    }
}
