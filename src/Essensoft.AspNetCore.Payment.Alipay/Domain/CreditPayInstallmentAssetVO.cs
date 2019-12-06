using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditPayInstallmentAssetVO Data Structure.
    /// </summary>
    public class CreditPayInstallmentAssetVO : AlipayObject
    {
        /// <summary>
        /// 信用支付资产详情基础信息
        /// </summary>
        [JsonPropertyName("base_info")]
        public CreditPayAssetBaseVO BaseInfo { get; set; }

        /// <summary>
        /// 分期详情
        /// </summary>
        [JsonPropertyName("installment_details")]
        public List<CreditPayInstallmentDetailVO> InstallmentDetails { get; set; }
    }
}
