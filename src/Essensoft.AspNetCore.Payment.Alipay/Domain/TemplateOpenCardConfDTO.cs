using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TemplateOpenCardConfDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateOpenCardConfDTO : AlipayObject
    {
        /// <summary>
        /// 领卡权益信息
        /// </summary>
        [JsonProperty("card_rights")]
        [XmlArray("card_rights")]
        [XmlArrayItem("template_rights_content_d_t_o")]
        public List<TemplateRightsContentDTO> CardRights { get; set; }

        /// <summary>
        /// 配置，预留字段，暂时不用
        /// </summary>
        [JsonProperty("conf")]
        [XmlElement("conf")]
        public string Conf { get; set; }

        /// <summary>
        /// ISV：外部系统  MER：直连商户
        /// </summary>
        [JsonProperty("open_card_source_type")]
        [XmlElement("open_card_source_type")]
        public string OpenCardSourceType { get; set; }

        /// <summary>
        /// 开卡连接，必须http、https开头
        /// </summary>
        [JsonProperty("open_card_url")]
        [XmlElement("open_card_url")]
        public string OpenCardUrl { get; set; }

        /// <summary>
        /// 渠道APPID，提供领卡页面的服务提供方
        /// </summary>
        [JsonProperty("source_app_id")]
        [XmlElement("source_app_id")]
        public string SourceAppId { get; set; }
    }
}
