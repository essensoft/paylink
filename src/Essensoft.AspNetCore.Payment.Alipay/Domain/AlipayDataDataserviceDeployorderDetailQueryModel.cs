using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceDeployorderDetailQueryModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceDeployorderDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 描述：拉取的业务起始时间（不包含）  应用场景：管控中心启动后通过该参数获取增量发布的部署单  如何获取：获取本地部署单的最大时间
        /// </summary>
        [JsonPropertyName("biz_create_begin")]
        public string BizCreateBegin { get; set; }

        /// <summary>
        /// 管控中心实例名称+唯一+通过该名称获取发布到该环境的部署单+无枚举值+通过页面配置自行定义
        /// </summary>
        [JsonPropertyName("biz_ins_name")]
        public string BizInsName { get; set; }

        /// <summary>
        /// 描述:页数，从1开始  应用场景:分页获取增量部署单
        /// </summary>
        [JsonPropertyName("page")]
        public long Page { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [JsonPropertyName("size")]
        public long Size { get; set; }
    }
}
