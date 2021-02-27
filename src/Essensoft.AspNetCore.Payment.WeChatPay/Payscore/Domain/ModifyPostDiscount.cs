using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Domain
{
    public class ModifyPostDiscount : PostDiscount
    {
        /// <summary>
        /// 优惠金额       
        /// </summary>
        /// <remarks>
        /// 优惠金额；单位为分，只能为整数，详见支付金额。
        /// 示例值：100
        /// </remarks>
        [JsonPropertyName("name")]
        public long Amount { get; set; }
    }
}
