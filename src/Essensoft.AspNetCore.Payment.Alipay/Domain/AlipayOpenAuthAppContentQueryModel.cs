using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAuthAppContentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthAppContentQueryModel : AlipayObject
    {
        /// <summary>
        /// 授权场景，固定值PLATFORM_APP_AUTH
        /// </summary>
        [JsonProperty("auth_scene")]
        public string AuthScene { get; set; }
    }
}
