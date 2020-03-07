using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradeWapMergePayResponse.
    /// </summary>
    public class AlipayTradeWapMergePayResponse : AlipayResponse
    {
        /// <summary>
        /// 如果和支付宝约定子订单必须同时支付成功或者同时失败时此参数才存在，取值有以下两种：  1. FINISHED：全部订单付款成功  2. CLOSED：全部订单付款失败
        /// </summary>
        [JsonPropertyName("merge_pay_status")]
        public string MergePayStatus { get; set; }

        /// <summary>
        /// 合并子订单中所有订单的支付结果信息
        /// </summary>
        [JsonPropertyName("order_detail_results")]
        public List<OrderDetailResult> OrderDetailResults { get; set; }

        /// <summary>
        /// 如果和支付宝约定子订单必须同时支付成功或者同时失败并且请求时传递了`out_merge_no`时才存在
        /// </summary>
        [JsonPropertyName("out_merge_no")]
        public string OutMergeNo { get; set; }
    }
}
