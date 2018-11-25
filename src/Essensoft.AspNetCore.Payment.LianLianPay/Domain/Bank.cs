using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Domain
{
    public class Bank
    {
        /// <summary>
        /// 银行编号
        /// </summary>
        [JsonProperty("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 银行名称
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
        /// 单笔限额
        /// 单位 元 整数数字
        /// 最大限额 90000000，需商户前端自行处理
        /// </summary>
        [JsonProperty("single_amt")]
        public string SingleAmt { get; set; }

        /// <summary>
        /// 单日限额
        /// 单位 元 整数数字 
        /// 最大限额 90000000，需商户前端自行处理
        /// </summary>
        [JsonProperty("day_amt")]
        public string DayAmt { get; set; }

        /// <summary>
        /// 单月限额
        /// 单位 元 整数数字 
        /// 最大限额 90000000，需商户前端自行处理
        /// </summary>
        [JsonProperty("month_amt")]
        public string MonthAmt { get; set; }

        /// <summary>
        /// 银行状态
        /// 0：正常
        /// 2：维护中
        /// </summary>
        [JsonProperty("bank_status")]
        public string BankStatus { get; set; }
    }
}
