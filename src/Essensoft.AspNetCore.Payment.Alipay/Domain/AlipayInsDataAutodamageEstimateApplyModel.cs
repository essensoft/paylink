using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsDataAutodamageEstimateApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsDataAutodamageEstimateApplyModel : AlipayObject
    {
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
        /// 车损图片信息列表
        /// </summary>
        [JsonProperty("image_list")]
        public List<AlipayInsDataAutodamageRequestImageInfo> ImageList { get; set; }

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
        /// 车险报案号
        /// </summary>
        [JsonProperty("report_no")]
        public string ReportNo { get; set; }

        /// <summary>
        /// 请求发生时的时间戳
        /// </summary>
        [JsonProperty("request_timestamp")]
        public long RequestTimestamp { get; set; }

        /// <summary>
        /// 查勘号
        /// </summary>
        [JsonProperty("survey_no")]
        public string SurveyNo { get; set; }
    }
}
