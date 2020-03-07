using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogAftsCertIdentifyModel Data Structure.
    /// </summary>
    public class AlipayMsaasMediarecogAftsCertIdentifyModel : AlipayObject
    {
        /// <summary>
        /// 扩展入参
        /// </summary>
        [JsonPropertyName("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 高
        /// </summary>
        [JsonPropertyName("h")]
        public long H { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonPropertyName("plate_number")]
        public string PlateNumber { get; set; }

        /// <summary>
        /// 传入资源URL或djangoid或aftsid
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 宽
        /// </summary>
        [JsonPropertyName("w")]
        public long W { get; set; }

        /// <summary>
        /// 左上角x
        /// </summary>
        [JsonPropertyName("x")]
        public long X { get; set; }

        /// <summary>
        /// 左上角y
        /// </summary>
        [JsonPropertyName("y")]
        public long Y { get; set; }
    }
}
