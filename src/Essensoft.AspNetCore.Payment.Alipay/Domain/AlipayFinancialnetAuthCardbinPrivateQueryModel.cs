using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthCardbinPrivateQueryModel Data Structure.
    /// </summary>
    public class AlipayFinancialnetAuthCardbinPrivateQueryModel : AlipayObject
    {
        /// <summary>
        /// 卡号
        /// </summary>
        [JsonPropertyName("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }
    }
}
