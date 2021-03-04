using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarMaintainBizorderCreateResponse.
    /// </summary>
    public class AlipayEcoMycarMaintainBizorderCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 业务订单编号，规则28位；
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }
    }
}
