using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasRemitBeneficialinfoCertifyModel Data Structure.
    /// </summary>
    public class AlipayOverseasRemitBeneficialinfoCertifyModel : AlipayObject
    {
        /// <summary>
        /// 中文名
        /// </summary>
        [JsonPropertyName("chinese_full_name")]
        public string ChineseFullName { get; set; }

        /// <summary>
        /// 用户的名，拼音
        /// </summary>
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// 用户的姓，拼音
        /// </summary>
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// 登录ID
        /// </summary>
        [JsonPropertyName("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 用户中间的名字
        /// </summary>
        [JsonPropertyName("middle_name")]
        public string MiddleName { get; set; }

        /// <summary>
        /// 汇款金额
        /// </summary>
        [JsonPropertyName("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 汇款金额的币种
        /// </summary>
        [JsonPropertyName("order_currency")]
        public string OrderCurrency { get; set; }

        /// <summary>
        /// 接收端的mid
        /// </summary>
        [JsonPropertyName("receiver_mid")]
        public string ReceiverMid { get; set; }

        /// <summary>
        /// 发端的mid
        /// </summary>
        [JsonPropertyName("sender_mid")]
        public string SenderMid { get; set; }
    }
}
