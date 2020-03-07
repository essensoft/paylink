using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoBasicBizinfoQueryResponse.
    /// </summary>
    public class AlipayEcoBasicBizinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 业务机构简称
        /// </summary>
        [JsonPropertyName("biz_inst")]
        public string BizInst { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务数据码，标识业务场景， 一般业映射业务服务方的具体业务api
        /// </summary>
        [JsonPropertyName("data_code")]
        public string DataCode { get; set; }

        /// <summary>
        /// 业务服务方提供的原始错误码
        /// </summary>
        [JsonPropertyName("org_result_code")]
        public string OrgResultCode { get; set; }

        /// <summary>
        /// 返回业务服务方的原始错误
        /// </summary>
        [JsonPropertyName("org_result_msg")]
        public string OrgResultMsg { get; set; }

        /// <summary>
        /// 业务结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 机构返回结果上下文，json格式
        /// </summary>
        [JsonPropertyName("result_context")]
        public string ResultContext { get; set; }

        /// <summary>
        /// 业务返回错误
        /// </summary>
        [JsonPropertyName("result_msg")]
        public string ResultMsg { get; set; }
    }
}
