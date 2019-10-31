using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 端参数，可不选，默认支付宝端 枚举列举：支付宝：com.alipay.alipaywallet，高德：com.amap.app
        /// </summary>
        [JsonProperty("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonProperty("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序版本号
        /// </summary>
        [JsonProperty("version_list")]
        public List<MiniAppVersionQueryInfo> VersionList { get; set; }
    }
}
