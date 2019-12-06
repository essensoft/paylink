using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataIntelligentIndicatorQueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingDataIntelligentIndicatorQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务类型。1.PlanQuery 智能方案效果查询；2.PlanQueryByStore 智能营销方案门店效果查询
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// promo_id：为智能活动的id，当bizType= ‘PlanQuery'和bizType= ‘PlanQueryByStore'取这里的值；  sort_field：为排序指标KEY  sort_type：ASC表示升序,DESC表示降序  store_Ids：为门店ID，多个门店使用逗号分隔
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 操作人信息
        /// </summary>
        [JsonPropertyName("operator_context")]
        public PromoOperatorInfo OperatorContext { get; set; }

        /// <summary>
        /// 外部业务id，请保持足够的复杂，方便数据来源排查
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 获取的报告时间,格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("report_date")]
        public string ReportDate { get; set; }
    }
}
