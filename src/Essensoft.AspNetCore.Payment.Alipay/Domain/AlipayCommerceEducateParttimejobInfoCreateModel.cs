using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateParttimejobInfoCreateModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateParttimejobInfoCreateModel : AlipayObject
    {
        /// <summary>
        /// 市
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 结算方式
        /// </summary>
        [JsonPropertyName("clearing_form")]
        public string ClearingForm { get; set; }

        /// <summary>
        /// 岗位图片
        /// </summary>
        [JsonPropertyName("company_logo")]
        public string CompanyLogo { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 学历要求
        /// </summary>
        [JsonPropertyName("educational_requirements")]
        public string EducationalRequirements { get; set; }

        /// <summary>
        /// json格式扩展字段
        /// </summary>
        [JsonPropertyName("features")]
        public string Features { get; set; }

        /// <summary>
        /// 性别要求
        /// </summary>
        [JsonPropertyName("gender_requirement")]
        public string GenderRequirement { get; set; }

        /// <summary>
        /// 热度
        /// </summary>
        [JsonPropertyName("heat")]
        public string Heat { get; set; }

        /// <summary>
        /// 身高要求
        /// </summary>
        [JsonPropertyName("height_limit")]
        public string HeightLimit { get; set; }

        /// <summary>
        /// 行业属性
        /// </summary>
        [JsonPropertyName("industry_attributes")]
        public string IndustryAttributes { get; set; }

        /// <summary>
        /// 是否名企职位
        /// </summary>
        [JsonPropertyName("is_famous")]
        public string IsFamous { get; set; }

        /// <summary>
        /// 岗位地址，精确到经纬度
        /// </summary>
        [JsonPropertyName("job_address")]
        public string JobAddress { get; set; }

        /// <summary>
        /// 岗位所属类目
        /// </summary>
        [JsonPropertyName("job_category")]
        public string JobCategory { get; set; }

        /// <summary>
        /// 工作时间
        /// </summary>
        [JsonPropertyName("job_frequency")]
        public string JobFrequency { get; set; }

        /// <summary>
        /// 岗位id
        /// </summary>
        [JsonPropertyName("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 岗位名称
        /// </summary>
        [JsonPropertyName("job_name")]
        public string JobName { get; set; }

        /// <summary>
        /// 岗位相关内容介绍
        /// </summary>
        [JsonPropertyName("job_remark")]
        public string JobRemark { get; set; }

        /// <summary>
        /// 岗位福利
        /// </summary>
        [JsonPropertyName("job_welfare")]
        public string JobWelfare { get; set; }

        /// <summary>
        /// 健康证要求
        /// </summary>
        [JsonPropertyName("need_health")]
        public string NeedHealth { get; set; }

        /// <summary>
        /// 薪资
        /// </summary>
        [JsonPropertyName("salary")]
        public string Salary { get; set; }

        /// <summary>
        /// 跳转地址
        /// </summary>
        [JsonPropertyName("skip_url")]
        public string SkipUrl { get; set; }

        /// <summary>
        /// 数据状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 工作日期
        /// </summary>
        [JsonPropertyName("working_date")]
        public string WorkingDate { get; set; }
    }
}
