using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerversionBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 端参数，可不选，默认支付宝端 枚举列举：支付宝：com.alipay.alipaywallet，高德：com.amap.app
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序版本号
        /// </summary>
        [JsonPropertyName("version_list")]
        public List<MiniAppVersionQueryInfo> VersionList { get; set; }
    }
}
