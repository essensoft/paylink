using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsAutoCarSaveResponse.
    /// </summary>
    public class AlipayInsAutoCarSaveResponse : AlipayResponse
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonPropertyName("car_no")]
        public string CarNo { get; set; }
    }
}
