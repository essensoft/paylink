using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvGoodsApplyModel Data Structure.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcaftscvGoodsApplyModel : AlipayObject
    {
        /// <summary>
        /// 商品上新批次号
        /// </summary>
        [JsonPropertyName("batch_num")]
        public string BatchNum { get; set; }

        /// <summary>
        /// 上新商品信息列表
        /// </summary>
        [JsonPropertyName("goods_infos")]
        public List<ApplyGoodsInfo> GoodsInfos { get; set; }

        /// <summary>
        /// 视觉货柜机型ID
        /// </summary>
        [JsonPropertyName("machine_type_id")]
        public string MachineTypeId { get; set; }
    }
}
