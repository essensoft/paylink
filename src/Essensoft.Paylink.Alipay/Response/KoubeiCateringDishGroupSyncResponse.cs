using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringDishGroupSyncResponse.
    /// </summary>
    public class KoubeiCateringDishGroupSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 组模型
        /// </summary>
        [JsonPropertyName("kb_dish_group")]
        public KbdishGroupInfo KbDishGroup { get; set; }
    }
}
