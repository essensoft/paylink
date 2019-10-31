using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditLoanapplyQrcodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoanapplyQrcodeCreateModel : AlipayObject
    {
        /// <summary>
        /// 银行账户的类型，1 : 对私账户 2：对公账户
        /// </summary>
        [JsonProperty("bank_card_category")]
        public string BankCardCategory { get; set; }

        /// <summary>
        /// 收款账户的银行卡卡号
        /// </summary>
        [JsonProperty("beneficiary_account")]
        public string BeneficiaryAccount { get; set; }

        /// <summary>
        /// 银行账户的名称
        /// </summary>
        [JsonProperty("beneficiary_name")]
        public string BeneficiaryName { get; set; }

        /// <summary>
        /// 支行名称
        /// </summary>
        [JsonProperty("deposit_bank")]
        public string DepositBank { get; set; }

        /// <summary>
        /// 开户行的联行号
        /// </summary>
        [JsonProperty("deposit_bank_cnaps_code")]
        public string DepositBankCnapsCode { get; set; }

        /// <summary>
        /// 总行联行号
        /// </summary>
        [JsonProperty("head_bank_cnaps_code")]
        public string HeadBankCnapsCode { get; set; }

        /// <summary>
        /// 二维码失效的时间
        /// </summary>
        [JsonProperty("invalid_date")]
        public string InvalidDate { get; set; }

        /// <summary>
        /// 订单金额字符串，必须为整数（单位：元）
        /// </summary>
        [JsonProperty("order_amt")]
        public string OrderAmt { get; set; }

        /// <summary>
        /// 调用方生成的订单编号
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }
    }
}
