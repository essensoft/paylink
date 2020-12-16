using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthCardbinPrivateQueryResponse.
    /// </summary>
    public class AlipayFinancialnetAuthCardbinPrivateQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 卡类型，CC为信用卡，DC为借记卡
        /// </summary>
        [JsonPropertyName("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        [JsonPropertyName("inst_name")]
        public string InstName { get; set; }
    }
}
