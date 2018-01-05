using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicArticlesummaryDataBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicArticlesummaryDataBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 开始日期
        /// </summary>
        [JsonProperty("begin_date")]
        public string BeginDate { get; set; }

        /// <summary>
        /// 结束日期，开始日期/结束日期时间跨度最大30天
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; }
    }
}
