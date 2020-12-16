using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodePagedataSendModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateTuitioncodePagedataSendModel : AlipayObject
    {
        /// <summary>
        /// 商户名称
        /// </summary>
        [JsonPropertyName("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// 结课月份
        /// </summary>
        [JsonPropertyName("course_end_month")]
        public string CourseEndMonth { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        [JsonPropertyName("course_name")]
        public string CourseName { get; set; }

        /// <summary>
        /// 开课月份
        /// </summary>
        [JsonPropertyName("course_start_month")]
        public string CourseStartMonth { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商户logo
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 支付金额，格式为0.00
        /// </summary>
        [JsonPropertyName("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 课程周期类型,固定写MONTH
        /// </summary>
        [JsonPropertyName("period_type")]
        public string PeriodType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 商户smid，间联必传
        /// </summary>
        [JsonPropertyName("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 学员姓名
        /// </summary>
        [JsonPropertyName("user_display_name")]
        public string UserDisplayName { get; set; }
    }
}
