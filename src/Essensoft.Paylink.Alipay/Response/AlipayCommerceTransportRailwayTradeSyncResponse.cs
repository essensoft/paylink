using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportRailwayTradeSyncResponse.
    /// </summary>
    public class AlipayCommerceTransportRailwayTradeSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 扩展信息，json格式，由双方约定取值
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 同步成功的账单数据ID
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 发生异常时的错误码，发生异常时非空
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 发生异常时的错误信息，发生异常时非空
        /// </summary>
        [JsonPropertyName("result_msg")]
        public string ResultMsg { get; set; }
    }
}
