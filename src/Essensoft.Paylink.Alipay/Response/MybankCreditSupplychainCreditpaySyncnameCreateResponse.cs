using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// MybankCreditSupplychainCreditpaySyncnameCreateResponse.
    /// </summary>
    public class MybankCreditSupplychainCreditpaySyncnameCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 业务序列号
        /// </summary>
        [JsonPropertyName("ev_seq_no")]
        public string EvSeqNo { get; set; }
    }
}
