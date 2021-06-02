using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 退款出资账户及金额
    /// </summary>
    public class RefundAmountFrom : WeChatPayObject
    {
        /// <summary>
        /// 出资账户类型
        /// </summary>
        /// <remarks>
        /// 下面枚举值多选一。
        /// 枚举值：
        /// AVAILABLE : 可用余额
        /// UNAVAILABLE : 不可用余额
        /// <para>示例值：AVAILABLE</para>
        /// </remarks>
        [JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// 出资金额
        /// </summary>
        /// <remarks>
        /// 出资金额
        /// <para>示例值：444</para>
        /// </remarks>
        [JsonPropertyName("amount")]
        public int Amount { get; set; }
    }
}
