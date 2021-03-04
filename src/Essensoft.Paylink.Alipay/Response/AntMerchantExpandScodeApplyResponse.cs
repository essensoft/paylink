using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandScodeApplyResponse.
    /// </summary>
    public class AntMerchantExpandScodeApplyResponse : AlipayResponse
    {
        /// <summary>
        /// apply_code_response, S码申请的结果对象
        /// </summary>
        [JsonPropertyName("apply_code_response")]
        public ApplyCodeResponse ApplyCodeResponse { get; set; }
    }
}
