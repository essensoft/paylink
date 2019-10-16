using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoTextVoiceNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoTextVoiceNotifyModel : AlipayObject
    {
        /// <summary>
        /// 语音回调列表
        /// </summary>
        [JsonProperty("callbacks")]
        public List<SpiVoiceCallback> Callbacks { get; set; }
    }
}
