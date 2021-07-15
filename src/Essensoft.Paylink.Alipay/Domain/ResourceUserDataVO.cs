using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ResourceUserDataVO Data Structure.
    /// </summary>
    public class ResourceUserDataVO : AlipayObject
    {
        /// <summary>
        /// 用户画像的类别
        /// </summary>
        [JsonPropertyName("profile_type")]
        public string ProfileType { get; set; }

        /// <summary>
        /// 用户画像值
        /// </summary>
        [JsonPropertyName("profile_value")]
        public string ProfileValue { get; set; }

        /// <summary>
        /// 统计日期
        /// </summary>
        [JsonPropertyName("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 用户数量，出于隐私考虑，该数据和实际数据有微小的差异，但是不影响总体数据准确度。
        /// </summary>
        [JsonPropertyName("user_cnt")]
        public long UserCnt { get; set; }

        /// <summary>
        /// 用户占比。出于隐私考虑，该数据和实际数据有微小的差异，但是不影响总体数据准确度。
        /// </summary>
        [JsonPropertyName("user_ratio")]
        public string UserRatio { get; set; }
    }
}
