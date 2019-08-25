using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsDataDsbEstimateSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsDataDsbEstimateSyncModel : AlipayObject
    {
        /// <summary>
        /// 业务类型：assessment（定损），evaluation（核损）
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 定损/核损详情对象列表
        /// </summary>
        [JsonProperty("estimate_detail_list")]
        public List<InsDataDsbEstimateResultDetail> EstimateDetailList { get; set; }

        /// <summary>
        /// 保险公司定损单号，唯一标识一个定损单的id
        /// </summary>
        [JsonProperty("estimate_no")]
        public string EstimateNo { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        [JsonProperty("frame_no")]
        public string FrameNo { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonProperty("license_no")]
        public string LicenseNo { get; set; }

        /// <summary>
        /// 维修企业属性，json字符串格式，目前key值有：type(企业类型/等级）、name（企业名称）、address（地址）、code（维修企业编码）等
        /// </summary>
        [JsonProperty("repair_corp_properties")]
        public string RepairCorpProperties { get; set; }

        /// <summary>
        /// 车损总金额，单位：元
        /// </summary>
        [JsonProperty("total_damage_amount")]
        public string TotalDamageAmount { get; set; }

        /// <summary>
        /// 残值扣除总金额，单位：元
        /// </summary>
        [JsonProperty("total_remain_value")]
        public string TotalRemainValue { get; set; }
    }
}
