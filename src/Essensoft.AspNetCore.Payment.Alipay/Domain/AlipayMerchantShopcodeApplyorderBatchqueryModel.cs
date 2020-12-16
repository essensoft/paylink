using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantShopcodeApplyorderBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayMerchantShopcodeApplyorderBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝侧生成的开通流水编号，可以通过传入该参数查询指定流水编号的开通状态。
        /// </summary>
        [JsonPropertyName("apply_ids")]
        public List<string> ApplyIds { get; set; }

        /// <summary>
        /// 查询结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 开通门店码的商户支付宝登录ID，一般为手机号或邮箱
        /// </summary>
        [JsonPropertyName("merchant_login_ids")]
        public List<string> MerchantLoginIds { get; set; }

        /// <summary>
        /// 服务商操作员小二2088
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页查询数量，用于翻页查询，每次最多查询100条
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 服务商侧生成的开通流水编号，可以通过传入该参数查询指定流水编号的开通状态。
        /// </summary>
        [JsonPropertyName("request_ids")]
        public List<string> RequestIds { get; set; }

        /// <summary>
        /// 外部间联商户PID，最多可传入100个
        /// </summary>
        [JsonPropertyName("smids")]
        public List<string> Smids { get; set; }

        /// <summary>
        /// 查询开始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }
    }
}
