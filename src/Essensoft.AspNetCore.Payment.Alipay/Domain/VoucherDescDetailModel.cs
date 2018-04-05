using Newtonsoft.Json;
using System.Collections.Generic;

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
        [JsonProperty("details")]
        public List<string> Details { get; set; }

        /// <summary>
        /// 优惠的标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
