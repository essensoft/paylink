using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppJfexportInstbillQueryResponse.
    /// </summary>
    public class AlipayEbppJfexportInstbillQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 户号
        /// </summary>
        [JsonPropertyName("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 业务类型英文名称
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// "utility_" + uniqId，缓存的账单的key，每次查询均保证唯一性，但是不保证幂等性，在创建时需要透传回支付宝这边。
        /// </summary>
        [JsonPropertyName("cache_key")]
        public string CacheKey { get; set; }

        /// <summary>
        /// 出账机构英文简称
        /// </summary>
        [JsonPropertyName("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 缴费模式:2-账单模式;4-缴清欠费模式;5-欠费自由缴模式。
        /// </summary>
        [JsonPropertyName("charge_mode")]
        public string ChargeMode { get; set; }

        /// <summary>
        /// 拓展字段，json串(key-value对)
        /// </summary>
        [JsonPropertyName("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 机构账单列表，如果有多条，只允许选择其中的一条进行支付。
        /// </summary>
        [JsonPropertyName("inst_bills")]
        public List<JfExportInstBillModel> InstBills { get; set; }

        /// <summary>
        /// 账单拥有者姓名
        /// </summary>
        [JsonPropertyName("owner_name")]
        public string OwnerName { get; set; }

        /// <summary>
        /// 子业务类型英文简称
        /// </summary>
        [JsonPropertyName("sub_biz_type")]
        public string SubBizType { get; set; }
    }
}
