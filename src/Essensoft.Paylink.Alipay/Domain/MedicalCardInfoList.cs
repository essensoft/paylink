using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// MedicalCardInfoList Data Structure.
    /// </summary>
    public class MedicalCardInfoList : AlipayObject
    {
        /// <summary>
        /// 参保地列表
        /// </summary>
        [JsonPropertyName("insured_cities")]
        public MedicalInsuredCityList InsuredCities { get; set; }

        /// <summary>
        /// 参保状态
        /// </summary>
        [JsonPropertyName("insured_status")]
        public string InsuredStatus { get; set; }

        /// <summary>
        /// 持卡人与当前UID账户关系
        /// </summary>
        [JsonPropertyName("relation_type")]
        public string RelationType { get; set; }

        /// <summary>
        /// 绑卡激活状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
