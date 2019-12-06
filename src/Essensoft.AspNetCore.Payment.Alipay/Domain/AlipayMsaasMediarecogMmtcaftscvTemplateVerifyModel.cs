using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvTemplateVerifyModel Data Structure.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcaftscvTemplateVerifyModel : AlipayObject
    {
        /// <summary>
        /// 商品Id列表
        /// </summary>
        [JsonPropertyName("algorithm_goods_ids")]
        public List<string> AlgorithmGoodsIds { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonPropertyName("good_count")]
        public long GoodCount { get; set; }

        /// <summary>
        /// 机型编号
        /// </summary>
        [JsonPropertyName("machine_type_id")]
        public string MachineTypeId { get; set; }

        /// <summary>
        /// 场景关联id
        /// </summary>
        [JsonPropertyName("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 模板编号
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
