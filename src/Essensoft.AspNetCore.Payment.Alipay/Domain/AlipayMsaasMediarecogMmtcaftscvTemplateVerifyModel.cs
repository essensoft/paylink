using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvTemplateVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogMmtcaftscvTemplateVerifyModel : AlipayObject
    {
        /// <summary>
        /// 商品Id列表
        /// </summary>
        [JsonProperty("algorithm_goods_ids")]
        public List<string> AlgorithmGoodsIds { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonProperty("good_count")]
        public long GoodCount { get; set; }

        /// <summary>
        /// 机型编号
        /// </summary>
        [JsonProperty("machine_type_id")]
        public string MachineTypeId { get; set; }

        /// <summary>
        /// 场景关联id
        /// </summary>
        [JsonProperty("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 模板编号
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }
    }
}
