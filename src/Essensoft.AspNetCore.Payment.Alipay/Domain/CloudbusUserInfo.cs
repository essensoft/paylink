using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CloudbusUserInfo Data Structure.
    /// </summary>
    public class CloudbusUserInfo : AlipayObject
    {
        /// <summary>
        /// 小孩
        /// </summary>
        [JsonPropertyName("age_chrild")]
        public long AgeChrild { get; set; }

        /// <summary>
        /// 中年人
        /// </summary>
        [JsonPropertyName("age_mider")]
        public long AgeMider { get; set; }

        /// <summary>
        /// 老年人
        /// </summary>
        [JsonPropertyName("age_older")]
        public long AgeOlder { get; set; }

        /// <summary>
        /// 年前人
        /// </summary>
        [JsonPropertyName("age_youth")]
        public long AgeYouth { get; set; }

        /// <summary>
        /// 男性人数
        /// </summary>
        [JsonPropertyName("sex_man")]
        public long SexMan { get; set; }

        /// <summary>
        /// 女性人数
        /// </summary>
        [JsonPropertyName("sex_woman")]
        public long SexWoman { get; set; }

        /// <summary>
        /// 上班族
        /// </summary>
        [JsonPropertyName("w_officer")]
        public long WOfficer { get; set; }

        /// <summary>
        /// 非上班族
        /// </summary>
        [JsonPropertyName("w_unofficer")]
        public long WUnofficer { get; set; }
    }
}
