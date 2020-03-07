using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiAuthOrderCloseResponse.
    /// </summary>
    public class AlipayPcreditHuabeiAuthOrderCloseResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝侧花呗冻结解冻操作单据id
        /// </summary>
        [JsonPropertyName("auth_opt_id")]
        public string AuthOptId { get; set; }

        /// <summary>
        /// 商户本次操作的请求流水号
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
