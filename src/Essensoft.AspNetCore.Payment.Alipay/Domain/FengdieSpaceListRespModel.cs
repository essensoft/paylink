using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FengdieSpaceListRespModel Data Structure.
    /// </summary>
    public class FengdieSpaceListRespModel : AlipayObject
    {
        /// <summary>
        /// 当前VIP用户下面所有的空间详情列表
        /// </summary>
        [JsonPropertyName("list")]
        public List<FengdieSpaceDetailModel> List { get; set; }

        /// <summary>
        /// 分页数据信息，包含总数，分页数，当前页码，请求每页的数量
        /// </summary>
        [JsonPropertyName("paginator")]
        public FengdieListPaginator Paginator { get; set; }
    }
}
