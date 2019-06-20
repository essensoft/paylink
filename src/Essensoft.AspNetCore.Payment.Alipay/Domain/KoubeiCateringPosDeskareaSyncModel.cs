using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosDeskareaSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosDeskareaSyncModel : AlipayObject
    {
        /// <summary>
        /// 餐区信息
        /// </summary>
        [JsonProperty("desk_area")]
        public DeskAreaEntity DeskArea { get; set; }

        /// <summary>
        /// 标识接口所做操作，add 新增，update 修改，del 删除,其他返回 null
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
