using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Domain
{
    public class Agreement
    {
        /// <summary>
        /// 签约协议号
        /// 银行卡签约的唯一编号
        /// </summary>
        [JsonProperty("no_agree")]
        public string NoAgree { get; set; }

        /// <summary>
        /// 银行卡号后4位
        /// </summary>
        [JsonProperty("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 所属银行编号
        /// </summary>
        [JsonProperty("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 所属银行名称
        /// </summary>
        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 银行卡类型
        /// 2-储蓄卡  3-信用卡 
        /// </summary>
        [JsonProperty("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 绑定手机号码
        /// 手机号码
        /// </summary>
        [JsonProperty("bind_mobile")]
        public string BindMobile { get; set; }
    }
}
