using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GoodsVO Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsVO : AlipayObject
    {
        /// <summary>
        /// 商品的附加描述,BOX_LONG:箱的长度(CM),BOX_WIDTH:箱的宽度(CM),BOX_HIGH:箱的高度(CM),BOX_WEIGHT:箱的重量(KG),BOX_LONG:货的长度(CM),BOX_WIDTH:货的宽度(CM),BOX_HIGH:货的高度(CM),BOX_WEIGHT:货的重量(KG),FORBIDDEN_RECEIVE_DAYS:禁收天数,FORBIDDEN_SALE_WEIGHT:禁售天数,EXPIRE_DAYS:到期天数,SPECIFICATION:规格,SPECIFICATION_DESC:规格描述,IMG_URL:图片地址,SALE_AREA:销售区域,ORIGIN_AREA:原产地,TARGET_AREA:发货地,PRODUCTION_PROCESSING:生产工艺,COMPOSITION:成分组成,SAFETY_NO:食品安全证号,USE_CONDITION:使用须知,STORAGE_TIME_TYPE:保质期类型
        /// </summary>
        [JsonProperty("addition_desc")]
        public string AdditionDesc { get; set; }

        /// <summary>
        /// 外部的商品编码
        /// </summary>
        [JsonProperty("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// 商品的生效状态，EFFECTIVE：生效，INVALID：失效
        /// </summary>
        [JsonProperty("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 箱数转换系数
        /// </summary>
        [JsonProperty("box_num")]
        public long BoxNum { get; set; }

        /// <summary>
        /// 菜鸟对应的商品编码
        /// </summary>
        [JsonProperty("cainiao_item_code")]
        public string CainiaoItemCode { get; set; }

        /// <summary>
        /// 货品的基本类目
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// 类目ID
        /// </summary>
        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 货品编码
        /// </summary>
        [JsonProperty("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 货品名称
        /// </summary>
        [JsonProperty("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 最近操作的日期
        /// </summary>
        [JsonProperty("last_operate_time")]
        public string LastOperateTime { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [JsonProperty("last_operator")]
        public string LastOperator { get; set; }

        /// <summary>
        /// 商品的原始价格（含税），单位元
        /// </summary>
        [JsonProperty("origin_price")]
        public string OriginPrice { get; set; }

        /// <summary>
        /// 商品的现价（含税），单位元
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// 出厂价，单位元
        /// </summary>
        [JsonProperty("produce_price")]
        public string ProducePrice { get; set; }

        /// <summary>
        /// 生产厂商名称
        /// </summary>
        [JsonProperty("producer_id")]
        public string ProducerId { get; set; }

        /// <summary>
        /// 生产厂商名称
        /// </summary>
        [JsonProperty("producer_name")]
        public string ProducerName { get; set; }

        /// <summary>
        /// 起售件数
        /// </summary>
        [JsonProperty("sale_limit")]
        public long SaleLimit { get; set; }

        /// <summary>
        /// 商品的规格信息
        /// </summary>
        [JsonProperty("specifications")]
        public string Specifications { get; set; }

        /// <summary>
        /// 保质期（天）
        /// </summary>
        [JsonProperty("storage_time")]
        public long StorageTime { get; set; }

        /// <summary>
        /// 供应商ID
        /// </summary>
        [JsonProperty("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 税率值，单位%
        /// </summary>
        [JsonProperty("tax_rate")]
        public string TaxRate { get; set; }
    }
}
