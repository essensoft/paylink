using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosDeskareaSyncModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosDeskareaSyncModel : AlipayObject
    {
        /// <summary>
        /// 餐区信息
        /// </summary>
        [JsonPropertyName("desk_area")]
        public DeskAreaEntity DeskArea { get; set; }

        /// <summary>
        /// 标识接口所做操作，add 新增，update 修改，del 删除,其他返回 null
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
