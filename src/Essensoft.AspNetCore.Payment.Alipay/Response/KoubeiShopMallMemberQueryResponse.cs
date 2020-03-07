using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiShopMallMemberQueryResponse.
    /// </summary>
    public class KoubeiShopMallMemberQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 会员等级
        /// </summary>
        [JsonPropertyName("card_level")]
        public string CardLevel { get; set; }

        /// <summary>
        /// 会员卡名称
        /// </summary>
        [JsonPropertyName("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 会员积分
        /// </summary>
        [JsonPropertyName("card_point")]
        public string CardPoint { get; set; }

        /// <summary>
        /// 用户是否开通会员卡
        /// </summary>
        [JsonPropertyName("has_card")]
        public bool HasCard { get; set; }

        /// <summary>
        /// 用户是否授权过商圈交易
        /// </summary>
        [JsonPropertyName("trade_authed")]
        public bool TradeAuthed { get; set; }
    }
}
