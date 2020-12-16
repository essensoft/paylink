using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialQuestionnareTaskVerifyResponse.
    /// </summary>
    public class AlipaySocialQuestionnareTaskVerifyResponse : AlipayResponse
    {
        /// <summary>
        /// 业务扩展字段JSON格式
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

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

        /// <summary>
        /// 测试结果
        /// </summary>
        [JsonPropertyName("verify_result")]
        public string VerifyResult { get; set; }
    }
}
