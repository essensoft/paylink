using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMultimediaXnnminiModelCreateModel Data Structure.
    /// </summary>
    public class AlipayMultimediaXnnminiModelCreateModel : AlipayObject
    {
        /// <summary>
        /// 业务id
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 模型描述
        /// </summary>
        [JsonPropertyName("des")]
        public string Des { get; set; }

        /// <summary>
        /// 模型校验参数信息
        /// </summary>
        [JsonPropertyName("license")]
        public string License { get; set; }

        /// <summary>
        /// 模型绑定应用id
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 模型名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 模型原始链接地址
        /// </summary>
        [JsonPropertyName("ori_url")]
        public string OriUrl { get; set; }

        /// <summary>
        /// 模型类型：XNN、TF_JS
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 模型创建用户
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 版本信息标识id
        /// </summary>
        [JsonPropertyName("version_id")]
        public string VersionId { get; set; }
    }
}
