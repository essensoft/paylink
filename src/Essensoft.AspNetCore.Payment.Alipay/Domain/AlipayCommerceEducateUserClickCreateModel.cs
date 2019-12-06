using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateUserClickCreateModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateUserClickCreateModel : AlipayObject
    {
        /// <summary>
        /// 市
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 点击次数
        /// </summary>
        [JsonPropertyName("click_time")]
        public string ClickTime { get; set; }

        /// <summary>
        /// 点击兼职岗位所属公司名称
        /// </summary>
        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("features")]
        public string Features { get; set; }

        /// <summary>
        /// 是否报名岗位
        /// </summary>
        [JsonPropertyName("is_apply_job")]
        public string IsApplyJob { get; set; }

        /// <summary>
        /// 岗位id
        /// </summary>
        [JsonPropertyName("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 点击兼职岗位名称
        /// </summary>
        [JsonPropertyName("parttime_job_name")]
        public string ParttimeJobName { get; set; }

        /// <summary>
        /// 点击进入岗位详情页面平均停留时长
        /// </summary>
        [JsonPropertyName("stay_avg_time")]
        public string StayAvgTime { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
