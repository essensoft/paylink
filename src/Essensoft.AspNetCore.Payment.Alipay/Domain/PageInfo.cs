using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PageInfo Data Structure.
    /// </summary>
    public class PageInfo : AlipayObject
    {
        /// <summary>
        /// 分页查询当前页
        /// </summary>
        [JsonPropertyName("current")]
        public long Current { get; set; }

        /// <summary>
        /// 分页查询单页记录数
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 创意总数
        /// </summary>
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}
