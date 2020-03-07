using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTravelContentCancelResponse.
    /// </summary>
    public class AlipayOverseasTravelContentCancelResponse : AlipayResponse
    {
        /// <summary>
        /// 结果描述，仅当撤回已处于撤回状态的内容，且请求中的modified_date等于已落地内容的modified_date，认为幂等成功，返回Success
        /// </summary>
        [JsonPropertyName("result_msg")]
        public string ResultMsg { get; set; }
    }
}
