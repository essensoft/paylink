using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialQuestionnareTaskPublishResponse.
    /// </summary>
    public class AlipaySocialQuestionnareTaskPublishResponse : AlipayResponse
    {
        /// <summary>
        /// 业务扩展字段
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 哥伦布问券任务Id
        /// </summary>
        [JsonPropertyName("qstn_id")]
        public string QstnId { get; set; }

        /// <summary>
        /// UONE问卷ID
        /// </summary>
        [JsonPropertyName("rmt_qstn_id")]
        public string RmtQstnId { get; set; }
    }
}
