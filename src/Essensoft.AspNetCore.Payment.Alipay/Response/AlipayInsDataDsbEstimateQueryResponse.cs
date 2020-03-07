using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsDataDsbEstimateQueryResponse.
    /// </summary>
    public class AlipayInsDataDsbEstimateQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 定损结果置信度，小数，取值范围为0到1
        /// </summary>
        [JsonPropertyName("confidence")]
        public string Confidence { get; set; }

        /// <summary>
        /// 核损详情对象列表
        /// </summary>
        [JsonPropertyName("estimate_detail_list")]
        public List<InsDataDsbEstimateResultDetail> EstimateDetailList { get; set; }

        /// <summary>
        /// 定损单号
        /// </summary>
        [JsonPropertyName("estimate_no")]
        public string EstimateNo { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        [JsonPropertyName("frame_no")]
        public string FrameNo { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonPropertyName("license_no")]
        public string LicenseNo { get; set; }

        /// <summary>
        /// 维修企业属性，json字符串格式，目前key值有：type(企业类型/等级）、name（企业名称）、address（地址）、code（维修企业编码）等
        /// </summary>
        [JsonPropertyName("repair_corp_properties")]
        public string RepairCorpProperties { get; set; }

        /// <summary>
        /// 车损总金额，单位：元
        /// </summary>
        [JsonPropertyName("total_damage_amount")]
        public string TotalDamageAmount { get; set; }

        /// <summary>
        /// 残值扣除总金额，单位：元
        /// </summary>
        [JsonPropertyName("total_remain_value")]
        public string TotalRemainValue { get; set; }
    }
}
