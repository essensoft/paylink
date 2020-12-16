using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GFAOpenAPIAcceptanceResult Data Structure.
    /// </summary>
    public class GFAOpenAPIAcceptanceResult : AlipayObject
    {
        /// <summary>
        /// 受理单id
        /// </summary>
        [JsonPropertyName("acceptance_id")]
        public string AcceptanceId { get; set; }

        /// <summary>
        /// 接口调用失败是否需要重试
        /// </summary>
        [JsonPropertyName("need_retry")]
        public bool NeedRetry { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        [JsonPropertyName("out_business_no")]
        public string OutBusinessNo { get; set; }

        /// <summary>
        /// 接口结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 接口调用结果描述
        /// </summary>
        [JsonPropertyName("result_message")]
        public string ResultMessage { get; set; }

        /// <summary>
        /// 业务唯一标识
        /// </summary>
        [JsonPropertyName("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 解决方案id
        /// </summary>
        [JsonPropertyName("solution_id")]
        public string SolutionId { get; set; }

        /// <summary>
        /// 业务流水子单号
        /// </summary>
        [JsonPropertyName("sub_out_business_no")]
        public string SubOutBusinessNo { get; set; }
    }
}
