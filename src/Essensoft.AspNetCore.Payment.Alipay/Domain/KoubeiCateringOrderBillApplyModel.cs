using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringOrderBillApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringOrderBillApplyModel : AlipayObject
    {
        /// <summary>
        /// 应收金额
        /// </summary>
        [JsonProperty("bill_amount")]
        [XmlElement("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 账单维度优惠明细，本期识别：  BILL_CHANGE—整单改价；  DISH_CHANGE—单品改价；  MEMBER_DISCOUNT—会员价优惠
        /// </summary>
        [JsonProperty("discount_details")]
        [XmlArray("discount_details")]
        [XmlArrayItem("pos_discount_detail")]
        public List<PosDiscountDetail> DiscountDetails { get; set; }

        /// <summary>
        /// 账单菜列表，包含菜品的优免分摊金额（内部优惠+外部优惠）
        /// </summary>
        [JsonProperty("dish_details")]
        [XmlArray("dish_details")]
        [XmlArrayItem("kb_pos_bill_dish_detail")]
        public List<KbPosBillDishDetail> DishDetails { get; set; }

        /// <summary>
        /// 扩展信息,json对象格式 ,key和value都为字符串
        /// </summary>
        [JsonProperty("ext_info")]
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 是否享受会员价
        /// </summary>
        [JsonProperty("member_flag")]
        [XmlElement("member_flag")]
        public bool MemberFlag { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("memo")]
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 付款金额
        /// </summary>
        [JsonProperty("pay_amount")]
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 账单支付渠道信息
        /// </summary>
        [JsonProperty("pay_channels")]
        [XmlArray("pay_channels")]
        [XmlArrayItem("pos_bill_pay_channel")]
        public List<PosBillPayChannel> PayChannels { get; set; }

        /// <summary>
        /// 就餐人员列表，以英文逗号","分隔
        /// </summary>
        [JsonProperty("people_list")]
        [XmlElement("people_list")]
        public string PeopleList { get; set; }

        /// <summary>
        /// pos业务订单外部主键信息
        /// </summary>
        [JsonProperty("pos_order_key")]
        [XmlElement("pos_order_key")]
        public PosOrderKey PosOrderKey { get; set; }

        /// <summary>
        /// 实收金额
        /// </summary>
        [JsonProperty("receipt_amount")]
        [XmlElement("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 结账时间，格式yyyy-mm-dd hh:mm:ss
        /// </summary>
        [JsonProperty("settle_time")]
        [XmlElement("settle_time")]
        public string SettleTime { get; set; }
    }
}
