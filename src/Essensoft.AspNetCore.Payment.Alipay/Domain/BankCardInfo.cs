using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BankCardInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BankCardInfo : AlipayObject
    {
        /// <summary>
        /// 银行开户行名称。填写支行名称。
        /// </summary>
        [JsonProperty("bank_branch_name")]
        public string BankBranchName { get; set; }

        /// <summary>
        /// 银行卡持卡人姓名
        /// </summary>
        [JsonProperty("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 银行卡号
        /// </summary>
        [JsonProperty("card_no")]
        public string CardNo { get; set; }
    }
}
