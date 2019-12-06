using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppIndustryBizinfoQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppIndustryBizinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务机构简称
        /// </summary>
        [JsonPropertyName("biz_inst")]
        public string BizInst { get; set; }

        /// <summary>
        /// 业务类型，公服业务：IND
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务数据码，标识业务场景
        /// </summary>
        [JsonPropertyName("data_code")]
        public string DataCode { get; set; }

        /// <summary>
        /// 请求上下文，json格式
        /// </summary>
        [JsonPropertyName("request_context")]
        public string RequestContext { get; set; }
    }
}
