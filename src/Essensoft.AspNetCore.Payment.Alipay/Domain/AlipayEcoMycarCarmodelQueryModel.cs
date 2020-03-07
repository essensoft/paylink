using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarCarmodelQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarCarmodelQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝车型库车型编号,系统唯一。
        /// </summary>
        [JsonPropertyName("model_id")]
        public string ModelId { get; set; }
    }
}
