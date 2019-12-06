using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOfflineMarketShopCategoryQueryModel Data Structure.
    /// </summary>
    public class AlipayOfflineMarketShopCategoryQueryModel : AlipayObject
    {
        /// <summary>
        /// 类目ID，如果为空则查询全部类目。
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 表示接口业务的调用方身份,默认不填标识为ISV。
        /// </summary>
        [JsonPropertyName("op_role")]
        public string OpRole { get; set; }
    }
}
