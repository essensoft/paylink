using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditEpFreedepositInitializeResponse.
    /// </summary>
    public class ZhimaCreditEpFreedepositInitializeResponse : AlipayResponse
    {
        /// <summary>
        /// 免押额度业务流水号，每次业务唯一。
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }
    }
}
