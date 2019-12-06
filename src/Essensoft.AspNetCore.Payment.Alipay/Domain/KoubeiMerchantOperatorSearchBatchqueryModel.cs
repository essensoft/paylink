using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantOperatorSearchBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiMerchantOperatorSearchBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 授权码
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 当前页码，从1开始
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// T - "已激活"  U - "已锁定"  W - "未激活"
        /// </summary>
        [JsonPropertyName("status")]
        public List<string> Status { get; set; }
    }
}
