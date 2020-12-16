using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialQuestionnareTaskQueryResponse.
    /// </summary>
    public class AlipaySocialQuestionnareTaskQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 投放渠道
        /// </summary>
        [JsonPropertyName("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 接入方式{1:SDK；2:体验检测；3:页面到达;4:页面停留;5:页面返回;6:页面折返;7:用户操作行为}
        /// </summary>
        [JsonPropertyName("collection_type")]
        public string CollectionType { get; set; }

        /// <summary>
        /// 业务扩展信息JSON格式
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonPropertyName("gmt_terminate")]
        public string GmtTerminate { get; set; }

        /// <summary>
        /// 内灰比例
        /// </summary>
        [JsonPropertyName("gray_percent")]
        public string GrayPercent { get; set; }

        /// <summary>
        /// 交互模式
        /// </summary>
        [JsonPropertyName("interact_type")]
        public string InteractType { get; set; }

        /// <summary>
        /// 哥伦布问券任务Id
        /// </summary>
        [JsonPropertyName("qstn_id")]
        public string QstnId { get; set; }

        /// <summary>
        /// 问卷状态
        /// </summary>
        [JsonPropertyName("qstn_status")]
        public string QstnStatus { get; set; }

        /// <summary>
        /// uone问卷id
        /// </summary>
        [JsonPropertyName("rmt_qstn_id")]
        public string RmtQstnId { get; set; }

        /// <summary>
        /// 问卷URL
        /// </summary>
        [JsonPropertyName("rmt_qstn_url")]
        public string RmtQstnUrl { get; set; }
    }
}
