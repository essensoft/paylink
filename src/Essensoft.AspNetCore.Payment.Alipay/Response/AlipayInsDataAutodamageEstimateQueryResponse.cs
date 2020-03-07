using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsDataAutodamageEstimateQueryResponse.
    /// </summary>
    public class AlipayInsDataAutodamageEstimateQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商业险保单号
        /// </summary>
        [JsonPropertyName("commercial_policy_no")]
        public string CommercialPolicyNo { get; set; }

        /// <summary>
        /// 交强险
        /// </summary>
        [JsonPropertyName("compulsory_policy_no")]
        public string CompulsoryPolicyNo { get; set; }

        /// <summary>
        /// 发动机号
        /// </summary>
        [JsonPropertyName("engine_no")]
        public string EngineNo { get; set; }

        /// <summary>
        /// 定损结果详情列表
        /// </summary>
        [JsonPropertyName("estimate_detail_list")]
        public List<InsDataAutodamageEstimateResultDetailModel> EstimateDetailList { get; set; }

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
        /// 车型厂牌
        /// </summary>
        [JsonPropertyName("model_brand")]
        public string ModelBrand { get; set; }

        /// <summary>
        /// 报案号
        /// </summary>
        [JsonPropertyName("report_no")]
        public string ReportNo { get; set; }

        /// <summary>
        /// 查勘号
        /// </summary>
        [JsonPropertyName("survey_no")]
        public string SurveyNo { get; set; }
    }
}
