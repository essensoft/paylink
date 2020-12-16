using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditSupplychainCreditpayOrderQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainCreditpayOrderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 每页的条目数量
        /// </summary>
        [JsonPropertyName("items_per_page")]
        public long ItemsPerPage { get; set; }

        /// <summary>
        /// 是否存在下一页数据
        /// </summary>
        [JsonPropertyName("next_page")]
        public bool NextPage { get; set; }

        /// <summary>
        /// 订单列表
        /// </summary>
        [JsonPropertyName("order_vo_list")]
        public List<OrderVO> OrderVoList { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [JsonPropertyName("page")]
        public List<long> Page { get; set; }
    }
}
