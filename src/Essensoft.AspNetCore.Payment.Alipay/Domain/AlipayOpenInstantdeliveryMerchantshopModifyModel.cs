using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenInstantdeliveryMerchantshopModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenInstantdeliveryMerchantshopModifyModel : AlipayObject
    {
        /// <summary>
        /// 联系人姓名
        /// </summary>
        [JsonPropertyName("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 要更新的配送公司列表，必须包含已经创建过该门店的配送公司，可以新增开通了账户的配送公司
        /// </summary>
        [JsonPropertyName("logistics_codes")]
        public List<string> LogisticsCodes { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 联系人电话/手机号
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 商家门店编码
        /// </summary>
        [JsonPropertyName("shop_no")]
        public string ShopNo { get; set; }
    }
}
