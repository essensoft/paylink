using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialQuestionnareGrayUpgradeModel Data Structure.
    /// </summary>
    public class AlipaySocialQuestionnareGrayUpgradeModel : AlipayObject
    {
        /// <summary>
        /// 业务扩展字段
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 灰度比例
        /// </summary>
        [JsonPropertyName("gray_percent")]
        public string GrayPercent { get; set; }

        /// <summary>
        /// 哥伦布问券任务Id
        /// </summary>
        [JsonPropertyName("qstn_id")]
        public string QstnId { get; set; }
    }
}
