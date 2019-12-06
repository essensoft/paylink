using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsDataDsbEstimateApplyModel Data Structure.
    /// </summary>
    public class AlipayInsDataDsbEstimateApplyModel : AlipayObject
    {
        /// <summary>
        /// 事发地区编码，取值参考提供的统一编码标准文档
        /// </summary>
        [JsonPropertyName("accident_area_id")]
        public string AccidentAreaId { get; set; }

        /// <summary>
        /// 车辆属性，json格式
        /// </summary>
        [JsonPropertyName("car_properties")]
        public string CarProperties { get; set; }

        /// <summary>
        /// 案件属性，json字符串格式，目前key值有is_night_case(是否夜间案件）、is_human_hurt（是否有人伤）、is_only_outlook_damage（是否纯外观损伤）等
        /// </summary>
        [JsonPropertyName("case_properties")]
        public string CaseProperties { get; set; }

        /// <summary>
        /// 车险商业险保单号
        /// </summary>
        [JsonPropertyName("commercial_policy_no")]
        public string CommercialPolicyNo { get; set; }

        /// <summary>
        /// 交强险保单号
        /// </summary>
        [JsonPropertyName("compulsory_policy_no")]
        public string CompulsoryPolicyNo { get; set; }

        /// <summary>
        /// 发动机号
        /// </summary>
        [JsonPropertyName("engine_no")]
        public string EngineNo { get; set; }

        /// <summary>
        /// 保险公司定损单号，唯一标识一个定损单的id
        /// </summary>
        [JsonPropertyName("estimate_no")]
        public string EstimateNo { get; set; }

        /// <summary>
        /// 定损请求uuid，唯一标识一次定损请求，用于做幂等控制
        /// </summary>
        [JsonPropertyName("estimate_request_uuid")]
        public string EstimateRequestUuid { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        [JsonPropertyName("frame_no")]
        public string FrameNo { get; set; }

        /// <summary>
        /// 修理厂类型，枚举如下    4S－4S店  GENERAL－综合修理厂
        /// </summary>
        [JsonPropertyName("garage_type")]
        public string GarageType { get; set; }

        /// <summary>
        /// 车损图片信息列表
        /// </summary>
        [JsonPropertyName("image_list")]
        public List<AlipayInsDataDsbRequestImageInfo> ImageList { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonPropertyName("license_no")]
        public string LicenseNo { get; set; }

        /// <summary>
        /// 车型厂牌，理赔车型
        /// </summary>
        [JsonPropertyName("model_brand")]
        public string ModelBrand { get; set; }

        /// <summary>
        /// 新车购置价，单位为元。
        /// </summary>
        [JsonPropertyName("new_car_price")]
        public string NewCarPrice { get; set; }

        /// <summary>
        /// 维修企业属性，json字符串格式，目前key值有：type(企业类型/等级）、name（企业名称）、address（地址）、code（维修企业编码）等
        /// </summary>
        [JsonPropertyName("repair_corp_properties")]
        public string RepairCorpProperties { get; set; }

        /// <summary>
        /// 报案号
        /// </summary>
        [JsonPropertyName("report_no")]
        public string ReportNo { get; set; }

        /// <summary>
        /// 请求发生时的时间戳
        /// </summary>
        [JsonPropertyName("request_timestamp")]
        public string RequestTimestamp { get; set; }

        /// <summary>
        /// 查勘号
        /// </summary>
        [JsonPropertyName("survey_no")]
        public string SurveyNo { get; set; }
    }
}
