using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEduCampusJobCreateModel Data Structure.
    /// </summary>
    public class AlipayEcoEduCampusJobCreateModel : AlipayObject
    {
        /// <summary>
        /// 城市编码
        /// </summary>
        [JsonPropertyName("area_city_code")]
        public string AreaCityCode { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [JsonPropertyName("area_city_name")]
        public string AreaCityName { get; set; }

        /// <summary>
        /// 区编码
        /// </summary>
        [JsonPropertyName("area_district_code")]
        public string AreaDistrictCode { get; set; }

        /// <summary>
        /// 区名称
        /// </summary>
        [JsonPropertyName("area_district_name")]
        public string AreaDistrictName { get; set; }

        /// <summary>
        /// 工作详细地址
        /// </summary>
        [JsonPropertyName("area_job_address")]
        public string AreaJobAddress { get; set; }

        /// <summary>
        /// 省份编码（直辖市
        /// </summary>
        [JsonPropertyName("area_province_code")]
        public long AreaProvinceCode { get; set; }

        /// <summary>
        /// 省份名称（直辖市）
        /// </summary>
        [JsonPropertyName("area_province_name")]
        public string AreaProvinceName { get; set; }

        /// <summary>
        /// 街道名称
        /// </summary>
        [JsonPropertyName("area_street_name")]
        public string AreaStreetName { get; set; }

        /// <summary>
        /// 企业法律名称
        /// </summary>
        [JsonPropertyName("company_lawname")]
        public string CompanyLawname { get; set; }

        /// <summary>
        /// 参数描述企业Logo
        /// </summary>
        [JsonPropertyName("company_logo")]
        public string CompanyLogo { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 第三方公司ID
        /// </summary>
        [JsonPropertyName("company_source")]
        public string CompanySource { get; set; }

        /// <summary>
        /// 备注json 数据
        /// </summary>
        [JsonPropertyName("content_var")]
        public string ContentVar { get; set; }

        /// <summary>
        /// 过期时间(毫秒数)
        /// </summary>
        [JsonPropertyName("gmt_expired")]
        public string GmtExpired { get; set; }

        /// <summary>
        /// 刷新时间(毫秒数)
        /// </summary>
        [JsonPropertyName("gmt_refresh")]
        public string GmtRefresh { get; set; }

        /// <summary>
        /// 职位开始时间(毫秒数)
        /// </summary>
        [JsonPropertyName("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 职位描述
        /// </summary>
        [JsonPropertyName("job_desc")]
        public string JobDesc { get; set; }

        /// <summary>
        /// 招聘人数
        /// </summary>
        [JsonPropertyName("job_hire_number")]
        public long JobHireNumber { get; set; }

        /// <summary>
        /// 职位名称
        /// </summary>
        [JsonPropertyName("job_name")]
        public string JobName { get; set; }

        /// <summary>
        /// 职业亮点/关键字
        /// </summary>
        [JsonPropertyName("job_perk")]
        public string JobPerk { get; set; }

        /// <summary>
        /// 要求简历语言（1中文；2英文）
        /// </summary>
        [JsonPropertyName("job_resume_lg")]
        public long JobResumeLg { get; set; }

        /// <summary>
        /// 学历要求专科（1:大专以下2:大专3:本科4:硕士5:博士6:其他7:不限）
        /// </summary>
        [JsonPropertyName("job_rq_education")]
        public long JobRqEducation { get; set; }

        /// <summary>
        /// 职业一级分类code
        /// </summary>
        [JsonPropertyName("job_tier_one_code")]
        public string JobTierOneCode { get; set; }

        /// <summary>
        /// 职业一级分类name
        /// </summary>
        [JsonPropertyName("job_tier_one_name")]
        public string JobTierOneName { get; set; }

        /// <summary>
        /// 职业三级分类code
        /// </summary>
        [JsonPropertyName("job_tier_three_code")]
        public string JobTierThreeCode { get; set; }

        /// <summary>
        /// 职业三级分类name
        /// </summary>
        [JsonPropertyName("job_tier_three_name")]
        public string JobTierThreeName { get; set; }

        /// <summary>
        /// 职业二级分类code
        /// </summary>
        [JsonPropertyName("job_tier_two_code")]
        public string JobTierTwoCode { get; set; }

        /// <summary>
        /// 职业二级分类name
        /// </summary>
        [JsonPropertyName("job_tier_two_name")]
        public string JobTierTwoName { get; set; }

        /// <summary>
        /// 职位类型枚举（1实习；2兼职；3全职；）
        /// </summary>
        [JsonPropertyName("job_type")]
        public long JobType { get; set; }

        /// <summary>
        /// 最大薪资（单位￥）
        /// </summary>
        [JsonPropertyName("payment_max")]
        public long PaymentMax { get; set; }

        /// <summary>
        /// 最小薪资（单位￥）
        /// </summary>
        [JsonPropertyName("payment_min")]
        public long PaymentMin { get; set; }

        /// <summary>
        /// 薪资单位(1:天2:月3:周)
        /// </summary>
        [JsonPropertyName("payment_unit")]
        public long PaymentUnit { get; set; }

        /// <summary>
        /// 职位来源方编码
        /// </summary>
        [JsonPropertyName("source_code")]
        public string SourceCode { get; set; }

        /// <summary>
        /// 职位在合作方的ID
        /// </summary>
        [JsonPropertyName("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 每周到岗天数
        /// </summary>
        [JsonPropertyName("tra_job_freq")]
        public long TraJobFreq { get; set; }

        /// <summary>
        /// 实习时间长度(单位月)
        /// </summary>
        [JsonPropertyName("tra_job_period")]
        public long TraJobPeriod { get; set; }

        /// <summary>
        /// 是否可转正(1可以；0不可以)
        /// </summary>
        [JsonPropertyName("tra_job_promot")]
        public long TraJobPromot { get; set; }
    }
}
