using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorBatchDeleteResponse.
    /// </summary>
    public class KoubeiMerchantOperatorBatchDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 批量删除，不保证事务，可能有部分成功，部分失败;  枚举值为： PART_SUCCESS, ALL_SUCCESS
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// true, false
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
