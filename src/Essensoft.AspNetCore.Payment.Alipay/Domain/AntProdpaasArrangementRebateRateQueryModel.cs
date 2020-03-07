using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntProdpaasArrangementRebateRateQueryModel Data Structure.
    /// </summary>
    public class AntProdpaasArrangementRebateRateQueryModel : AlipayObject
    {
        /// <summary>
        /// 数据项名称
        /// </summary>
        [JsonPropertyName("data_item_name")]
        public string DataItemName { get; set; }

        /// <summary>
        /// 一级类目ID
        /// </summary>
        [JsonPropertyName("first_category_id")]
        public string FirstCategoryId { get; set; }

        /// <summary>
        /// 查询时间
        /// </summary>
        [JsonPropertyName("gmt_query")]
        public string GmtQuery { get; set; }
    }
}
