using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarDialogonlineAnswerPushModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarDialogonlineAnswerPushModel : AlipayObject
    {
        /// <summary>
        /// 回复内容
        /// </summary>
        [JsonProperty("answer_content")]
        public string AnswerContent { get; set; }

        /// <summary>
        /// 技师ID
        /// </summary>
        [JsonProperty("answer_id")]
        public string AnswerId { get; set; }

        /// <summary>
        /// 技师头像
        /// </summary>
        [JsonProperty("answer_logo")]
        public string AnswerLogo { get; set; }

        /// <summary>
        /// 技师昵称
        /// </summary>
        [JsonProperty("answer_name")]
        public string AnswerName { get; set; }

        /// <summary>
        /// 回复图片
        /// </summary>
        [JsonProperty("answer_pic")]
        public string AnswerPic { get; set; }

        /// <summary>
        /// 回复时间
        /// </summary>
        [JsonProperty("answer_time")]
        public string AnswerTime { get; set; }

        /// <summary>
        /// 1：问题回复， 2：对话回复
        /// </summary>
        [JsonProperty("answer_type")]
        public string AnswerType { get; set; }

        /// <summary>
        /// 内容类型，1：文本， 2：图片
        /// </summary>
        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 问题ID
        /// </summary>
        [JsonProperty("question_id")]
        public string QuestionId { get; set; }
    }
}
