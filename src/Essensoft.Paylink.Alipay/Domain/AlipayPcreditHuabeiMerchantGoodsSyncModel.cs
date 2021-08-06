using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiMerchantGoodsSyncModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiMerchantGoodsSyncModel : AlipayObject
    {
        /// <summary>
        /// 同步的宝贝信息列表
        /// </summary>
        [JsonPropertyName("item_list")]
        public List<HbMeiWeiItemSync> ItemList { get; set; }

        /// <summary>
        /// 商家宝贝信息同步，商户请求蚂蚁侧
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
