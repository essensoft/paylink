using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Domain
{
    public class Agreement
    {
        /// <summary>
        /// 签约协议号。
        /// 用户以签约支付API或者签约API成功进行签约后，连连下发的永久令牌。
        /// </summary>
        [JsonProperty("no_agree")]
        public string NoAgree { get; set; }

        /// <summary>
        /// 用户银行卡卡号，仅返回后4位。
        /// </summary>
        [JsonProperty("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 银行编号。
        /// </summary>
        [JsonProperty("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 所属银行名称。
        /// </summary>
        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 银行卡类型。
        /// 2 - 储蓄卡。
        /// 3 - 信用卡。
        /// </summary>
        [JsonProperty("card_type")]
        public string CardType { get; set; }
    }
}
