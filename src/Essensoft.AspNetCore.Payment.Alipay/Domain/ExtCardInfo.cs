using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExtCardInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExtCardInfo : AlipayObject
    {
        /// <summary>
        /// 托管子户外卡户名
        /// </summary>
        [JsonProperty("bank_acc_name")]
        public string BankAccName { get; set; }

        /// <summary>
        /// 托管子户外卡开户行
        /// </summary>
        [JsonProperty("card_bank")]
        public string CardBank { get; set; }

        /// <summary>
        /// 托管子户外卡支行
        /// </summary>
        [JsonProperty("card_branch")]
        public string CardBranch { get; set; }

        /// <summary>
        /// 托管子户外卡联行号
        /// </summary>
        [JsonProperty("card_deposit")]
        public string CardDeposit { get; set; }

        /// <summary>
        /// 托管子户外卡开户地址
        /// </summary>
        [JsonProperty("card_location")]
        public string CardLocation { get; set; }

        /// <summary>
        /// 托管子户的外卡卡号
        /// </summary>
        [JsonProperty("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 托管子户外卡状态
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
