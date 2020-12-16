using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdPrincipaldmpSetModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceAdPrincipaldmpSetModel : AlipayObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [JsonPropertyName("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 商户人群id
        /// </summary>
        [JsonPropertyName("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 人群状态： ENABLE:开启 DISABLE:关闭
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
