using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// MiniAppBaseInfoQueryInfo Data Structure.
    /// </summary>
    public class MiniAppBaseInfoQueryInfo : AlipayObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
