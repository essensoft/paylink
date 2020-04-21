using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerappServiceQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerappServiceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序服务信息
        /// </summary>
        [JsonPropertyName("mini_app_service_info_list")]
        public List<MiniAppServiceInfo> MiniAppServiceInfoList { get; set; }

        /// <summary>
        /// 当前页数
        /// </summary>
        [JsonPropertyName("page")]
        public long Page { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
