using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AuthenticationScene Data Structure.
    /// </summary>
    public class AuthenticationScene : AlipayObject
    {
        /// <summary>
        /// 渠道类型
        /// </summary>
        [JsonPropertyName("access_channel")]
        public string AccessChannel { get; set; }

        /// <summary>
        /// 系统名称
        /// </summary>
        [JsonPropertyName("biz_name")]
        public string BizName { get; set; }

        /// <summary>
        /// 业务产品节点
        /// </summary>
        [JsonPropertyName("biz_prod_node")]
        public string BizProdNode { get; set; }

        /// <summary>
        /// 产品
        /// </summary>
        [JsonPropertyName("biz_product")]
        public string BizProduct { get; set; }

        /// <summary>
        /// 场景参数
        /// </summary>
        [JsonPropertyName("scene_params")]
        public string SceneParams { get; set; }
    }
}
