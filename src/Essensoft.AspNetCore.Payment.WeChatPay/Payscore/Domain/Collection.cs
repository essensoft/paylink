using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Domain
{
    /// <summary>
    /// 收款信息，非0元完结后返回
    /// </summary>
    public class Collection
    {
        /// <summary>
        /// 收款状态
        /// </summary>
        /// <remarks>
        /// USER_PAYING：待支付
        /// USER_PAID：已支付
        /// 示例值：USER_PAID
        /// </remarks>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// 总收款金额
        /// </summary>
        /// <remarks>
        /// 总金额，大于等于0的数字，单位为分，只能为整数，详见支付金额。
        /// 此参数需满足：总金额=付费项目金额之和-商户优惠项目金额之和，且小于等于订单风险金额 。未使用服务、取消订单时，该字段必须为0。
        /// 示例值：50000
        /// </remarks>
        [JsonPropertyName("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        /// 待收金额
        /// </summary>
        /// <remarks>
        /// 等待用户付款金额，只能为整数，详见支付金额。
        /// 示例值：40000
        /// </remarks>
        [JsonPropertyName("paying_amount")]
        public long PayingAmount { get; set; }

        /// <summary>
        /// 已收金额
        /// </summary>
        /// <remarks>
        /// 用户已付款的金额，只能为整数，详见支付金额。
        /// 示例值：10000
        /// </remarks>
        [JsonPropertyName("paid_amount")]
        public long PaidAmount { get; set; }

        /// <summary>
        /// 收款明细
        /// </summary>
        [JsonPropertyName("details")]
        public List<CollectionDetail> Details { get; set; }
    }
}
