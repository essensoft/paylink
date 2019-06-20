using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncInvoicereceiptBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncInvoicereceiptBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 月账单号集合，唯一性ID集合，月账单表唯一主键ID集合
        /// </summary>
        [JsonProperty("bill_nos")]
        public List<string> BillNos { get; set; }

        /// <summary>
        /// 来源类型，01：主站；02：芝麻；03：金融云；04：微贷
        /// </summary>
        [JsonProperty("out_biz_type")]
        public string OutBizType { get; set; }
    }
}
