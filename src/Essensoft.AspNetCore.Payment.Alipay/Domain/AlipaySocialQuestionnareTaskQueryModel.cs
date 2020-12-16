using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialQuestionnareTaskQueryModel Data Structure.
    /// </summary>
    public class AlipaySocialQuestionnareTaskQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 业务扩展信息
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
