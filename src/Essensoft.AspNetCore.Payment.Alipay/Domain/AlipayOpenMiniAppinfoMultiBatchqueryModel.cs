using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniAppinfoMultiBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniAppinfoMultiBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 客户端标识
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 应用id列表参数，比如[2017010362788004,2017010362788005]
        /// </summary>
        [JsonPropertyName("mini_app_id_list")]
        public List<string> MiniAppIdList { get; set; }
    }
}
