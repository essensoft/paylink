using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEduCampusJobtalkCancelModel Data Structure.
    /// </summary>
    public class AlipayEcoEduCampusJobtalkCancelModel : AlipayObject
    {
        /// <summary>
        /// 备用字段，json格式
        /// </summary>
        [JsonProperty("content_var")]
        public string ContentVar { get; set; }

        /// <summary>
        /// 宣讲会来源方id
        /// </summary>
        [JsonProperty("talk_source_code")]
        public string TalkSourceCode { get; set; }

        /// <summary>
        /// 宣讲会在合作方的ID
        /// </summary>
        [JsonProperty("talk_source_id")]
        public string TalkSourceId { get; set; }
    }
}
