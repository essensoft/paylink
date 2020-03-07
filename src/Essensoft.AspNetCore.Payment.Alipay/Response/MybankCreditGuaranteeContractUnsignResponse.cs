using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditGuaranteeContractUnsignResponse.
    /// </summary>
    public class MybankCreditGuaranteeContractUnsignResponse : AlipayResponse
    {
        /// <summary>
        /// 合约号。调用成功则返回对应签约的合约号。
        /// </summary>
        [JsonPropertyName("ar_no")]
        public string ArNo { get; set; }
    }
}
