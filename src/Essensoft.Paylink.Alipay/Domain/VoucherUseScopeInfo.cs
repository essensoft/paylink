using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// VoucherUseScopeInfo Data Structure.
    /// </summary>
    public class VoucherUseScopeInfo : AlipayObject
    {
        /// <summary>
        /// 小程序appid列表
        /// </summary>
        [JsonPropertyName("app_id_list")]
        public List<string> AppIdList { get; set; }

        /// <summary>
        /// 商户pid列表
        /// </summary>
        [JsonPropertyName("pid_list")]
        public List<string> PidList { get; set; }

        /// <summary>
        /// 支付宝门店id列表
        /// </summary>
        [JsonPropertyName("shop_id_list")]
        public List<string> ShopIdList { get; set; }
    }
}
