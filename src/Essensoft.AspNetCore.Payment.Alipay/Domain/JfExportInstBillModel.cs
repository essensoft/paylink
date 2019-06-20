using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// JfExportInstBillModel Data Structure.
    /// </summary>
    [Serializable]
    public class JfExportInstBillModel : AlipayObject
    {
        /// <summary>
        /// 账单金额，单位为：RMB元。
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 余额，单位为：RMB元。
        /// </summary>
        [JsonProperty("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 账期
        /// </summary>
        [JsonProperty("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 滞纳金，单位为：RMB元。
        /// </summary>
        [JsonProperty("bill_fines")]
        public string BillFines { get; set; }

        /// <summary>
        /// 户号
        /// </summary>
        [JsonProperty("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 拓展字段，json串(key-value对)
        /// </summary>
        [JsonProperty("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 机构流水号
        /// </summary>
        [JsonProperty("inst_bill_no")]
        public string InstBillNo { get; set; }

        /// <summary>
        /// 账单拥有者姓名
        /// </summary>
        [JsonProperty("owner_name")]
        public string OwnerName { get; set; }

        /// <summary>
        /// 唯一标识，每次查询均保证唯一性，但是不保证幂等性
        /// </summary>
        [JsonProperty("uniq_id")]
        public string UniqId { get; set; }
    }
}
