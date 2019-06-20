using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnswerModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnswerModel : AlipayObject
    {
        /// <summary>
        /// 供填空和问卷内容提交的附加项
        /// </summary>
        [JsonProperty("extra")]
        public string Extra { get; set; }

        /// <summary>
        /// 问题id信息
        /// </summary>
        [JsonProperty("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 选项id
        /// </summary>
        [JsonProperty("option_id")]
        public long OptionId { get; set; }
    }
}
