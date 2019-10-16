using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAssetPointPointprodPointlibQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAssetPointPointprodPointlibQueryModel : AlipayObject
    {
        /// <summary>
        /// 集分宝积分库ID
        /// </summary>
        [JsonProperty("point_lib_id")]
        public string PointLibId { get; set; }
    }
}
