using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntfortuneQuotationPlateIndexQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneQuotationPlateIndexQueryModel : AlipayObject
    {
        /// <summary>
        /// 如果类型为getIds，则为空即可。  如果类型为getInfo,则填入板块id。板块的Id,返回板块的详细信息。包括板块的名称，所属股票的代码和名称。
        /// </summary>
        [JsonProperty("plate_id")]
        public string PlateId { get; set; }

        /// <summary>
        /// getIds 用于获取板块数据  getInfo 用于获取具体板块的数据
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
