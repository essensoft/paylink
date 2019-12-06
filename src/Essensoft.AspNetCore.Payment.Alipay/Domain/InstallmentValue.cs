using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InstallmentValue Data Structure.
    /// </summary>
    public class InstallmentValue : AlipayObject
    {
        /// <summary>
        /// 分段值
        /// </summary>
        [JsonPropertyName("installment_values")]
        public List<InstallmentMetaInfo> InstallmentValues { get; set; }
    }
}
