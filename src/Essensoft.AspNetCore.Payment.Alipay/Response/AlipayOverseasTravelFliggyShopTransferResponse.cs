using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTravelFliggyShopTransferResponse.
    /// </summary>
    public class AlipayOverseasTravelFliggyShopTransferResponse : AlipayResponse
    {
        /// <summary>
        /// 响应数据
        /// </summary>
        [JsonPropertyName("result_data")]
        public string ResultData { get; set; }
    }
}
