using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantTradecomplainBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayMerchantTradecomplainBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 查询开始时间 时间格式：yyyy-MM-dd HH:mm:ss 若不填写，则默认当前时间30天前。 注意：begin_time和end_time时间跨度最大一年
        /// </summary>
        [JsonPropertyName("begin_time")]
        public string BeginTime { get; set; }

        /// <summary>
        /// 查询结束时间 时间格式：yyyy-MM-dd HH:mm:ss 若不填写，则默认当前时间。 注意：begin_time和end_time时间跨度最大一年
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 当前页，从1开始
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数，默认10条，最多支持20条
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 投诉工单状态 商家处理中：MERCHANT_PROCESSING 商家已反馈：MERCHANT_FEEDBACKED 投诉已完结：FINISHED 投诉已撤销：CANCELLED 平台处理中：PLATFORM_PROCESSING 平台处理完结：PLATFORM_FINISH 系统关闭：CLOSED
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 应用信息
        /// </summary>
        [JsonPropertyName("target_infos")]
        public List<TargetInfo> TargetInfos { get; set; }
    }
}
