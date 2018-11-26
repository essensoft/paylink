using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MallCardBo Data Structure.
    /// </summary>
    [Serializable]
    public class MallCardBo : AlipayObject
    {
        /// <summary>
        /// 商圈会员卡权益描述
        /// </summary>
        [JsonProperty("benefit_desc")]
        [XmlArray("benefit_desc")]
        [XmlArrayItem("string")]
        public List<string> BenefitDesc { get; set; }

        /// <summary>
        /// 会员卡图片url
        /// </summary>
        [JsonProperty("card_logo_url")]
        [XmlElement("card_logo_url")]
        public string CardLogoUrl { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonProperty("ext_info")]
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 等级展示名称
        /// </summary>
        [JsonProperty("level_show_name")]
        [XmlElement("level_show_name")]
        public string LevelShowName { get; set; }

        /// <summary>
        /// 会员卡卡模版ID
        /// </summary>
        [JsonProperty("template_id")]
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 权益标题 多个权益用,分隔
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
