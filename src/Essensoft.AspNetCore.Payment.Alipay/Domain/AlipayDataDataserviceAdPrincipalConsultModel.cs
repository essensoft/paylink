using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdPrincipalConsultModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceAdPrincipalConsultModel : AlipayObject
    {
        /// <summary>
        /// 商家支付宝PID，根据该ID获取签约地址
        /// </summary>
        [JsonPropertyName("alipay_pid")]
        public string AlipayPid { get; set; }

        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [JsonPropertyName("biz_token")]
        public string BizToken { get; set; }
    }
}
