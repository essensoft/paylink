using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMultimediaXnnminiVersionCreateModel Data Structure.
    /// </summary>
    public class AlipayMultimediaXnnminiVersionCreateModel : AlipayObject
    {
        /// <summary>
        /// 业务id
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 版本描述
        /// </summary>
        [JsonPropertyName("des")]
        public string Des { get; set; }

        /// <summary>
        /// 模型绑定应用id
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 模型版本号
        /// </summary>
        [JsonPropertyName("model_version")]
        public string ModelVersion { get; set; }

        /// <summary>
        /// 模型创建用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
