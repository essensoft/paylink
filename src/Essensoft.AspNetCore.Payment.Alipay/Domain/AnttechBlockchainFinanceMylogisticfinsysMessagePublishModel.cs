using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceMylogisticfinsysMessagePublishModel Data Structure.
    /// </summary>
    public class AnttechBlockchainFinanceMylogisticfinsysMessagePublishModel : AlipayObject
    {
        /// <summary>
        /// 路由方法的参数
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// 方法路由
        /// </summary>
        [JsonPropertyName("method_name")]
        public string MethodName { get; set; }
    }
}
