using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateNceeApplySyncModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateNceeApplySyncModel : AlipayObject
    {
        /// <summary>
        /// 批次
        /// </summary>
        [JsonPropertyName("batch")]
        public string Batch { get; set; }

        /// <summary>
        /// 选科或选测信息
        /// </summary>
        [JsonPropertyName("course")]
        public string Course { get; set; }

        /// <summary>
        /// 专业关注数
        /// </summary>
        [JsonPropertyName("interested_major_num")]
        public long InterestedMajorNum { get; set; }

        /// <summary>
        /// 院校关注数
        /// </summary>
        [JsonPropertyName("interested_school_num")]
        public long InterestedSchoolNum { get; set; }

        /// <summary>
        /// 是否支持一键填报
        /// </summary>
        [JsonPropertyName("one_key_support")]
        public long OneKeySupport { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [JsonPropertyName("province_code")]
        public long ProvinceCode { get; set; }

        /// <summary>
        /// 志愿表数
        /// </summary>
        [JsonPropertyName("purpose_form_num")]
        public long PurposeFormNum { get; set; }

        /// <summary>
        /// 位次
        /// </summary>
        [JsonPropertyName("rank")]
        public long Rank { get; set; }

        /// <summary>
        /// 报告数
        /// </summary>
        [JsonPropertyName("report_num")]
        public long ReportNum { get; set; }

        /// <summary>
        /// 高考分数
        /// </summary>
        [JsonPropertyName("score")]
        public long Score { get; set; }

        /// <summary>
        /// 可选数量
        /// </summary>
        [JsonPropertyName("selected_num")]
        public long SelectedNum { get; set; }

        /// <summary>
        /// 科类
        /// </summary>
        [JsonPropertyName("subject")]
        public long Subject { get; set; }

        /// <summary>
        /// 批次总数
        /// </summary>
        [JsonPropertyName("total_num")]
        public long TotalNum { get; set; }

        /// <summary>
        /// 模板类型
        /// </summary>
        [JsonPropertyName("type")]
        public long Type { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 高考年份
        /// </summary>
        [JsonPropertyName("year")]
        public long Year { get; set; }
    }
}
