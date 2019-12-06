using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringTablecodeQueryResponse.
    /// </summary>
    public class KoubeiCateringTablecodeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 返回值为shop_code表示只返回了门店码 返回值为table_code表示返回了桌码跟门店码
        /// </summary>
        [JsonPropertyName("code_flag")]
        public string CodeFlag { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 桌码
        /// </summary>
        [JsonPropertyName("table_num")]
        public string TableNum { get; set; }
    }
}
