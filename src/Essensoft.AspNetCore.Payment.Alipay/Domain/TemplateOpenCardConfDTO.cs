using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TemplateOpenCardConfDTO Data Structure.
    /// </summary>
    public class TemplateOpenCardConfDTO : AlipayObject
    {
        /// <summary>
        /// 领卡权益信息
        /// </summary>
        [JsonPropertyName("card_rights")]
        public List<TemplateRightsContentDTO> CardRights { get; set; }

        /// <summary>
        /// 配置，预留字段，暂时不用
        /// </summary>
        [JsonPropertyName("conf")]
        public string Conf { get; set; }

        /// <summary>
        /// ISV：外部系统  MER：直连商户
        /// </summary>
        [JsonPropertyName("open_card_source_type")]
        public string OpenCardSourceType { get; set; }

        /// <summary>
        /// 开卡连接，必须http、https开头
        /// </summary>
        [JsonPropertyName("open_card_url")]
        public string OpenCardUrl { get; set; }

        /// <summary>
        /// 渠道APPID，提供领卡页面的服务提供方
        /// </summary>
        [JsonPropertyName("source_app_id")]
        public string SourceAppId { get; set; }
    }
}
