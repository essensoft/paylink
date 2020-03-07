using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserSigncardExistenceQueryResponse.
    /// </summary>
    public class AlipayUserSigncardExistenceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否已经签约快捷或卡通，只统计已激活的签约信息。T代表是，F代表否。
        /// </summary>
        [JsonPropertyName("sign_card_exist")]
        public string SignCardExist { get; set; }
    }
}
