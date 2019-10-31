using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasRemitBeneficialinfoCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasRemitBeneficialinfoCertifyModel : AlipayObject
    {
        /// <summary>
        /// 中文名
        /// </summary>
        [JsonProperty("chinese_full_name")]
        public string ChineseFullName { get; set; }

        /// <summary>
        /// 用户的名，拼音
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// 用户的姓，拼音
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// 登录ID
        /// </summary>
        [JsonProperty("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 用户中间的名字
        /// </summary>
        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        /// <summary>
        /// 汇款金额
        /// </summary>
        [JsonProperty("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 汇款金额的币种
        /// </summary>
        [JsonProperty("order_currency")]
        public string OrderCurrency { get; set; }

        /// <summary>
        /// 接收端的mid
        /// </summary>
        [JsonProperty("receiver_mid")]
        public string ReceiverMid { get; set; }

        /// <summary>
        /// 发端的mid
        /// </summary>
        [JsonProperty("sender_mid")]
        public string SenderMid { get; set; }
    }
}
