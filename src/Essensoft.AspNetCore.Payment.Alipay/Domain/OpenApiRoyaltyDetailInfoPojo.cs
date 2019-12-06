using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OpenApiRoyaltyDetailInfoPojo Data Structure.
    /// </summary>
    public class OpenApiRoyaltyDetailInfoPojo : AlipayObject
    {
        /// <summary>
        /// 分账的金额，单位为元
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 分账信息中分账百分比。取值范围为大于0，少于或等于100的整数。
        /// </summary>
        [JsonPropertyName("amount_percentage")]
        public long AmountPercentage { get; set; }

        /// <summary>
        /// 分账描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 分账类型.  普通分账为：transfer;  补差为：replenish;  为空默认为分账transfer;
        /// </summary>
        [JsonPropertyName("royalty_type")]
        public string RoyaltyType { get; set; }

        /// <summary>
        /// 收入方账户。如果收入方账户类型为userId，本参数为收入方的支付宝账号对应的支付宝唯一用户号，以2088开头的纯16位数字；如果收入方类型为cardAliasNo，本参数为收入方在支付宝绑定的卡编号；如果收入方类型为loginName，本参数为收入方的支付宝登录号；
        /// </summary>
        [JsonPropertyName("trans_in")]
        public string TransIn { get; set; }

        /// <summary>
        /// 收入方账户类型。userId表示是支付宝账号对应的支付宝唯一用户号;cardAliasNo表示是卡编号;loginName表示是支付宝登录号；
        /// </summary>
        [JsonPropertyName("trans_in_type")]
        public string TransInType { get; set; }

        /// <summary>
        /// 支出方账户。如果支出方账户类型为userId，本参数为支出方的支付宝账号对应的支付宝唯一用户号，以2088开头的纯16位数字；如果支出方类型为loginName，本参数为支出方的支付宝登录号；
        /// </summary>
        [JsonPropertyName("trans_out")]
        public string TransOut { get; set; }

        /// <summary>
        /// 支出方账户类型。userId表示是支付宝账号对应的支付宝唯一用户号;loginName表示是支付宝登录号；
        /// </summary>
        [JsonPropertyName("trans_out_type")]
        public string TransOutType { get; set; }
    }
}
