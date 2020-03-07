using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvMachinetypeQueryModel Data Structure.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcaftscvMachinetypeQueryModel : AlipayObject
    {
        /// <summary>
        /// 类型(0:商品库机型, 1:摆放模板机型)
        /// </summary>
        [JsonPropertyName("type")]
        public long Type { get; set; }
    }
}
