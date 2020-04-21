using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenOperationBizfeeAftechCancelModel Data Structure.
    /// </summary>
    public class AlipayOpenOperationBizfeeAftechCancelModel : AlipayObject
    {
        /// <summary>
        /// 系统/应用名称
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        [JsonPropertyName("gmt_service")]
        public string GmtService { get; set; }

        /// <summary>
        /// 订单流水号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部业务流水号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 租户Id
        /// </summary>
        [JsonPropertyName("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
