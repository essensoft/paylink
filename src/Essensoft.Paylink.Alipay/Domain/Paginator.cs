using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// Paginator Data Structure.
    /// </summary>
    public class Paginator : AlipayObject
    {
        /// <summary>
        /// 页码
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录数, 最大值只能是10
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总记录数, 作为参数时该值不需要填写, 填写将被忽略
        /// </summary>
        [JsonPropertyName("total_items")]
        public long TotalItems { get; set; }
    }
}
