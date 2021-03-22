using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenSpBlueseaactivityQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenSpBlueseaactivityQueryModel : AlipayObject
    {
        /// <summary>
        /// 申请单 id。通过 <a href="https://opendocs.alipay.com/apis/01ebig">alipay.open.sp.blueseaactivity.create</a>接口获取
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }
    }
}
