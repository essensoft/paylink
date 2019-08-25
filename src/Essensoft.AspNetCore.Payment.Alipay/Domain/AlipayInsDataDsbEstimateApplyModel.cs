using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsDataDsbEstimateApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsDataDsbEstimateApplyModel : AlipayObject
    {
        /// <summary>
        /// 事发地区编码，取值参考提供的统一编码标准文档
        /// </summary>
        [JsonProperty("accident_area_id")]
        public string AccidentAreaId { get; set; }

        /// <summary>
        /// 车辆属性，json格式
        /// </summary>
        [JsonProperty("car_properties")]
        public string CarProperties { get; set; }

        /// <summary>
        /// 案件属性，json字符串格式，目前key值有is_night_case(是否夜间案件）、is_human_hurt（是否有人伤）、is_only_outlook_damage（是否纯外观损伤）等
        /// </summary>
        [JsonProperty("case_properties")]
        public string CaseProperties { get; set; }

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
        /// 发动机号
        /// </summary>
        [JsonProperty("engine_no")]
        public string EngineNo { get; set; }

        /// <summary>
        /// 保险公司定损单号，唯一标识一个定损单的id
        /// </summary>
        [JsonProperty("estimate_no")]
        public string EstimateNo { get; set; }

        /// <summary>
        /// 定损请求uuid，唯一标识一次定损请求，用于做幂等控制
        /// </summary>
        [JsonProperty("estimate_request_uuid")]
        public string EstimateRequestUuid { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        [JsonProperty("frame_no")]
        public string FrameNo { get; set; }

        /// <summary>
        /// 修理厂类型，枚举如下    4S－4S店  GENERAL－综合修理厂
        /// </summary>
        [JsonProperty("garage_type")]
        public string GarageType { get; set; }

        /// <summary>
        /// 车损图片信息列表
        /// </summary>
        [JsonProperty("image_list")]
        public List<AlipayInsDataDsbRequestImageInfo> ImageList { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonProperty("license_no")]
        public string LicenseNo { get; set; }

        /// <summary>
        /// 车型厂牌，理赔车型
        /// </summary>
        [JsonProperty("model_brand")]
        public string ModelBrand { get; set; }

        /// <summary>
        /// 新车购置价，单位为元。
        /// </summary>
        [JsonProperty("new_car_price")]
        public string NewCarPrice { get; set; }

        /// <summary>
        /// 维修企业属性，json字符串格式，目前key值有：type(企业类型/等级）、name（企业名称）、address（地址）、code（维修企业编码）等
        /// </summary>
        [JsonProperty("repair_corp_properties")]
        public string RepairCorpProperties { get; set; }

        /// <summary>
        /// 报案号
        /// </summary>
        [JsonProperty("report_no")]
        public string ReportNo { get; set; }

        /// <summary>
        /// 请求发生时的时间戳
        /// </summary>
        [JsonProperty("request_timestamp")]
        public string RequestTimestamp { get; set; }

        /// <summary>
        /// 查勘号
        /// </summary>
        [JsonProperty("survey_no")]
        public string SurveyNo { get; set; }
    }
}
