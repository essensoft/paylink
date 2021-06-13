using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AssetValidPeriod Data Structure.
    /// </summary>
    public class AssetValidPeriod : AlipayObject
    {
        /// <summary>
        /// 权益实体的有效期，可以是相对模板过期时间基础上增加的时间也可以是绝对时间，相对时间：2d表示相对模板过期增加2天，10h表示增加10个小时，5m表示增加5分钟，绝对时间的格式为： yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }
    }
}
