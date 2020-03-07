using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntfortuneYebInfoAdvertisingQueryResponse.
    /// </summary>
    public class AntfortuneYebInfoAdvertisingQueryResponse : AlipayResponse
    {
        /// <summary>
        /// advertising_type：广告投放类型。  目前值为00或01。  00:表示进行投放。  01:表示不进行投放。
        /// </summary>
        [JsonPropertyName("advertising_type")]
        public string AdvertisingType { get; set; }
    }
}
