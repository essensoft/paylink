using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialAntforestAccountTransferResponse.
    /// </summary>
    public class AlipaySocialAntforestAccountTransferResponse : AlipayResponse
    {
        /// <summary>
        /// 业务完成的时间，即单据的流水号生成时间，业务方可与transfer_id一同存储，后续账账核对的时候可以用于解决跨天问题
        /// </summary>
        [JsonPropertyName("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 转账之后用户现有账户的剩余可用能量
        /// </summary>
        [JsonPropertyName("current_energy")]
        public long CurrentEnergy { get; set; }

        /// <summary>
        /// 用于表示用户一次转账的相关单据号，可通过该单据进行能量账户的退款操作（逆向转移），可能会需要下游进行存储
        /// </summary>
        [JsonPropertyName("transfer_id")]
        public string TransferId { get; set; }
    }
}
