using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosDeskTransferModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosDeskTransferModel : AlipayObject
    {
        /// <summary>
        /// 餐区信息
        /// </summary>
        [JsonPropertyName("sort_area")]
        public List<DeskAreaEntity> SortArea { get; set; }

        /// <summary>
        /// 桌位排序list
        /// </summary>
        [JsonPropertyName("sort_desk")]
        public List<SortDeskParam> SortDesk { get; set; }
    }
}
