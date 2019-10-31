using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbPosOrderDishDetail Data Structure.
    /// </summary>
    [Serializable]
    public class KbPosOrderDishDetail : AlipayObject
    {
        /// <summary>
        /// 改价（单价），以元为单位，精度到分
        /// </summary>
        [JsonProperty("change_price")]
        public string ChangePrice { get; set; }

        /// <summary>
        /// 改价原因
        /// </summary>
        [JsonProperty("change_reason")]
        public string ChangeReason { get; set; }

        /// <summary>
        /// 菜谱ID
        /// </summary>
        [JsonProperty("cook_id")]
        public string CookId { get; set; }

        /// <summary>
        /// 菜谱版本号，用时间戳实现（示例：date.getTime()）
        /// </summary>
        [JsonProperty("cook_version")]
        public string CookVersion { get; set; }

        /// <summary>
        /// 是否可以享受优惠
        /// </summary>
        [JsonProperty("discountable")]
        public bool Discountable { get; set; }

        /// <summary>
        /// 菜品ID
        /// </summary>
        [JsonProperty("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 菜品名称
        /// </summary>
        [JsonProperty("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 菜品数量，≥1
        /// </summary>
        [JsonProperty("dish_num")]
        public long DishNum { get; set; }

        /// <summary>
        /// 菜品单位
        /// </summary>
        [JsonProperty("dish_unit")]
        public string DishUnit { get; set; }

        /// <summary>
        /// 菜品明细版本号
        /// </summary>
        [JsonProperty("dish_version")]
        public long DishVersion { get; set; }

        /// <summary>
        /// 扩展信息，json对象格式，key和value都为字符串。目前包含内容为1、outItemId表示外部菜品id，2、outSkuId外部菜品sku id，3、defaultInCarts开台必点菜。4、cookVersion菜谱版本
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 是否改价
        /// </summary>
        [JsonProperty("has_change")]
        public bool HasChange { get; set; }

        /// <summary>
        /// 是否是主明细，默认都是主明细。除了点套餐的时候，套餐本身这个菜作为主明细设置，套餐下的菜明细作为非主明细设置。
        /// </summary>
        [JsonProperty("main_flag")]
        public bool MainFlag { get; set; }

        /// <summary>
        /// 主明细id，套餐下的菜品对应的主明细id
        /// </summary>
        [JsonProperty("main_out_detail_no")]
        public string MainOutDetailNo { get; set; }

        /// <summary>
        /// 制作状态，取值约定：INIT-未制作，MAKE-已制作，SERVE-已上菜，REFUND-已退菜
        /// </summary>
        [JsonProperty("make_status")]
        public string MakeStatus { get; set; }

        /// <summary>
        /// 会员价（单价），以元为单位，精度到分
        /// </summary>
        [JsonProperty("member_price")]
        public string MemberPrice { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 下单操作员ID
        /// </summary>
        [JsonProperty("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 下单时间，格式yyyy-mm-dd hh:mm:ss
        /// </summary>
        [JsonProperty("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// pos本地订单菜明细流水号
        /// </summary>
        [JsonProperty("out_detail_no")]
        public string OutDetailNo { get; set; }

        /// <summary>
        /// 做法信息，格式按照：做法1,做法2，对于有一般销售属性的菜会拼接一般销售属性信息，格式为：做法1,做法2,销售属性1,销售属性2
        /// </summary>
        [JsonProperty("practice_info")]
        public string PracticeInfo { get; set; }

        /// <summary>
        /// 做法合计加价（单价），以元为单位，精度到分
        /// </summary>
        [JsonProperty("practice_price")]
        public string PracticePrice { get; set; }

        /// <summary>
        /// 退菜原因
        /// </summary>
        [JsonProperty("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退菜时间，格式yyyy-mm-dd hh:mm:ss
        /// </summary>
        [JsonProperty("refund_time")]
        public string RefundTime { get; set; }

        /// <summary>
        /// 催菜次数
        /// </summary>
        [JsonProperty("remind_time")]
        public long RemindTime { get; set; }

        /// <summary>
        /// 销售属性，使用Map<String,List<String>> salesProperties = JSONObject.parseObject(sales_properties,Map.class)转换
        /// </summary>
        [JsonProperty("sales_properties")]
        public string SalesProperties { get; set; }

        /// <summary>
        /// 售价（单价），以元为单位，精度到分
        /// </summary>
        [JsonProperty("sell_price")]
        public string SellPrice { get; set; }

        /// <summary>
        /// 菜品skuId
        /// </summary>
        [JsonProperty("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 菜品点菜序号
        /// </summary>
        [JsonProperty("sort")]
        public long Sort { get; set; }

        /// <summary>
        /// 规格中文名，没有规格时不需要填写
        /// </summary>
        [JsonProperty("spec_name")]
        public string SpecName { get; set; }

        /// <summary>
        /// 菜明细类型，SINGLE(单品)/SIDE(加料)/COMBO(套餐)/COMBO(套餐内单品)
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 用户身份标识：手机号码、userId等等。如果是支付宝扫码点菜的，就是用户userId
        /// </summary>
        [JsonProperty("user_identity")]
        public string UserIdentity { get; set; }

        /// <summary>
        /// 叫起状态，取值约定：WAIT-等待叫起，UP-已叫起
        /// </summary>
        [JsonProperty("wake_status")]
        public string WakeStatus { get; set; }
    }
}
