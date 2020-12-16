using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialQuestionnareTaskPublishModel Data Structure.
    /// </summary>
    public class AlipaySocialQuestionnareTaskPublishModel : AlipayObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("biz_channel")]
        public string BizChannel { get; set; }

        /// <summary>
        /// 扩展字段
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
        /// UONE问券ID
        /// </summary>
        [JsonPropertyName("rmt_qstn_id")]
        public string RmtQstnId { get; set; }
    }
}
