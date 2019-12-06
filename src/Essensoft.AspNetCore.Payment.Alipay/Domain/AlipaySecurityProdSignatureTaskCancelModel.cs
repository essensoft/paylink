using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdSignatureTaskCancelModel Data Structure.
    /// </summary>
    public class AlipaySecurityProdSignatureTaskCancelModel : AlipayObject
    {
        /// <summary>
        /// 业务流水号，与初始化接口保持一致
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务唯一标识，由支付宝统一分配，无法自助获取
        /// </summary>
        [JsonPropertyName("biz_product")]
        public string BizProduct { get; set; }

        /// <summary>
        /// 接口版本信息，目前默认3，由服务提供方指定。
        /// </summary>
        [JsonPropertyName("service_version")]
        public string ServiceVersion { get; set; }

        /// <summary>
        /// 签约任务编号，与初始化返回参数一致。
        /// </summary>
        [JsonPropertyName("task_id")]
        public string TaskId { get; set; }
    }
}
