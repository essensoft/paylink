using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniMorphoApplistBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniMorphoApplistBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 批量查询时的，闪蝶应用ID数组
        /// </summary>
        [JsonPropertyName("app_ids")]
        public List<string> AppIds { get; set; }

        /// <summary>
        /// 闪蝶身份验证信息
        /// </summary>
        [JsonPropertyName("identity")]
        public MorphoIdentity Identity { get; set; }

        /// <summary>
        /// 查询应用关键词
        /// </summary>
        [JsonPropertyName("keyword")]
        public string Keyword { get; set; }

        /// <summary>
        /// 应用在线状态
        /// </summary>
        [JsonPropertyName("online_state")]
        public long OnlineState { get; set; }

        /// <summary>
        /// 分页查询页码
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 应用状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 应用类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
