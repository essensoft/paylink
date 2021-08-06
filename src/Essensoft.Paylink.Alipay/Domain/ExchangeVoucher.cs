using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ExchangeVoucher Data Structure.
    /// </summary>
    public class ExchangeVoucher : AlipayObject
    {
        /// <summary>
        /// 券的价值  限制： 币种为人民币，单位为元。小数点以后最多保留两位。  取值范围:0.1<=x<=3000
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 客服电话  限制: 客服电话和客服链接必须二选一
        /// </summary>
        [JsonPropertyName("customer_service_mobile")]
        public string CustomerServiceMobile { get; set; }

        /// <summary>
        /// 客服链接  限制: 客服电话和客服链接必须二选一
        /// </summary>
        [JsonPropertyName("customer_service_url")]
        public string CustomerServiceUrl { get; set; }

        /// <summary>
        /// 优惠门槛金额，表示只有当订单金额大于等于门槛金额时券才能使用。该字段为空时表示无门槛。 门槛金额的校验由服务商(商户)核销时自行校验，支付宝侧只做展示使用。  币种为人民币，单位为元。小数点以后最多保留两位。   设置门槛：取值范围:0.1<=x<= 50000。 如果设置了门槛金额，则必须大于等于0.1，不可以等于0
        /// </summary>
        [JsonPropertyName("floor_amount")]
        public string FloorAmount { get; set; }

        /// <summary>
        /// 购买的优惠券是否允许退款。  不填默认否，枚举值： true：是 false：否
        /// </summary>
        [JsonPropertyName("refundable")]
        public bool Refundable { get; set; }

        /// <summary>
        /// 用户购买优惠券需要支付的金额 限制： 币种为人民币，单位为元。小数点以后最多保留两位。  取值范围:0.1<=x<=3000
        /// </summary>
        [JsonPropertyName("sale_amount")]
        public string SaleAmount { get; set; }

        /// <summary>
        /// 领(购)券详情页链接，从支付宝公域跳转到服务商(商户)自定义领(购)券详情页。
        /// </summary>
        [JsonPropertyName("voucher_detail_url")]
        public string VoucherDetailUrl { get; set; }

        /// <summary>
        /// 对消费者展示的券(商品)名称。
        /// </summary>
        [JsonPropertyName("voucher_name")]
        public string VoucherName { get; set; }
    }
}
