using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntProdpaasArrangementRebateRateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntProdpaasArrangementRebateRateQueryModel : AlipayObject
    {
        /// <summary>
        /// 数据项名称
        /// </summary>
        [JsonProperty("data_item_name")]
        public string DataItemName { get; set; }

        /// <summary>
        /// 一级类目ID
        /// </summary>
        [JsonProperty("first_category_id")]
        public string FirstCategoryId { get; set; }

        /// <summary>
        /// 查询时间
        /// </summary>
        [JsonProperty("gmt_query")]
        public string GmtQuery { get; set; }
    }
}
