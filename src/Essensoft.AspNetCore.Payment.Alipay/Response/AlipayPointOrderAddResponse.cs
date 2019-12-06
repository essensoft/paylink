using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPointOrderAddResponse.
    /// </summary>
    public class AlipayPointOrderAddResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝集分宝发放流水号
        /// </summary>
        [JsonPropertyName("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 此参数已废弃。
        /// </summary>
        [JsonPropertyName("result_code")]
        public bool ResultCode { get; set; }
    }
}
