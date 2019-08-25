using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosDeskModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosDeskModifyModel : AlipayObject
    {
        /// <summary>
        /// 餐桌信息
        /// </summary>
        [JsonProperty("pos_desk")]
        public DeskEntity PosDesk { get; set; }
    }
}
