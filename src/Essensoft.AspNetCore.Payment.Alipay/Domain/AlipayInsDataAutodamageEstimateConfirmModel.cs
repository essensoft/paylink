using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsDataAutodamageEstimateConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsDataAutodamageEstimateConfirmModel : AlipayObject
    {
        /// <summary>
        /// 业务类型，2表示机构核损，3表示机构定损
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 车险商业险保单号
        /// </summary>
        [JsonProperty("commercial_policy_no")]
        public string CommercialPolicyNo { get; set; }

        /// <summary>
        /// 交强险保单号
        /// </summary>
        [JsonProperty("compulsory_policy_no")]
        public string CompulsoryPolicyNo { get; set; }

        /// <summary>
        /// 汽车发动机号
        /// </summary>
        [JsonProperty("engine_no")]
        public string EngineNo { get; set; }

        /// <summary>
        /// 核损详情对象列表
        /// </summary>
        [JsonProperty("estimate_detail_list")]
        public List<InsDataAutodamageEstimateConfirmModel> EstimateDetailList { get; set; }

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
        /// 车型厂牌
        /// </summary>
        [JsonProperty("model_brand")]
        public string ModelBrand { get; set; }

        /// <summary>
        /// 维修企业名称
        /// </summary>
        [JsonProperty("repair_corp_name")]
        public string RepairCorpName { get; set; }

        /// <summary>
        /// 维修企业类型
        /// </summary>
        [JsonProperty("repair_corp_type")]
        public string RepairCorpType { get; set; }

        /// <summary>
        /// 车险报案号
        /// </summary>
        [JsonProperty("report_no")]
        public string ReportNo { get; set; }

        /// <summary>
        /// 查勘号
        /// </summary>
        [JsonProperty("survey_no")]
        public string SurveyNo { get; set; }

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
