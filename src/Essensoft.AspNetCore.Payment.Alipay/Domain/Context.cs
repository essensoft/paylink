using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Context Data Structure.
    /// </summary>
    [Serializable]
    public class Context : AlipayObject
    {
        /// <summary>
        /// 底部链接描述文字，如“查看详情”
        /// </summary>
        [JsonProperty("action_name")]
        [XmlElement("action_name")]
        public string ActionName { get; set; }

        /// <summary>
        /// 模板中占位符的值及文字颜色，value和color都为必填项，color为当前文字颜色
        /// </summary>
        [JsonProperty("first")]
        [XmlElement("first")]
        public Keyword First { get; set; }

        /// <summary>
        /// 顶部色条的色值
        /// </summary>
        [JsonProperty("head_color")]
        [XmlElement("head_color")]
        public string HeadColor { get; set; }

        /// <summary>
        /// 模板中占位符的值及文字颜色，value和color都为必填项，color为当前文字颜色
        /// </summary>
        [JsonProperty("keyword1")]
        [XmlElement("keyword1")]
        public Keyword Keyword1 { get; set; }

        /// <summary>
        /// 模板中占位符的值及文字颜色，value和color都为必填项，color为当前文字颜色
        /// </summary>
        [JsonProperty("keyword2")]
        [XmlElement("keyword2")]
        public Keyword Keyword2 { get; set; }

        /// <summary>
        /// 模板中占位符的值及文字颜色，value和color都为必填项，color为当前文字颜色
        /// </summary>
        [JsonProperty("remark")]
        [XmlElement("remark")]
        public Keyword Remark { get; set; }

        /// <summary>
        /// 点击消息后承接页的地址
        /// </summary>
        [JsonProperty("url")]
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
