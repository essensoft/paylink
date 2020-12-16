using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoCityserviceAppinfoQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoCityserviceAppinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 输入参数的额外信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 目前服务业务请求的上下文
        /// </summary>
        [JsonPropertyName("request_context")]
        public string RequestContext { get; set; }
    }
}
