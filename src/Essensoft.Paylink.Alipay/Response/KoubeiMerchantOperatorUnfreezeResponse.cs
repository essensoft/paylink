using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorUnfreezeResponse.
    /// </summary>
    public class KoubeiMerchantOperatorUnfreezeResponse : AlipayResponse
    {
        /// <summary>
        /// 操作结果 true: success, false: failed
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
