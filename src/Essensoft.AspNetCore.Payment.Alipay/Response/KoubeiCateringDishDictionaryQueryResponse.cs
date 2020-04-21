using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringDishDictionaryQueryResponse.
    /// </summary>
    public class KoubeiCateringDishDictionaryQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 返回的字典数据列表
        /// </summary>
        [JsonPropertyName("kb_dish_dictionary_list")]
        public List<KbdishDictionary> KbDishDictionaryList { get; set; }
    }
}
