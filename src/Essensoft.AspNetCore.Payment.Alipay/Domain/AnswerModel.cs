using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnswerModel Data Structure.
    /// </summary>
    public class AnswerModel : AlipayObject
    {
        /// <summary>
        /// 供填空和问卷内容提交的附加项
        /// </summary>
        [JsonPropertyName("extra")]
        public string Extra { get; set; }

        /// <summary>
        /// 问题id信息
        /// </summary>
        [JsonPropertyName("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 选项id
        /// </summary>
        [JsonPropertyName("option_id")]
        public long OptionId { get; set; }
    }
}
