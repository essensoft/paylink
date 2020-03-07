using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossProdMyTestQueryModel Data Structure.
    /// </summary>
    public class AlipayBossProdMyTestQueryModel : AlipayObject
    {
        /// <summary>
        /// 区
        /// </summary>
        [JsonPropertyName("area_code")]
        public string AreaCode { get; set; }
    }
}
