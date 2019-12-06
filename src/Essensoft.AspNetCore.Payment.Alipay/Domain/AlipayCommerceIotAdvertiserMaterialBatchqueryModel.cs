using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserMaterialBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotAdvertiserMaterialBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 查询总数
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
