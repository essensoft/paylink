using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VehicleSettleInfo Data Structure.
    /// </summary>
    public class VehicleSettleInfo : AlipayObject
    {
        /// <summary>
        /// 结算的金额，单位为元。目前必须和交易金额相同
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 结算汇总维度，按照这个维度汇总成批次结算，由商户指定。  目前需要和结算收款方账户类型为cardAliasNo配合使用
        /// </summary>
        [JsonPropertyName("summary_dimension")]
        public string SummaryDimension { get; set; }

        /// <summary>
        /// 结算收款方。当结算收款方类型是cardAliasNo时，本参数为用户在支付宝绑定的卡编号；结算收款方类型是userId时，本参数为用户的支付宝账号对应的支付宝唯一用户号，以2088开头的纯16位数字；当结算收款方类型是loginName时，本参数为用户的支付宝登录号
        /// </summary>
        [JsonPropertyName("trans_in")]
        public string TransIn { get; set; }

        /// <summary>
        /// 结算收款方的账户类型。  cardAliasNo：结算收款方的银行卡编号;  userId：表示是支付宝账号对应的支付宝唯一用户号;  loginName：表示是支付宝登录号；
        /// </summary>
        [JsonPropertyName("trans_in_type")]
        public string TransInType { get; set; }
    }
}
