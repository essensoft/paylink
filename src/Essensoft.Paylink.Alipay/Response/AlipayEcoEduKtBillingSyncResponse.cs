using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEcoEduKtBillingSyncResponse.
    /// </summary>
    public class AlipayEcoEduKtBillingSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 教育缴费平台的账单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }
    }
}
