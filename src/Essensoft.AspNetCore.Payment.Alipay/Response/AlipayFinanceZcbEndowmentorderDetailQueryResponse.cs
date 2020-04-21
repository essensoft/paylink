using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFinanceZcbEndowmentorderDetailQueryResponse.
    /// </summary>
    public class AlipayFinanceZcbEndowmentorderDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// order_list：查询出来的养老险指定产品的订单列表，EndowmentOrder模型包含：orderId，applyAmount，payTime，taRrequestId 4个字段
        /// </summary>
        [JsonPropertyName("order_list")]
        public List<EndowmentOrder> OrderList { get; set; }

        /// <summary>
        /// total_amount:按照时间区间查询出的订单金额总和，可以用来跟查询出来的明细列表的金额进行核对以发现问题
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// total_count:按照时间区间查询出的订单的总笔数，可以根据该字段与明细列表的笔数进行对比，可以用来发现返回数据笔数是否有问题
        /// </summary>
        [JsonPropertyName("total_count")]
        public string TotalCount { get; set; }
    }
}
