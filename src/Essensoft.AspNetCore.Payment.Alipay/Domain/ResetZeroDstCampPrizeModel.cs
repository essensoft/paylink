using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ResetZeroDstCampPrizeModel Data Structure.
    /// </summary>
    public class ResetZeroDstCampPrizeModel : AlipayObject
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
        /// 单笔上限金额只能填写数字，大于等于0，小数点后最多2位，整数部分不能超过5位
        /// </summary>
        [JsonPropertyName("max_discount_amt")]
        public string MaxDiscountAmt { get; set; }

        /// <summary>
        /// 对应的值分别为100,1000,10000,100000  小数点取整，交易金额必须大于1元，最大优惠幅度0.99元，EG：交易金额1.36元，取整后优惠后金额为1元  个位数取整，交易金额必须大于10元，最大优惠幅度9.99元，EG：交易金额13.56元，取整后优惠后金额为10元  十位数取整，交易金额必须大于100元，最大优惠幅度99.99元，EG：交易金额125.56元，取整后优惠后金额为100元  百位数取整，交易金额必须大于1000元，最大优惠幅度999.99元，EG：交易金额1125.56元，取整后优惠后金额为1000元
        /// </summary>
        [JsonPropertyName("reset_zero_amt")]
        public string ResetZeroAmt { get; set; }
    }
}
