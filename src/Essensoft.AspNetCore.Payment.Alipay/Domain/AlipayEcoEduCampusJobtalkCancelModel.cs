using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEduCampusJobtalkCancelModel Data Structure.
    /// </summary>
    public class AlipayEcoEduCampusJobtalkCancelModel : AlipayObject
    {
        /// <summary>
        /// 备用字段，json格式
        /// </summary>
        [JsonPropertyName("content_var")]
        public string ContentVar { get; set; }

        /// <summary>
        /// 宣讲会来源方id
        /// </summary>
        [JsonPropertyName("talk_source_code")]
        public string TalkSourceCode { get; set; }

        /// <summary>
        /// 宣讲会在合作方的ID
        /// </summary>
        [JsonPropertyName("talk_source_id")]
        public string TalkSourceId { get; set; }
    }
}
