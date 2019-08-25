using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditPayInstallmentAssetVO Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPayInstallmentAssetVO : AlipayObject
    {
        /// <summary>
        /// 信用支付资产详情基础信息
        /// </summary>
        [JsonProperty("base_info")]
        public CreditPayAssetBaseVO BaseInfo { get; set; }

        /// <summary>
        /// 分期详情
        /// </summary>
        [JsonProperty("installment_details")]
        public List<CreditPayInstallmentDetailVO> InstallmentDetails { get; set; }
    }
}
