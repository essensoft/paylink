using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TemplateCardLevelConfDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateCardLevelConfDTO : AlipayObject
    {
        /// <summary>
        /// 会员级别 该级别和开卡接口中的level要一致
        /// </summary>
        [JsonProperty("level")]
        [XmlElement("level")]
        public string Level { get; set; }

        /// <summary>
        /// 会员级别描述
        /// </summary>
        [JsonProperty("level_desc")]
        [XmlElement("level_desc")]
        public string LevelDesc { get; set; }

        /// <summary>
        /// 会员级别对应icon， 通过接口（alipay.offline.material.image.upload）上传图片
        /// </summary>
        [JsonProperty("level_icon")]
        [XmlElement("level_icon")]
        public string LevelIcon { get; set; }

        /// <summary>
        /// 会员级别显示名称
        /// </summary>
        [JsonProperty("level_show_name")]
        [XmlElement("level_show_name")]
        public string LevelShowName { get; set; }
    }
}
