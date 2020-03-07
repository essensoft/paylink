using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringOrderBillApplyModel Data Structure.
    /// </summary>
    public class KoubeiCateringOrderBillApplyModel : AlipayObject
    {
        /// <summary>
        /// 应收金额
        /// </summary>
        [JsonPropertyName("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 账单维度优惠明细，本期识别：  BILL_CHANGE—整单改价；  DISH_CHANGE—单品改价；  MEMBER_DISCOUNT—会员价优惠
        /// </summary>
        [JsonPropertyName("discount_details")]
        public List<PosDiscountDetail> DiscountDetails { get; set; }

        /// <summary>
        /// 账单菜列表，包含菜品的优免分摊金额（内部优惠+外部优惠）
        /// </summary>
        [JsonPropertyName("dish_details")]
        public List<KbPosBillDishDetail> DishDetails { get; set; }

        /// <summary>
        /// 扩展信息,json对象格式 ,key和value都为字符串
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 是否享受会员价
        /// </summary>
        [JsonPropertyName("member_flag")]
        public bool MemberFlag { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 付款金额
        /// </summary>
        [JsonPropertyName("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 账单支付渠道信息
        /// </summary>
        [JsonPropertyName("pay_channels")]
        public List<PosBillPayChannel> PayChannels { get; set; }

        /// <summary>
        /// 就餐人员列表，以英文逗号","分隔
        /// </summary>
        [JsonPropertyName("people_list")]
        public string PeopleList { get; set; }

        /// <summary>
        /// pos业务订单外部主键信息
        /// </summary>
        [JsonPropertyName("pos_order_key")]
        public PosOrderKey PosOrderKey { get; set; }

        /// <summary>
        /// 实收金额
        /// </summary>
        [JsonPropertyName("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 结账时间，格式yyyy-mm-dd hh:mm:ss
        /// </summary>
        [JsonPropertyName("settle_time")]
        public string SettleTime { get; set; }
    }
}
