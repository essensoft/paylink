using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AccessProduceOrder Data Structure.
    /// </summary>
    [Serializable]
    public class AccessProduceOrder : AlipayObject
    {
        /// <summary>
        /// 口碑码批次号
        /// </summary>
        [JsonProperty("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 生产单标识
        /// </summary>
        [JsonProperty("produce_order_id")]
        public string ProduceOrderId { get; set; }

        /// <summary>
        /// 生产数量
        /// </summary>
        [JsonProperty("produce_quantity")]
        public long ProduceQuantity { get; set; }

        /// <summary>
        /// 物料属性名称
        /// </summary>
        [JsonProperty("stuff_attr_name")]
        public string StuffAttrName { get; set; }

        /// <summary>
        /// 物料材质
        /// </summary>
        [JsonProperty("stuff_material")]
        public string StuffMaterial { get; set; }

        /// <summary>
        /// 物料尺寸
        /// </summary>
        [JsonProperty("stuff_size")]
        public string StuffSize { get; set; }

        /// <summary>
        /// 物料类型
        /// </summary>
        [JsonProperty("stuff_type")]
        public string StuffType { get; set; }

        /// <summary>
        /// 模板唯一标识
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [JsonProperty("template_name")]
        public string TemplateName { get; set; }
    }
}
