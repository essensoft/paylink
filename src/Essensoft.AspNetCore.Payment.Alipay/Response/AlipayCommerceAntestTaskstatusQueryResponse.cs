using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceAntestTaskstatusQueryResponse.
    /// </summary>
    public class AlipayCommerceAntestTaskstatusQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 任务状态： INIT 已创建，EXECUTING 执行中，FINISH 已完成，CANCEL 已取消
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
    }
}
