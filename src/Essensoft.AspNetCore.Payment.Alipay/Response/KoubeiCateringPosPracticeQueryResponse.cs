using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosPracticeQueryResponse.
    /// </summary>
    public class KoubeiCateringPosPracticeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 做法模型
        /// </summary>
        [JsonPropertyName("practice_entity_list")]
        public List<PracticeEntity> PracticeEntityList { get; set; }
    }
}
