using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// ZhimaMerchantZmgoCumulateQueryResponse.
    /// </summary>
    public class ZhimaMerchantZmgoCumulateQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 总共累计金额
        /// </summary>
        [JsonPropertyName("aggr_amount")]
        public string AggrAmount { get; set; }

        /// <summary>
        /// 总共累计优惠金额
        /// </summary>
        [JsonPropertyName("aggr_discount_amount")]
        public string AggrDiscountAmount { get; set; }

        /// <summary>
        /// 总共累计次数
        /// </summary>
        [JsonPropertyName("aggr_times")]
        public long AggrTimes { get; set; }

        /// <summary>
        /// 芝麻go协议号，唯一标识一个芝麻go协议。
        /// </summary>
        [JsonPropertyName("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 详情数据列表
        /// </summary>
        [JsonPropertyName("detail_list")]
        public List<CumulateDataDetail> DetailList { get; set; }

        /// <summary>
        /// 查询失败原因
        /// </summary>
        [JsonPropertyName("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 分页参数，返回传入的值。
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页参数，返回传入的值。
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}
