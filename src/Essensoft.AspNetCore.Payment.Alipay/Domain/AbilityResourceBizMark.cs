using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AbilityResourceBizMark Data Structure.
    /// </summary>
    public class AbilityResourceBizMark : AlipayObject
    {
        /// <summary>
        /// isv的业务code,商户可以用户这个code和商户进行数据核对
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// executionTime
        /// </summary>
        [JsonPropertyName("execution_time")]
        public string ExecutionTime { get; set; }
    }
}
