using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotWifiResultQueryResponse.
    /// </summary>
    public class AlipayCommerceIotWifiResultQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 配网状态：    //-1.表示设备还没上报配网结果  //1.wifi连接成功  //2. 找不到该wifi  //3. wifi密码错误
        /// </summary>
        [JsonPropertyName("result_type")]
        public long ResultType { get; set; }

        /// <summary>
        /// wifi名称
        /// </summary>
        [JsonPropertyName("ssid")]
        public string Ssid { get; set; }
    }
}
