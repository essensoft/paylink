using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniMiniappServiceconfigModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniMiniappServiceconfigModifyModel : AlipayObject
    {
        /// <summary>
        /// 云客服是否在小程序首页透出，true-开启，false-不开启
        /// </summary>
        [JsonPropertyName("home_open")]
        public bool HomeOpen { get; set; }

        /// <summary>
        /// 客服方式，目前支持ANTCLOUD-云客服
        /// </summary>
        [JsonPropertyName("service_config")]
        public string ServiceConfig { get; set; }
    }
}
