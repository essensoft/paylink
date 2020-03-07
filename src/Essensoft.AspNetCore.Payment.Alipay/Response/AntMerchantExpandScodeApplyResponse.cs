using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
