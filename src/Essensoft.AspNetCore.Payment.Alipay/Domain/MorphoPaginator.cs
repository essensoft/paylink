using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MorphoPaginator Data Structure.
    /// </summary>
    public class MorphoPaginator : AlipayObject
    {
        /// <summary>
        /// 总页数
        /// </summary>
        [JsonPropertyName("page_count")]
        public long PageCount { get; set; }

        /// <summary>
        /// 分页查询页码
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询分页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}
