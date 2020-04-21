using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiShopMallMemberIdentifyResponse.
    /// </summary>
    public class KoubeiShopMallMemberIdentifyResponse : AlipayResponse
    {
        /// <summary>
        /// 会员卡编号
        /// </summary>
        [JsonPropertyName("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 用户是否开通会员卡
        /// </summary>
        [JsonPropertyName("has_card")]
        public bool HasCard { get; set; }
    }
}
