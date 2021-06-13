using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceSportsCheerResultConfirmResponse.
    /// </summary>
    public class AlipayCommerceSportsCheerResultConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 用户流水号
        /// </summary>
        [JsonPropertyName("game_serial_number")]
        public string GameSerialNumber { get; set; }
    }
}
