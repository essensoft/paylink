using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsAutoUserPointReceiveResponse.
    /// </summary>
    public class AlipayInsAutoUserPointReceiveResponse : AlipayResponse
    {
        /// <summary>
        /// 本次成功积攒的积分量  如攒油活动，则是本次积攒油量，单位ml
        /// </summary>
        [JsonPropertyName("save_amount")]
        public long SaveAmount { get; set; }
    }
}
