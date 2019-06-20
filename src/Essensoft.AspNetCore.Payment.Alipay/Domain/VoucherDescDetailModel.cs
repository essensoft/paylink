using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VoucherDescDetailModel Data Structure.
    /// </summary>
    [Serializable]
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
