using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarCarmodelQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarCarmodelQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝车型库车型编号,系统唯一。
        /// </summary>
        [JsonProperty("model_id")]
        public string ModelId { get; set; }
    }
}
