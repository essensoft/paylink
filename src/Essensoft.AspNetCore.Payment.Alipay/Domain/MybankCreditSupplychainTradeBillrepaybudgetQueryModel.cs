using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSupplychainTradeBillrepaybudgetQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainTradeBillrepaybudgetQueryModel : AlipayObject
    {
        /// <summary>
        /// 买家信息
        /// </summary>
        [JsonProperty("buyer")]
        public Member Buyer { get; set; }

        /// <summary>
        /// 渠道类型
        /// </summary>
        [JsonProperty("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [JsonProperty("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 产品销售码
        /// </summary>
        [JsonProperty("sale_pd_code")]
        public string SalePdCode { get; set; }
    }
}
