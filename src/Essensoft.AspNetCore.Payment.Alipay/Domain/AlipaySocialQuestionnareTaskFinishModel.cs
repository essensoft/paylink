using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialQuestionnareTaskFinishModel Data Structure.
    /// </summary>
    public class AlipaySocialQuestionnareTaskFinishModel : AlipayObject
    {
        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 哥伦布问券任务Id
        /// </summary>
        [JsonPropertyName("qstn_id")]
        public string QstnId { get; set; }
    }
}
