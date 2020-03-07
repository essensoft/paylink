using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiSalesKbassetStuffStockoutorderstatusSyncResponse.
    /// </summary>
    public class KoubeiSalesKbassetStuffStockoutorderstatusSyncResponse : AlipayResponse
    {
        /// <summary>
        /// erp单号
        /// </summary>
        [JsonPropertyName("erp_order")]
        public string ErpOrder { get; set; }

        /// <summary>
        /// 报错码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 报错描述
        /// </summary>
        [JsonPropertyName("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// 调用结果
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
