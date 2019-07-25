using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RefundExtendParams Data Structure.
    /// </summary>
    [Serializable]
    public class RefundExtendParams : AlipayObject
    {
        /// <summary>
        /// 芝麻外部类目
        /// </summary>
        [JsonProperty("credit_category_id")]
        public string CreditCategoryId { get; set; }

        /// <summary>
        /// 信用服务ID
        /// </summary>
        [JsonProperty("credit_service_id")]
        public string CreditServiceId { get; set; }
    }
}
