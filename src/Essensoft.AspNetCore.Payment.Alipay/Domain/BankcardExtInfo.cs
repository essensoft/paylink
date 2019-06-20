using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BankcardExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BankcardExtInfo : AlipayObject
    {
        /// <summary>
        /// 收款账户类型。  1：对公（在金融机构开设的公司账户）,如果银行卡为对公，必须传递省市支行信息或者联行号  2：对私（在金融机构开设的个人账户）
        /// </summary>
        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 银行支行联行号
        /// </summary>
        [JsonProperty("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 收款银行所属支行
        /// </summary>
        [JsonProperty("inst_branch_name")]
        public string InstBranchName { get; set; }

        /// <summary>
        /// 收款银行所在市
        /// </summary>
        [JsonProperty("inst_city")]
        public string InstCity { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        [JsonProperty("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 银行所在省份
        /// </summary>
        [JsonProperty("inst_province")]
        public string InstProvince { get; set; }
    }
}
