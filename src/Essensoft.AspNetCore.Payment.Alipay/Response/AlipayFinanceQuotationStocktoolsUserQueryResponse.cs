using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFinanceQuotationStocktoolsUserQueryResponse.
    /// </summary>
    public class AlipayFinanceQuotationStocktoolsUserQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否存在有效的订阅。如果存在有效的订阅，说明用户是已经付费过的用户，可查看完整的服务内容。
        /// </summary>
        [JsonPropertyName("auth_status")]
        public bool AuthStatus { get; set; }

        /// <summary>
        /// 表示用户的订阅的到期时间。可用于提示用户及时续订等功能。未订阅时此字段为空
        /// </summary>
        [JsonPropertyName("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 用户是否可参与免费试用。如果可参与免费试用的话，会允许用户享受一个7天的免费体验期。
        /// </summary>
        [JsonPropertyName("free_experience_available")]
        public bool FreeExperienceAvailable { get; set; }

        /// <summary>
        /// 剩余可用天数。与过期时间相对应。40代表会在40天后过期。部分机构希望有此字段避免前端做额外计算。
        /// </summary>
        [JsonPropertyName("remain_days")]
        public long RemainDays { get; set; }

        /// <summary>
        /// 建议的价格文案描述。方便机构给非付费用户提示。实际定价以蚂蚁域内的功能为准。此处纯展示目的。
        /// </summary>
        [JsonPropertyName("suggest_price")]
        public string SuggestPrice { get; set; }
    }
}
