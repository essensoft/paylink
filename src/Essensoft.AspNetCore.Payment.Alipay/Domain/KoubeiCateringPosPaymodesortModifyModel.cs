using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosPaymodesortModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosPaymodesortModifyModel : AlipayObject
    {
        /// <summary>
        /// 支付方式名称列表
        /// </summary>
        [JsonProperty("pay_names")]
        public List<string> PayNames { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
