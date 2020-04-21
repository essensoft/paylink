using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoBasicBizinfoQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoBasicBizinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 表示提供目标业务的机构名称
        /// </summary>
        [JsonPropertyName("biz_inst")]
        public string BizInst { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务数据码，标识业务场景，一般映射业务方的具体业务api
        /// </summary>
        [JsonPropertyName("data_code")]
        public string DataCode { get; set; }

        /// <summary>
        /// 输入参数的额外信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 目前机构需要的请求上下文，json格式
        /// </summary>
        [JsonPropertyName("request_context")]
        public string RequestContext { get; set; }
    }
}
