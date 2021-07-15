using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneMobileScreenApplyModel Data Structure.
    /// </summary>
    public class AlipayInsSceneMobileScreenApplyModel : AlipayObject
    {
        /// <summary>
        /// 投保人信息
        /// </summary>
        [JsonPropertyName("applicant")]
        public InsurancePerson Applicant { get; set; }

        /// <summary>
        /// 渠道来源
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 渠道业务信息
        /// </summary>
        [JsonPropertyName("channel_biz_data")]
        public ChannelBizData ChannelBizData { get; set; }

        /// <summary>
        /// 保险保障开始时间
        /// </summary>
        [JsonPropertyName("effective_start_time")]
        public string EffectiveStartTime { get; set; }

        /// <summary>
        /// 保障期限对象
        /// </summary>
        [JsonPropertyName("insurance_period")]
        public InsurancePeriod InsurancePeriod { get; set; }

        /// <summary>
        /// 被保人信息
        /// </summary>
        [JsonPropertyName("insured")]
        public InsurancePerson Insured { get; set; }

        /// <summary>
        /// 手机设备信息
        /// </summary>
        [JsonPropertyName("mobile_device_info")]
        public MobileDeviceInfo MobileDeviceInfo { get; set; }

        /// <summary>
        /// 外部业务单号，幂等字段
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 保费金额，单位分
        /// </summary>
        [JsonPropertyName("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 维修类型 官修：official; 严选：unOfficial;
        /// </summary>
        [JsonPropertyName("repair_type")]
        public string RepairType { get; set; }
    }
}
