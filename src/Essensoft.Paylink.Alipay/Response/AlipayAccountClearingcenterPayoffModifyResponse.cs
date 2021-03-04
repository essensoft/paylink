using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
