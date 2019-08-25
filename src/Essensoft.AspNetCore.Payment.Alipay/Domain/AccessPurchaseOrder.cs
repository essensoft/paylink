using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AccessPurchaseOrder Data Structure.
    /// </summary>
    [Serializable]
    public class AccessPurchaseOrder : AlipayObject
    {
        /// <summary>
        /// 申请日期, 格式:  yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("apply_date")]
        public string ApplyDate { get; set; }

        /// <summary>
        /// 申请订单明细号
        /// </summary>
        [JsonProperty("asset_item_id")]
        public string AssetItemId { get; set; }

        /// <summary>
        /// 申请订单号
        /// </summary>
        [JsonProperty("asset_order_id")]
        public string AssetOrderId { get; set; }

        /// <summary>
        /// 采购单号（订单汇总表ID）
        /// </summary>
        [JsonProperty("asset_purchase_id")]
        public string AssetPurchaseId { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonProperty("count")]
        public string Count { get; set; }

        /// <summary>
        /// 订单创建日期, 格式: yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("create_date")]
        public string CreateDate { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        [JsonProperty("district")]
        public string District { get; set; }

        /// <summary>
        /// 是否需要生产
        /// </summary>
        [JsonProperty("is_produce")]
        public string IsProduce { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [JsonProperty("province")]
        public string Province { get; set; }

        /// <summary>
        /// 收货人地址
        /// </summary>
        [JsonProperty("receiver_address")]
        public string ReceiverAddress { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        [JsonProperty("receiver_mobile")]
        public string ReceiverMobile { get; set; }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        [JsonProperty("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 物料类型
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
        /// 物料属性
        /// </summary>
        [JsonProperty("stuff_type")]
        public string StuffType { get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板名称，线下约定的物料名
        /// </summary>
        [JsonProperty("template_name")]
        public string TemplateName { get; set; }
    }
}
