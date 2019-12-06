using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SsdataDataserviceRiskAlixiaohaoQueryModel Data Structure.
    /// </summary>
    public class SsdataDataserviceRiskAlixiaohaoQueryModel : AlipayObject
    {
        /// <summary>
        /// 电话号码
        /// </summary>
        [JsonPropertyName("mobile_no")]
        public string MobileNo { get; set; }
    }
}
