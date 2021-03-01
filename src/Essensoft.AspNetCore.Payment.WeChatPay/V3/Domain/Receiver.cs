using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 分账接收方对象
    /// </summary>
    public class Receiver : WeChatPayObject
    {
        /// <summary>
        /// 分账接收方类型
        /// </summary>
        /// <remarks>
        /// MERCHANT_ID：商户ID
        /// </remarks>
        [JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// 分账接收方帐号
        /// </summary>
        /// <remarks>
        /// 申请本功能商户号
        /// </remarks>
        [JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// 分账动账金额
        /// </summary>
        /// <remarks>
        /// 分账动账金额，单位为分，只能为整数
        /// </remarks>
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 分账/回退描述
        /// </summary>
        /// <remarks>
        /// 分账/回退描述
        /// </remarks>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 成功时间
        /// </summary>
        /// <remarks>
        /// 成功时间，Rfc3339标准
        /// </remarks>
        [JsonPropertyName("success_time")]
        public string SuccessTime { get; set; }
    }
}
