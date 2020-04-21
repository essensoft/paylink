using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcardEduDepositOrderAddResponse.
    /// </summary>
    public class AlipayEcardEduDepositOrderAddResponse : AlipayResponse
    {
        /// <summary>
        /// 支付申请流水号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }
    }
}
