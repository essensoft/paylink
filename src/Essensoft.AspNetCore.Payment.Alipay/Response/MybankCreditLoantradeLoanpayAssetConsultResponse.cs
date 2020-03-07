using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditLoantradeLoanpayAssetConsultResponse.
    /// </summary>
    public class MybankCreditLoantradeLoanpayAssetConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 资产
        /// </summary>
        [JsonPropertyName("asset_result")]
        public LoanPayAssetResult AssetResult { get; set; }

        /// <summary>
        /// 不可见不可用信息
        /// </summary>
        [JsonPropertyName("refuse_msg")]
        public Refuse RefuseMsg { get; set; }

        /// <summary>
        /// 是否处理成功，true(成功)，false(失败)。true表示咨询成功，但不代表可见可用
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
