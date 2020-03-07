using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserAdBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotAdvertiserAdBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 是否只要总大小
        /// </summary>
        [JsonPropertyName("only_total")]
        public bool OnlyTotal { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小(<=50)
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}
