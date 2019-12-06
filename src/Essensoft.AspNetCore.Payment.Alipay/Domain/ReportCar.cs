using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ReportCar Data Structure.
    /// </summary>
    public class ReportCar : AlipayObject
    {
        /// <summary>
        /// 定损员信息，核赔阶段标的车必填
        /// </summary>
        [JsonPropertyName("assessor")]
        public Person Assessor { get; set; }

        /// <summary>
        /// 司机信息，查勘、核赔阶段必填
        /// </summary>
        [JsonPropertyName("driver")]
        public Person Driver { get; set; }

        /// <summary>
        /// 车架号，标的车在查勘、核赔阶段必填
        /// </summary>
        [JsonPropertyName("frame_no")]
        public string FrameNo { get; set; }

        /// <summary>
        /// 修理厂地址
        /// </summary>
        [JsonPropertyName("garage_address")]
        public string GarageAddress { get; set; }

        /// <summary>
        /// 修理厂名称
        /// </summary>
        [JsonPropertyName("garage_name")]
        public string GarageName { get; set; }

        /// <summary>
        /// 修理厂手机号
        /// </summary>
        [JsonPropertyName("garage_phone_no")]
        public string GaragePhoneNo { get; set; }

        /// <summary>
        /// 修理厂类型  4S:4S店  GENERAL:综合修理
        /// </summary>
        [JsonPropertyName("garage_type")]
        public string GarageType { get; set; }

        /// <summary>
        /// 车牌号，标的车在查勘、核赔阶段必填
        /// </summary>
        [JsonPropertyName("license_no")]
        public string LicenseNo { get; set; }

        /// <summary>
        /// 查勘首次提交时间，标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("survey_first_commit_date")]
        public string SurveyFirstCommitDate { get; set; }

        /// <summary>
        /// 查勘末次时间，标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("survey_last_commit_date")]
        public string SurveyLastCommitDate { get; set; }

        /// <summary>
        /// 查勘员，查勘、核赔阶段标的车必填
        /// </summary>
        [JsonPropertyName("surveyor")]
        public Person Surveyor { get; set; }
    }
}
