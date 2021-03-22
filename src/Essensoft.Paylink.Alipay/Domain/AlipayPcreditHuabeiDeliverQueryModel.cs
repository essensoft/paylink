using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiDeliverQueryModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiDeliverQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务参数
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }
    }
}
