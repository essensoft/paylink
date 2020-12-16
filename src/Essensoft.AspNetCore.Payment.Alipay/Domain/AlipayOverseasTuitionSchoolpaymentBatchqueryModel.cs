using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTuitionSchoolpaymentBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayOverseasTuitionSchoolpaymentBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// ISV入驻签约PID
        /// </summary>
        [JsonPropertyName("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 一次最多输入100个订单组
        /// </summary>
        [JsonPropertyName("payment_orders")]
        public List<TuitionQueryOrder> PaymentOrders { get; set; }
    }
}
