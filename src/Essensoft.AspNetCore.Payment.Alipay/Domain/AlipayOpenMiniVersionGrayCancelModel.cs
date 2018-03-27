using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniVersionGrayCancelModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniVersionGrayCancelModel : AlipayObject
    {
        /// <summary>
        /// 小程序版本号
        /// </summary>
        [JsonProperty("app_version")]
        public string AppVersion { get; set; }
    }
}
