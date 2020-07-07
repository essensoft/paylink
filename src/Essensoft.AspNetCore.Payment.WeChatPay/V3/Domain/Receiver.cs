using System;
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
        /// MERCHANT_ID：商户ID
        /// </summary>
        [JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// 分账接收方帐号
        /// 申请本功能商户号
        /// </summary>
        [JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// 分账动账金额
        /// 分账动账金额，单位为分，只能为整数
        /// </summary>
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 分账/回退描述
        /// 分账/回退描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 成功时间
        /// 成功时间，Rfc3339标准
        /// </summary>
        [JsonPropertyName("success_time")]
        public DateTimeOffset SuccessTime { get; set; }
    }
}
