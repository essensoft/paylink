using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosPaymodesortModifyModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosPaymodesortModifyModel : AlipayObject
    {
        /// <summary>
        /// 支付方式名称列表
        /// </summary>
        [JsonPropertyName("pay_names")]
        public List<string> PayNames { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
