using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TradeSettleDetail Data Structure.
    /// </summary>
    public class TradeSettleDetail : AlipayObject
    {
        /// <summary>
        /// 实际操作金额，单位为元，两位小数。该参数的值为分账或补差或结算时传入
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 操作日期
        /// </summary>
        [JsonPropertyName("operation_dt")]
        public string OperationDt { get; set; }

        /// <summary>
        /// 商户操作序列号。商户发起请求的外部请求号。
        /// </summary>
        [JsonPropertyName("operation_serial_no")]
        public string OperationSerialNo { get; set; }

        /// <summary>
        /// 结算操作类型。包含replenish、replenish_refund、transfer、transfer_refund等类型
        /// </summary>
        [JsonPropertyName("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 转入账号
        /// </summary>
        [JsonPropertyName("trans_in")]
        public string TransIn { get; set; }

        /// <summary>
        /// 转出账号
        /// </summary>
        [JsonPropertyName("trans_out")]
        public string TransOut { get; set; }
    }
}
