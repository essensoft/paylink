using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectActivityQueryResponse.
    /// </summary>
    public class AntMerchantExpandIndirectActivityQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 费率申请通过后实际生效的费率值，只有0或者0.001两种可能情况。当status字段返回TRUE时此字段有值，反之不返回费率信息
        /// </summary>
        [JsonPropertyName("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// 费率审核通过此字段状态值为TRUE，反之为FALSE
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
