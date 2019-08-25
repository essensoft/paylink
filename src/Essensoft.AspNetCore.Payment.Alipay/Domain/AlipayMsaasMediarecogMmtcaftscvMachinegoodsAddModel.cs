using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvMachinegoodsAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogMmtcaftscvMachinegoodsAddModel : AlipayObject
    {
        /// <summary>
        /// 当前请求选取商品算法Id
        /// </summary>
        [JsonProperty("algorithm_goods_id")]
        public string AlgorithmGoodsId { get; set; }

        /// <summary>
        /// 商品摆放姿态
        /// </summary>
        [JsonProperty("display_mode")]
        public string DisplayMode { get; set; }

        /// <summary>
        /// 柜内已有商品摆放状态
        /// </summary>
        [JsonProperty("exist_goods_state")]
        public List<GoodsState> ExistGoodsState { get; set; }

        /// <summary>
        /// 货柜层数
        /// </summary>
        [JsonProperty("floor_num")]
        public long FloorNum { get; set; }

        /// <summary>
        /// 货柜型号
        /// </summary>
        [JsonProperty("machine_type_id")]
        public string MachineTypeId { get; set; }
    }
}
