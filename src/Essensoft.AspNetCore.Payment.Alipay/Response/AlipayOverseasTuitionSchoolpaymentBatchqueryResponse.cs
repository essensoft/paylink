using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTuitionSchoolpaymentBatchqueryResponse.
    /// </summary>
    public class AlipayOverseasTuitionSchoolpaymentBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商户在支付宝开设的账号ID
        /// </summary>
        [JsonPropertyName("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 查询缴费订单的返回总数
        /// </summary>
        [JsonPropertyName("payment_order_count")]
        public string PaymentOrderCount { get; set; }

        /// <summary>
        /// 缴费订单列表
        /// </summary>
        [JsonPropertyName("payment_orders")]
        public List<TuitionInremitOrder> PaymentOrders { get; set; }

        /// <summary>
        /// 学校批量查询结果状态
        /// </summary>
        [JsonPropertyName("result")]
        public SchoolBatchQueryResult Result { get; set; }
    }
}
