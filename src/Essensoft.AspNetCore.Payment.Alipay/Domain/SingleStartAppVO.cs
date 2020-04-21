using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SingleStartAppVO Data Structure.
    /// </summary>
    public class SingleStartAppVO : AlipayObject
    {
        /// <summary>
        /// 小程序启动协议
        /// </summary>
        [JsonPropertyName("protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// 按照标准定义的startAppModel
        /// </summary>
        [JsonPropertyName("start_app_model")]
        public string StartAppModel { get; set; }
    }
}
