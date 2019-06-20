using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvGoodsApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogMmtcaftscvGoodsApplyModel : AlipayObject
    {
        /// <summary>
        /// 商品上新批次号
        /// </summary>
        [JsonProperty("batch_num")]
        public string BatchNum { get; set; }

        /// <summary>
        /// 上新商品信息列表
        /// </summary>
        [JsonProperty("goods_infos")]
        public List<ApplyGoodsInfo> GoodsInfos { get; set; }

        /// <summary>
        /// 视觉货柜机型ID
        /// </summary>
        [JsonProperty("machine_type_id")]
        public string MachineTypeId { get; set; }
    }
}
