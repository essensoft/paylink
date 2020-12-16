using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditLoantradePayAssetConsultResponse.
    /// </summary>
    public class MybankCreditLoantradePayAssetConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 账期资产视图，如果未咨询账期资产，可能为空
        /// </summary>
        [JsonPropertyName("bill_assets")]
        public List<CreditPayBillAssetVO> BillAssets { get; set; }

        /// <summary>
        /// 担保资产视图，如果未咨询担保资产，可能为空
        /// </summary>
        [JsonPropertyName("guarantee_assets")]
        public List<CreditPayGuaranteeAssetVO> GuaranteeAssets { get; set; }

        /// <summary>
        /// 引导模型
        /// </summary>
        [JsonPropertyName("guide_info")]
        public CreditPayGuideVO GuideInfo { get; set; }

        /// <summary>
        /// 分期资产视图，如果未咨询分期资产，可能为空
        /// </summary>
        [JsonPropertyName("installment_assets")]
        public List<CreditPayInstallmentAssetVO> InstallmentAssets { get; set; }

        /// <summary>
        /// 咨询失败拒绝信息，只有在success为false的时候才存在
        /// </summary>
        [JsonPropertyName("refuse_info")]
        public CreditPayRefuseVO RefuseInfo { get; set; }

        /// <summary>
        /// 咨询是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
