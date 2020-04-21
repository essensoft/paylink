using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerbaseinfoBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 租户code，alipay or taobao
        /// </summary>
        [JsonPropertyName("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序id列表
        /// </summary>
        [JsonPropertyName("mini_app_id_list")]
        public List<MiniAppBaseInfoQueryInfo> MiniAppIdList { get; set; }
    }
}
