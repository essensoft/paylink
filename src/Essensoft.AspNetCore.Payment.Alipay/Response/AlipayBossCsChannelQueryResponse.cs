using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossCsChannelQueryResponse.
    /// </summary>
    public class AlipayBossCsChannelQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 平均通话时长
        /// </summary>
        [JsonProperty("att")]
        [XmlElement("att")]
        public string Att { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("comment")]
        [XmlElement("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// 接通率
        /// </summary>
        [JsonProperty("connection_rate")]
        [XmlElement("connection_rate")]
        public string ConnectionRate { get; set; }

        /// <summary>
        /// 通话中人数
        /// </summary>
        [JsonProperty("curr_agent_talking")]
        [XmlElement("curr_agent_talking")]
        public string CurrAgentTalking { get; set; }

        /// <summary>
        /// 在线小二数
        /// </summary>
        [JsonProperty("curr_agents_logged_in")]
        [XmlElement("curr_agents_logged_in")]
        public string CurrAgentsLoggedIn { get; set; }

        /// <summary>
        /// 排队数
        /// </summary>
        [JsonProperty("curr_number_waiting_calls")]
        [XmlElement("curr_number_waiting_calls")]
        public string CurrNumberWaitingCalls { get; set; }

        /// <summary>
        /// 小休人数
        /// </summary>
        [JsonProperty("current_not_ready_agents")]
        [XmlElement("current_not_ready_agents")]
        public string CurrentNotReadyAgents { get; set; }

        /// <summary>
        /// 等待人数
        /// </summary>
        [JsonProperty("current_ready_agents")]
        [XmlElement("current_ready_agents")]
        public string CurrentReadyAgents { get; set; }

        /// <summary>
        /// 主键
        /// </summary>
        [JsonProperty("row_key")]
        [XmlElement("row_key")]
        public string RowKey { get; set; }

        /// <summary>
        /// 流入量
        /// </summary>
        [JsonProperty("visitor_inflow")]
        [XmlElement("visitor_inflow")]
        public string VisitorInflow { get; set; }

        /// <summary>
        /// 应答量
        /// </summary>
        [JsonProperty("visitor_response")]
        [XmlElement("visitor_response")]
        public string VisitorResponse { get; set; }

        /// <summary>
        /// 应答量[转接]
        /// </summary>
        [JsonProperty("visitor_response_transfer")]
        [XmlElement("visitor_response_transfer")]
        public string VisitorResponseTransfer { get; set; }
    }
}
