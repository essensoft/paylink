using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayAccountClearingcenterPayoffModifyResponse.
    /// </summary>
    public class AlipayAccountClearingcenterPayoffModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [JsonPropertyName("result")]
        public ClearingCommonResult Result { get; set; }
    }
}
