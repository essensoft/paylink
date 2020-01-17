using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MessageContext Data Structure.
    /// </summary>
    public class MessageContext : AlipayObject
    {
        /// <summary>
        /// 底部链接描述文字，如“查看详情”，最多能传8个汉字或16个英文字符，长度超出会报错
        /// </summary>
        [JsonPropertyName("action_name")]
        public string ActionName { get; set; }

        /// <summary>
        /// 模板中占位符的值及文字颜色
        /// </summary>
        [JsonPropertyName("first")]
        public MessageTemplateKeyword First { get; set; }

        /// <summary>
        /// 顶部色条的色值
        /// </summary>
        [JsonPropertyName("head_color")]
        public string HeadColor { get; set; }

        /// <summary>
        /// 模板中占位符的值及文字颜色
        /// </summary>
        [JsonPropertyName("keyword_1")]
        public MessageTemplateKeyword Keyword1 { get; set; }

        /// <summary>
        /// 模板中占位符的值及文字颜色
        /// </summary>
        [JsonPropertyName("keyword_2")]
        public MessageTemplateKeyword Keyword2 { get; set; }

        /// <summary>
        /// 模板中占位符的值及文字颜色
        /// </summary>
        [JsonPropertyName("remark")]
        public MessageTemplateKeyword Remark { get; set; }

        /// <summary>
        /// 点击消息后承接页的地址
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
