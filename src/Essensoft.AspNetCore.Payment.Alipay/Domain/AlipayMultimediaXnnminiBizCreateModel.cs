using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMultimediaXnnminiBizCreateModel Data Structure.
    /// </summary>
    public class AlipayMultimediaXnnminiBizCreateModel : AlipayObject
    {
        /// <summary>
        /// 业务描述
        /// </summary>
        [JsonPropertyName("des")]
        public string Des { get; set; }

        /// <summary>
        /// 模型绑定应用id
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 业务名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 模型创建用户
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
