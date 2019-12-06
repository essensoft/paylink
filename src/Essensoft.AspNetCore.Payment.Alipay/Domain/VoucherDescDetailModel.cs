using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VoucherDescDetailModel Data Structure.
    /// </summary>
    public class VoucherDescDetailModel : AlipayObject
    {
        /// <summary>
        /// 优惠的说明信息
        /// </summary>
        [JsonPropertyName("details")]
        public List<string> Details { get; set; }

        /// <summary>
        /// 优惠的标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
