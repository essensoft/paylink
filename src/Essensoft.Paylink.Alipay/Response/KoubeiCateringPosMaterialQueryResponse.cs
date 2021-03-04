using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosMaterialQueryResponse.
    /// </summary>
    public class KoubeiCateringPosMaterialQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 配料对象
        /// </summary>
        [JsonPropertyName("material_entity_list")]
        public List<MaterialEntity> MaterialEntityList { get; set; }
    }
}
