using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosDeskTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosDeskTransferModel : AlipayObject
    {
        /// <summary>
        /// 餐区信息
        /// </summary>
        [JsonProperty("sort_area")]
        public List<DeskAreaEntity> SortArea { get; set; }

        /// <summary>
        /// 桌位排序list
        /// </summary>
        [JsonProperty("sort_desk")]
        public List<SortDeskParam> SortDesk { get; set; }
    }
}
