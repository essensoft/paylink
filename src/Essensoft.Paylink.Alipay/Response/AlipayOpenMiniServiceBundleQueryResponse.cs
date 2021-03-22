using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniServiceBundleQueryResponse.
    /// </summary>
    public class AlipayOpenMiniServiceBundleQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 子服务信息
        /// </summary>
        [JsonPropertyName("data_list")]
        public List<MultiBundleAppServiceResult> DataList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 数据总数量
        /// </summary>
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}
