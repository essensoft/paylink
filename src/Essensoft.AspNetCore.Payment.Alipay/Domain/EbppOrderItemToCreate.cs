using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EbppOrderItemToCreate Data Structure.
    /// </summary>
    [Serializable]
    public class EbppOrderItemToCreate : AlipayObject
    {
        /// <summary>
        /// 业务金额
        /// </summary>
        [JsonProperty("biz_amount")]
        public string BizAmount { get; set; }

        /// <summary>
        /// 业务产品id，由支付宝分配。
        /// </summary>
        [JsonProperty("biz_prod_id")]
        public string BizProdId { get; set; }

        /// <summary>
        /// 扩展字段  （缴税业务：  taxpayerName - 纳税人名称，  taxPayerCode - 纳税人识别号，  taxOrgCode - 所属机关代码，  outerLevyNo - 外部申报号/电子税票号码，  ）
        /// </summary>
        [JsonProperty("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 机构端对该子项所代表的这笔业务的唯一标识。
        /// </summary>
        [JsonProperty("inst_item_id")]
        public string InstItemId { get; set; }
    }
}
