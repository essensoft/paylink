using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// TransactionRequest Data Structure.
    /// </summary>
    public class TransactionRequest : AlipayObject
    {
        /// <summary>
        /// 业务透传字段
        /// </summary>
        [JsonPropertyName("biz_extend_info")]
        public string BizExtendInfo { get; set; }

        /// <summary>
        /// 下游唯一单号
        /// </summary>
        [JsonPropertyName("ref_transfer_id")]
        public string RefTransferId { get; set; }

        /// <summary>
        /// 结算金额
        /// </summary>
        [JsonPropertyName("settle_amount")]
        public TransferAmount SettleAmount { get; set; }
    }
}
