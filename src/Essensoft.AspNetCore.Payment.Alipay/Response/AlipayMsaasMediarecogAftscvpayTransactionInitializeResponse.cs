using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogAftscvpayTransactionInitializeResponse.
    /// </summary>
    public class AlipayMsaasMediarecogAftscvpayTransactionInitializeResponse : AlipayResponse
    {
        /// <summary>
        /// 处理结果
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }

        /// <summary>
        /// 云平台请求唯一标示,保证用户请求的幂等性.
        /// </summary>
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }
    }
}
