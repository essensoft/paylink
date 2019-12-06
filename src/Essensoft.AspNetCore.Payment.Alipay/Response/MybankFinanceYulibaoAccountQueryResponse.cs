using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankFinanceYulibaoAccountQueryResponse.
    /// </summary>
    public class MybankFinanceYulibaoAccountQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 可用份额，单位为元
        /// </summary>
        [JsonPropertyName("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 业务冻结份额，单位为元
        /// </summary>
        [JsonPropertyName("freeze_amount")]
        public string FreezeAmount { get; set; }

        /// <summary>
        /// 系统冻结份额，单位为元（建议不展示给用户）
        /// </summary>
        [JsonPropertyName("sys_freeze_amount")]
        public string SysFreezeAmount { get; set; }

        /// <summary>
        /// 余利宝总余额，单位为元
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 余利宝收益详情
        /// </summary>
        [JsonPropertyName("ylb_profit_detail_info")]
        public YLBProfitDetailInfo YlbProfitDetailInfo { get; set; }
    }
}
