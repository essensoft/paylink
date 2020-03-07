using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountFinriskCompanyVerifyGetModel Data Structure.
    /// </summary>
    public class AlipayAccountFinriskCompanyVerifyGetModel : AlipayObject
    {
        /// <summary>
        /// 请求系统
        /// </summary>
        [JsonPropertyName("app")]
        public string App { get; set; }

        /// <summary>
        /// 业务参数列表
        /// </summary>
        [JsonPropertyName("param")]
        public string Param { get; set; }

        /// <summary>
        /// 外部请求唯一标识
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 防伪场景编码
        /// </summary>
        [JsonPropertyName("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonPropertyName("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
