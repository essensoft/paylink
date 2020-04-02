using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBusinessPaymenthubQueryResponse.
    /// </summary>
    public class AlipayBusinessPaymenthubQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付，打款或者退款的操作金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 聚合支付的支付渠道，支付宝分配。
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 支付、打款、退款时候支付宝返回的唯一凭证id，调用方查询时候建议优先传入该值，内部处理时优先以该值为准。instruction_id和out_request_no不能同时为空。
        /// </summary>
        [JsonPropertyName("instruction_id")]
        public string InstructionId { get; set; }

        /// <summary>
        /// 指令类型，表明该笔查询是支付，打款还是退款，跟out_request_no一起使用。  支付：PAY  打款：DISBURSE  退款：REFUND
        /// </summary>
        [JsonPropertyName("instruction_type")]
        public string InstructionType { get; set; }

        /// <summary>
        /// 支付、打款或退款请求号，out_request_no和instruction_id不能同时为空。
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 支付，打款或者退款的状态，目前支持如下值： WAIT（指令操作已受理）； SUCCESS（指令操作成功）； FAIL（指令操作失败）。
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
