using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotGroupDeleteModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotGroupDeleteModel : AlipayObject
    {
        /// <summary>
        /// 需要删除的分组id
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }
    }
}
