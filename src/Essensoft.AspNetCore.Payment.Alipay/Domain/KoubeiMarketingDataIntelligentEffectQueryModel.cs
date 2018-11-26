using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataIntelligentEffectQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataIntelligentEffectQueryModel : AlipayObject
    {
        /// <summary>
        /// 操作人上下文信息
        /// </summary>
        [JsonProperty("operator_context")]
        [XmlElement("operator_context")]
        public PromoOperatorInfo OperatorContext { get; set; }

        /// <summary>
        /// 外部业务id，请保持足够复杂，方便排查数据来源
        /// </summary>
        [JsonProperty("out_request_no")]
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 智能营销活动的详情，用于咨询的元数据
        /// </summary>
        [JsonProperty("promo")]
        [XmlElement("promo")]
        public IntelligentPromo Promo { get; set; }
    }
}
