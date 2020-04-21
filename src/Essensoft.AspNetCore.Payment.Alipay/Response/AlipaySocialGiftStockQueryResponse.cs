using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialGiftStockQueryResponse.
    /// </summary>
    public class AlipaySocialGiftStockQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 可用库存总条数
        /// </summary>
        [JsonPropertyName("available_count")]
        public long AvailableCount { get; set; }

        /// <summary>
        /// 已存在券码列表, 已通过创建接口上传的列表
        /// </summary>
        [JsonPropertyName("exist_list")]
        public List<string> ExistList { get; set; }

        /// <summary>
        /// 不存券码列表，还未上传过的券码
        /// </summary>
        [JsonPropertyName("not_exist_list")]
        public List<string> NotExistList { get; set; }

        /// <summary>
        /// 库存总条数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
