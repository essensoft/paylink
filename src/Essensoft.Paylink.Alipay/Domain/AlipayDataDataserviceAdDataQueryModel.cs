using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdDataQueryModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceAdDataQueryModel : AlipayObject
    {
        /// <summary>
        /// 汇总数据广告层级类型。枚举值如下： *  PLAN：计划。 *  GROUP：单元。 *  CREATIVE：创意。 *  USER：用户。
        /// </summary>
        [JsonPropertyName("ad_level")]
        public string AdLevel { get; set; }

        /// <summary>
        /// 支付宝数字推广平台提供给外部系统的访问 token。
        /// </summary>
        [JsonPropertyName("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 计费方式。当ad_level='USER'，该入参必填。枚举值如下： *  CPC：按点击付费。 *  CPM：按展示次数付费。 *  CPD：按投放天数计费（包段）。 *  CPA：按转化效果计费。
        /// </summary>
        [JsonPropertyName("charge_type")]
        public string ChargeType { get; set; }

        /// <summary>
        /// 数据查询结束时间，时间格式为 yyyyMMdd。 注意：查询时间间隔不能大于30天。
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 外部平台导入广告库后，广告投放层级的对应的外部资源ID、商户PID，list最大长度为1000
        /// </summary>
        [JsonPropertyName("outer_id_list")]
        public List<string> OuterIdList { get; set; }

        /// <summary>
        /// 数据查询类型，默认为 ALL_SUM。枚举值如下： *  GROUP_SUM：日期范围内 outer_id_list 中根据 id group by 后进行数据求和。 *  ALL_SUM：日期范围内 outer_id_list 中所有数据求和。 *  DETAIL：数据详情。
        /// </summary>
        [JsonPropertyName("query_type")]
        public string QueryType { get; set; }

        /// <summary>
        /// 数据查询开始时间，时间格式为 yyyyMMdd。 注意：查询时间间隔不能大于30天。
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }
    }
}
