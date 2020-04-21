using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundTransDishonorQueryResponse.
    /// </summary>
    public class AlipayFundTransDishonorQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 退票订单详细列表：可能包含多个退票订单信息。如items值为0,则此参数不返回。
        /// </summary>
        [JsonPropertyName("dishonor_order_list")]
        public List<DishonorOrder> DishonorOrderList { get; set; }

        /// <summary>
        /// 符合条件总记录数：大于等于0。
        /// </summary>
        [JsonPropertyName("items")]
        public string Items { get; set; }

        /// <summary>
        /// 每页记录数：大于等于1
        /// </summary>
        [JsonPropertyName("items_per_page")]
        public string ItemsPerPage { get; set; }

        /// <summary>
        /// 查询页号：大于等于1
        /// </summary>
        [JsonPropertyName("page")]
        public string Page { get; set; }
    }
}
