using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// HbProductOrderQueryResponse Data Structure.
    /// </summary>
    public class HbProductOrderQueryResponse : AlipayObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 合约订购列表
        /// </summary>
        [JsonPropertyName("product_order_list")]
        public List<ProductOrderDTO> ProductOrderList { get; set; }

        /// <summary>
        /// 业务是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
