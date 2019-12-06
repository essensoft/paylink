using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Hit Data Structure.
    /// </summary>
    public class Hit : AlipayObject
    {
        /// <summary>
        /// action跳转参数信息
        /// </summary>
        [JsonPropertyName("action_param")]
        public string ActionParam { get; set; }

        /// <summary>
        /// 内容类型:  alipay:小程序  link:h5页面
        /// </summary>
        [JsonPropertyName("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 业务id
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 命中的结果的描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 扩展信息,json字符串
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 显示的图标
        /// </summary>
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 命中的结果显示名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 搜索结果的来源方
        /// </summary>
        [JsonPropertyName("provider")]
        public string Provider { get; set; }
    }
}
