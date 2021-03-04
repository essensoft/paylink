using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityDataInfoMobilecityQueryResponse.
    /// </summary>
    public class AlipaySecurityDataInfoMobilecityQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 手机归属地对象,三个field均为string类型,手机号前七,phoneNumber; ,省份province;,城市city;
        /// </summary>
        [JsonPropertyName("mobile_city")]
        public SecuritydataMobileCity MobileCity { get; set; }
    }
}
