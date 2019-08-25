using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerbaseinfoBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 租户code，alipay or taobao
        /// </summary>
        [JsonProperty("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序id列表
        /// </summary>
        [JsonProperty("mini_app_id_list")]
        public List<MiniAppBaseInfoQueryInfo> MiniAppIdList { get; set; }
    }
}
