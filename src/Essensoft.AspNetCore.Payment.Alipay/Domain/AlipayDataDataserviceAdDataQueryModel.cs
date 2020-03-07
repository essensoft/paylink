using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdDataQueryModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceAdDataQueryModel : AlipayObject
    {
        /// <summary>
        /// 汇总数据广告层级类型，如PLAN-计划；GROUP-单元；CREATIVE-创意；USER-用户
        /// </summary>
        [JsonPropertyName("ad_level")]
        public string AdLevel { get; set; }

        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [JsonPropertyName("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 当ad_level='USER'，该入参必填， 计费方式： CPC-按点击付费 CPM-按展示次数付费 CPD-按投放天数计费（包段） CPA-按转化效果计费
        /// </summary>
        [JsonPropertyName("charge_type")]
        public string ChargeType { get; set; }

        /// <summary>
        /// 数据查询开始时间，查询时间间隔不能大于30天，点时间格式：yyyyMMdd
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 外部平台导入广告库后，广告投放层级的对应的外部资源ID、商户PID，list最大长度为1000
        /// </summary>
        [JsonPropertyName("outer_id_list")]
        public List<string> OuterIdList { get; set; }

        /// <summary>
        /// 数据查询类型，默认为ALL_SUM，如GROUP_SUM-日期范围内outer_id_list中根据id group by后进行数据求和；ALL_SUM-日期范围内outer_id_list中所有数据求和；DETAIL-数据详情
        /// </summary>
        [JsonPropertyName("query_type")]
        public string QueryType { get; set; }

        /// <summary>
        /// 数据查询开始时间，查询时间间隔不能大于30天，点时间格式：yyyyMMdd
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }
    }
}
