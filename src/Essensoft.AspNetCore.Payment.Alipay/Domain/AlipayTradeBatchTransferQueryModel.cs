using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeBatchTransferQueryModel Data Structure.
    /// </summary>
    public class AlipayTradeBatchTransferQueryModel : AlipayObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 批量结算时传入的外部流水号，与settle_no二者必填其一。 out_request_no和settle_no如果同时存在，优先取settle_no
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 结算单据号，与out_request_no二者必填其一
        /// </summary>
        [JsonPropertyName("settle_no")]
        public string SettleNo { get; set; }
    }
}
