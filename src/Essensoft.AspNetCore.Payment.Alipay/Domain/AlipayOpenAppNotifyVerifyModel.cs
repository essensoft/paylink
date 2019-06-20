using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppNotifyVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppNotifyVerifyModel : AlipayObject
    {
        /// <summary>
        /// 通知id
        /// </summary>
        [JsonProperty("notify_id")]
        public string NotifyId { get; set; }
    }
}
