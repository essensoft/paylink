using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserAnalysisData Data Structure.
    /// </summary>
    public class UserAnalysisData : AlipayObject
    {
        /// <summary>
        /// 取消关注人数
        /// </summary>
        [JsonPropertyName("cancel_user_cnt")]
        public string CancelUserCnt { get; set; }

        /// <summary>
        /// 累积关注人数
        /// </summary>
        [JsonPropertyName("cumulate_user_cnt")]
        public string CumulateUserCnt { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// 净增关注人数
        /// </summary>
        [JsonPropertyName("grow_user_cnt")]
        public string GrowUserCnt { get; set; }

        /// <summary>
        /// 新关注人数
        /// </summary>
        [JsonPropertyName("new_user_cnt")]
        public string NewUserCnt { get; set; }
    }
}
