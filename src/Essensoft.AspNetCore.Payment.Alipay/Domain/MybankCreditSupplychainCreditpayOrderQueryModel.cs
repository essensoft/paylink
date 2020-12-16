using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSupplychainCreditpayOrderQueryModel Data Structure.
    /// </summary>
    public class MybankCreditSupplychainCreditpayOrderQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝Id
        /// </summary>
        [JsonPropertyName("custom_info")]
        public Member CustomInfo { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 分页查询的每页数据数量
        /// </summary>
        [JsonPropertyName("items_per_page")]
        public long ItemsPerPage { get; set; }

        /// <summary>
        /// 页数，从1-N
        /// </summary>
        [JsonPropertyName("page")]
        public long Page { get; set; }

        /// <summary>
        /// 赊呗内部方案，调用方向服务提供方申请
        /// </summary>
        [JsonPropertyName("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 查询订单状态,淘宝拍卖场景【ONWAY在途，CRATE投标中，VALID中标，CANCEL未中标，CLEAR已还款】
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 交易来源
        /// </summary>
        [JsonPropertyName("trade_source")]
        public string TradeSource { get; set; }
    }
}
