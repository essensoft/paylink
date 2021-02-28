using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 收款信息
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_15.shtml">查询支付分订单API</a> - 最新更新时间：2020.05.25</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_17.shtml">修改订单金额API</a> - 最新更新时间：2020.03.05</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_20.shtml">同步服务订单信息API</a> - 最新更新时间：2020.03.05</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_22.shtml">支付成功回调通知API</a> - 最新更新时间：2020.05.25</para>
    /// </remarks>
    public class Collection : WeChatPayObject
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
        public long? TotalAmount { get; set; }

        /// <summary>
        /// 待收金额
        /// </summary>
        /// <remarks>
        /// 等待用户付款金额，只能为整数，详见支付金额。
        /// 示例值：40000
        /// </remarks>
        [JsonPropertyName("paying_amount")]
        public long? PayingAmount { get; set; }

        /// <summary>
        /// 已收金额
        /// </summary>
        /// <remarks>
        /// 用户已付款的金额，只能为整数，详见支付金额。
        /// 示例值：10000
        /// </remarks>
        [JsonPropertyName("paid_amount")]
        public long? PaidAmount { get; set; }

        /// <summary>
        /// 收款明细列表
        /// </summary>
        [JsonPropertyName("details")]
        public List<CollectionDetail> Details { get; set; }
    }
}
