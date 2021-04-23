using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInstserviceDeductresultQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppInstserviceDeductresultQueryModel : AlipayObject
    {
        /// <summary>
        /// 申请代扣时的流水号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
