using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringItemlistQueryResponse.
    /// </summary>
    public class KoubeiCateringItemlistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商品摘要信息列表
        /// </summary>
        [JsonPropertyName("item_list")]
        public List<CaterItemListInfo> ItemList { get; set; }

        /// <summary>
        /// 请求id。支持英文字母和数字，由开发者自行定义（不允许重复）
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 当前可查询商品总条目数
        /// </summary>
        [JsonPropertyName("total_amount")]
        public long TotalAmount { get; set; }
    }
}
