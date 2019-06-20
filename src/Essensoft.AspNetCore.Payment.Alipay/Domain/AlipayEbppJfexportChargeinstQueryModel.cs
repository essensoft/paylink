using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppJfexportChargeinstQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppJfexportChargeinstQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务类型英文简称，固定传JF，表示缴费
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 拓展字段，json串(key-value对)
        /// </summary>
        [JsonProperty("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 第几页，从1开始，默认为1
        /// </summary>
        [JsonProperty("page")]
        public long Page { get; set; }

        /// <summary>
        /// 是否分页查询，非分页查询时最多返回500条数据。
        /// </summary>
        [JsonProperty("page_query")]
        public bool PageQuery { get; set; }

        /// <summary>
        /// 每页展示的行数，默认为10
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 子业务类型英文简称，ELECTRIC-电费，WATER-水费，GAS-燃气费
        /// </summary>
        [JsonProperty("sub_biz_type")]
        public string SubBizType { get; set; }
    }
}
