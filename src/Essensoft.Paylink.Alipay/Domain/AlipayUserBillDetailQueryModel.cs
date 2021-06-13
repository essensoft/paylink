using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayUserBillDetailQueryModel Data Structure.
    /// </summary>
    public class AlipayUserBillDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 账单内部业务流水号，是查询单条账单的必传参数
        /// </summary>
        [JsonPropertyName("biz_in_no")]
        public string BizInNo { get; set; }
    }
}
