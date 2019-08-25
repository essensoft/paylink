using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransGroupfundsPayorderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransGroupfundsPayorderCreateModel : AlipayObject
    {
        /// <summary>
        /// 付款活动关联的批次号
        /// </summary>
        [JsonProperty("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 付款方关联的资金单据号，团体资金批次创建后获得/资金单据查询接口获得
        /// </summary>
        [JsonProperty("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 当前发起付款的用户支付宝账户ID
        /// </summary>
        [JsonProperty("current_user_id")]
        public string CurrentUserId { get; set; }

        /// <summary>
        /// 扩展参数，业务扩展使用
        /// </summary>
        [JsonProperty("ext_param")]
        public string ExtParam { get; set; }
    }
}
