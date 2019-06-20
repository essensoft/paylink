using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogAftsCertIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogAftsCertIdentifyModel : AlipayObject
    {
        /// <summary>
        /// 扩展入参
        /// </summary>
        [JsonProperty("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 高
        /// </summary>
        [JsonProperty("h")]
        public long H { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonProperty("plate_number")]
        public string PlateNumber { get; set; }

        /// <summary>
        /// 传入资源URL或djangoid或aftsid
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 宽
        /// </summary>
        [JsonProperty("w")]
        public long W { get; set; }

        /// <summary>
        /// 左上角x
        /// </summary>
        [JsonProperty("x")]
        public long X { get; set; }

        /// <summary>
        /// 左上角y
        /// </summary>
        [JsonProperty("y")]
        public long Y { get; set; }
    }
}
