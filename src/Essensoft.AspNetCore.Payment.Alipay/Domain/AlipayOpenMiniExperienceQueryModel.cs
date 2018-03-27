using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniExperienceQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniExperienceQueryModel : AlipayObject
    {
        /// <summary>
        /// 小程序版本号
        /// </summary>
        [JsonProperty("app_version")]
        public string AppVersion { get; set; }
    }
}
