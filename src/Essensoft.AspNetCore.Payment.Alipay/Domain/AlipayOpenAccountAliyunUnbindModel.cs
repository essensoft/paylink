using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAccountAliyunUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAccountAliyunUnbindModel : AlipayObject
    {
        /// <summary>
        /// 与阿里云账号绑定的第三方平台的账号ID
        /// </summary>
        [JsonProperty("bind_id")]
        public string BindId { get; set; }

        /// <summary>
        /// Havana绑定站点
        /// </summary>
        [JsonProperty("havana_bind_station")]
        public string HavanaBindStation { get; set; }

        /// <summary>
        /// 阿里云账号pk
        /// </summary>
        [JsonProperty("pk")]
        public string Pk { get; set; }
    }
}
