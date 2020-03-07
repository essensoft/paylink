using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditSupplychainInventoryOutConsultResponse.
    /// </summary>
    public class MybankCreditSupplychainInventoryOutConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 警戒额度
        /// </summary>
        [JsonPropertyName("alert_amt")]
        public string AlertAmt { get; set; }

        /// <summary>
        /// 标识客户的当前贷款状态
        /// </summary>
        [JsonPropertyName("arg_status")]
        public string ArgStatus { get; set; }

        /// <summary>
        /// CONTROL 可以出库  BAN 禁止出库  WARNING 达到警戒比例（此时也可以出库）
        /// </summary>
        [JsonPropertyName("controll_status")]
        public string ControllStatus { get; set; }

        /// <summary>
        /// 授信额度
        /// </summary>
        [JsonPropertyName("credit_amt")]
        public string CreditAmt { get; set; }

        /// <summary>
        /// 待还正常利息
        /// </summary>
        [JsonPropertyName("normal_int_amt")]
        public string NormalIntAmt { get; set; }

        /// <summary>
        /// 待还逾期利息
        /// </summary>
        [JsonPropertyName("ovd_int_amt")]
        public string OvdIntAmt { get; set; }

        /// <summary>
        /// 待还逾期利息罚息
        /// </summary>
        [JsonPropertyName("ovd_int_pen_int_amt")]
        public string OvdIntPenIntAmt { get; set; }

        /// <summary>
        /// 待还逾期本金罚息
        /// </summary>
        [JsonPropertyName("ovd_prin_pen_int_amt")]
        public string OvdPrinPenIntAmt { get; set; }

        /// <summary>
        /// 待还款本金
        /// </summary>
        [JsonPropertyName("prin_amt")]
        public string PrinAmt { get; set; }

        /// <summary>
        /// 实际待还款总金额=待还款本金+所有利息(正常利息+逾期利息+逾期本金罚息+逾期利息罚息)
        /// </summary>
        [JsonPropertyName("repay_amt")]
        public string RepayAmt { get; set; }

        /// <summary>
        /// 水位额度
        /// </summary>
        [JsonPropertyName("water_level_amt")]
        public string WaterLevelAmt { get; set; }
    }
}
