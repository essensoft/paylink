using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceBillDingstaffbizorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceBillDingstaffbizorderQueryModel : AlipayObject
    {
        /// <summary>
        /// 钉钉业务单据号
        /// </summary>
        [JsonProperty("biz_trans_id")]
        public string BizTransId { get; set; }

        /// <summary>
        /// 业务类型标识。支持类型有：0100-群收款，0101-报销，0102-支付，0103-收款，0104-转账，0105-工资
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 资金流向。S表示收入，B表示支出
        /// </summary>
        [JsonProperty("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 查询结束时间, 日期格式:2018-09-30 00:00:00, 开区间, 默认当前时间点  最多查一年内的数据
        /// </summary>
        [JsonProperty("gmt_date_end")]
        public string GmtDateEnd { get; set; }

        /// <summary>
        /// 查询开始时间, 日期格式:2018-07-30 00:00:00, 闭区间  最多查一年内的数据
        /// </summary>
        [JsonProperty("gmt_date_start")]
        public string GmtDateStart { get; set; }

        /// <summary>
        /// 上次查询最后一笔id, 翻页查询需要带上上次查询最后一笔的id
        /// </summary>
        [JsonProperty("last_id")]
        public string LastId { get; set; }

        /// <summary>
        /// 支付宝流水号
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 分页大小,[0-100], 最大不超过100, 默认20
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 标题,对收支场景描述
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 支付宝虚拟uid
        /// </summary>
        [JsonProperty("virtual_user_id")]
        public string VirtualUserId { get; set; }
    }
}
