using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneApplicationMobileApplyModel Data Structure.
    /// </summary>
    public class AlipayInsSceneApplicationMobileApplyModel : AlipayObject
    {
        /// <summary>
        /// 投保人
        /// </summary>
        [JsonPropertyName("applicant")]
        public InsPerson Applicant { get; set; }

        /// <summary>
        /// 设备信息
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 渠道来源
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 保险失效时间
        /// </summary>
        [JsonPropertyName("effective_end_time")]
        public string EffectiveEndTime { get; set; }

        /// <summary>
        /// 保单生效时间
        /// </summary>
        [JsonPropertyName("effective_start_time")]
        public string EffectiveStartTime { get; set; }

        /// <summary>
        /// 被保人信息
        /// </summary>
        [JsonPropertyName("insured")]
        public InsPerson Insured { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 保障期限 数字加单位，单位包括Y/M/D/H
        /// </summary>
        [JsonPropertyName("period")]
        public string Period { get; set; }

        /// <summary>
        /// 保险保费
        /// </summary>
        [JsonPropertyName("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 维修类型，官修/非官修
        /// </summary>
        [JsonPropertyName("repair_type")]
        public string RepairType { get; set; }

        /// <summary>
        /// 标准产品ID
        /// </summary>
        [JsonPropertyName("sp_no")]
        public string SpNo { get; set; }
    }
}
