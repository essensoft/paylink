using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TemplateContext Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateContext : AlipayObject
    {
        /// <summary>
        /// 底部链接描述文字，如“查看详情”，最多能传8个汉字或16个英文字符，长度超出会报错
        /// </summary>
        [JsonProperty("action_name")]
        public string ActionName { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        [JsonProperty("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 模板的标题。  如：您好，您已成功预约车辆。
        /// </summary>
        [JsonProperty("first")]
        public TemplateKeyword First { get; set; }

        /// <summary>
        /// 顶部色条的色值
        /// </summary>
        [JsonProperty("head_color")]
        public string HeadColor { get; set; }

        /// <summary>
        /// 消息备注。 如：请您及时到达修理厂哦！
        /// </summary>
        [JsonProperty("remark")]
        public TemplateKeyword Remark { get; set; }

        /// <summary>
        /// 点击消息后承接页的地址
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
