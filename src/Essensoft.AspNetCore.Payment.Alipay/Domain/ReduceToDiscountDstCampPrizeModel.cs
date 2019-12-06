using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ReduceToDiscountDstCampPrizeModel Data Structure.
    /// </summary>
    public class ReduceToDiscountDstCampPrizeModel : AlipayObject
    {
        /// <summary>
        /// 折扣预算ID
        /// </summary>
        [JsonPropertyName("budget_id")]
        public string BudgetId { get; set; }

        /// <summary>
        /// 奖品id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 单次优惠上限(元)
        /// </summary>
        [JsonPropertyName("max_discount_amt")]
        public string MaxDiscountAmt { get; set; }

        /// <summary>
        /// 折扣幅度减至必须为0.3到1之间的小数(保留小数点后2位)
        /// </summary>
        [JsonPropertyName("reduce_to_discount_rate")]
        public string ReduceToDiscountRate { get; set; }
    }
}
