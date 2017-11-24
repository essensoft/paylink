using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// TemplateOpenCardConfDTO Data Structure.
    /// </summary>
    public class TemplateOpenCardConfDTO : AlipayObject
    {
        /// <summary>
        /// 配置，预留字段，暂时不用
        /// </summary>
        [JsonProperty("conf")]
        public string Conf { get; set; }

        /// <summary>
        /// ISV：外部系统  MER：直连商户
        /// </summary>
        [JsonProperty("open_card_source_type")]
        public string OpenCardSourceType { get; set; }

        /// <summary>
        /// 开卡连接，必须http、https开头
        /// </summary>
        [JsonProperty("open_card_url")]
        public string OpenCardUrl { get; set; }

        /// <summary>
        /// 渠道APPID，提供领卡页面的服务提供方
        /// </summary>
        [JsonProperty("source_app_id")]
        public string SourceAppId { get; set; }
    }
}
