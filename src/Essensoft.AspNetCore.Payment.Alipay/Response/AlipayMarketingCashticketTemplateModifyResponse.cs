using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCashticketTemplateModifyResponse.
    /// </summary>
    public class AlipayMarketingCashticketTemplateModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 模板修改时的状态，I表示草稿状态所有入参都修改了，S表示生效状态仅修改了publish_end_time
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
