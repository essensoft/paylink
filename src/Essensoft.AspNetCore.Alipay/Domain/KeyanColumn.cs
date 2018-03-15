using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KeyanColumn Data Structure.
    /// </summary>
    public class KeyanColumn : AlipayObject
    {
        /// <summary>
        /// 密码
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
