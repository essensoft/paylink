using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// PushDTO Data Structure.
    /// </summary>
    public class PushDTO : AlipayObject
    {
        /// <summary>
        /// 推进计算类型，如计次:cal_count
        /// </summary>
        [JsonPropertyName("cal_type")]
        public string CalType { get; set; }

        /// <summary>
        /// 推进值
        /// </summary>
        [JsonPropertyName("inc_value")]
        public long IncValue { get; set; }
    }
}
