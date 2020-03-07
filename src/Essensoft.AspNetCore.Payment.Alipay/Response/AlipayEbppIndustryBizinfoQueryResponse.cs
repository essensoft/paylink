using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppIndustryBizinfoQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryBizinfoQueryResponse : AlipayResponse
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
        /// 机构结果码
        /// </summary>
        [JsonPropertyName("org_result_code")]
        public string OrgResultCode { get; set; }

        /// <summary>
        /// 业务结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 返回结果上下文，json格式
        /// </summary>
        [JsonPropertyName("result_context")]
        public string ResultContext { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [JsonPropertyName("result_msg")]
        public string ResultMsg { get; set; }
    }
}
