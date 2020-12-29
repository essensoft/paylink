using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AbilityPageQueryDTO Data Structure.
    /// </summary>
    public class AbilityPageQueryDTO : AlipayObject
    {
        /// <summary>
        /// 搜索运营列表的分页数据
        /// </summary>
        [JsonPropertyName("page_data")]
        public List<SearchAbilityOrderData> PageData { get; set; }

        /// <summary>
        /// 当前页码，默认第一页
        /// </summary>
        [JsonPropertyName("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页记录数，默认10
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        [JsonPropertyName("total_number")]
        public long TotalNumber { get; set; }
    }
}
