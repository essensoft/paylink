using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditGuaranteeWriteoffPayResponse.
    /// </summary>
    public class MybankCreditGuaranteeWriteoffPayResponse : AlipayResponse
    {
        /// <summary>
        /// 销账申请单号
        /// </summary>
        [JsonPropertyName("writeoff_apply_no")]
        public string WriteoffApplyNo { get; set; }
    }
}
