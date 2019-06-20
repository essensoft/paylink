using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SettleCardInfoKt Data Structure.
    /// </summary>
    [Serializable]
    public class SettleCardInfoKt : AlipayObject
    {
        /// <summary>
        /// 开户支行名
        /// </summary>
        [JsonProperty("account_branch_name")]
        public string AccountBranchName { get; set; }

        /// <summary>
        /// 卡户名
        /// </summary>
        [JsonProperty("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// 开户行所在地-市
        /// </summary>
        [JsonProperty("account_inst_city")]
        public string AccountInstCity { get; set; }

        /// <summary>
        /// 开户行简称缩写
        /// </summary>
        [JsonProperty("account_inst_id")]
        public string AccountInstId { get; set; }

        /// <summary>
        /// 银行名称
        /// </summary>
        [JsonProperty("account_inst_name")]
        public string AccountInstName { get; set; }

        /// <summary>
        /// 开户行所在地-省
        /// </summary>
        [JsonProperty("account_inst_province")]
        public string AccountInstProvince { get; set; }

        /// <summary>
        /// 银行卡号
        /// </summary>
        [JsonProperty("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 卡类型&#160;&#8232;借记卡-DC&#160;&#8232;信用卡-CC
        /// </summary>
        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 联行号,对公账号需填写
        /// </summary>
        [JsonProperty("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 账号使用类型&#160;&#8232;对公-01&#160;&#8232;对私-02
        /// </summary>
        [JsonProperty("usage_type")]
        public string UsageType { get; set; }
    }
}
