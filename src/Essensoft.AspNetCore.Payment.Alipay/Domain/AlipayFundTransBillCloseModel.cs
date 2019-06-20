using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransBillCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransBillCloseModel : AlipayObject
    {
        /// <summary>
        /// 支付宝转账单据号
        /// </summary>
        [JsonProperty("transfer_no")]
        public string TransferNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
