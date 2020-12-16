using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectBindQueryResponse.
    /// </summary>
    public class AntMerchantExpandIndirectBindQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商户ID 若传入smid返回。为空表示没有
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// smid列表 若传入partner_id返回。为空表示没有
        /// </summary>
        [JsonPropertyName("smid")]
        public List<string> Smid { get; set; }
    }
}
