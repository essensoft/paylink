using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InstallmentValue Data Structure.
    /// </summary>
    [Serializable]
    public class InstallmentValue : AlipayObject
    {
        /// <summary>
        /// 分段值
        /// </summary>
        [JsonProperty("installment_values")]
        public List<InstallmentMetaInfo> InstallmentValues { get; set; }
    }
}
