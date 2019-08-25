using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotDeviceAudioDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDeviceAudioDeleteModel : AlipayObject
    {
        /// <summary>
        /// 语音id, 也就是语音合成接口返回的audio_id
        /// </summary>
        [JsonProperty("audio_id")]
        public string AudioId { get; set; }

        /// <summary>
        /// 设备的唯一标识,设备id
        /// </summary>
        [JsonProperty("biz_tid")]
        public string BizTid { get; set; }
    }
}
