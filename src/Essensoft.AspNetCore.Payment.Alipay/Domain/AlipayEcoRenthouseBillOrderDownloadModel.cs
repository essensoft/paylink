using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoRenthouseBillOrderDownloadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoRenthouseBillOrderDownloadModel : AlipayObject
    {
        /// <summary>
        /// 查询日期
        /// </summary>
        [JsonProperty("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 商户编号
        /// </summary>
        [JsonProperty("merchant_no")]
        public string MerchantNo { get; set; }
    }
}
