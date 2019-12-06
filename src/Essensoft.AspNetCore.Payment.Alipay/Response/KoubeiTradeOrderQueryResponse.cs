using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiTradeOrderQueryResponse.
    /// </summary>
    public class KoubeiTradeOrderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 订单对应活动信息，多个商品情况下可能对应多个活动，故为列表;可根据此活动号查询活动名，以标注该购买的商品隶属于哪个活动。
        /// </summary>
        [JsonPropertyName("activity_infos")]
        public List<KbOrderActivityModel> ActivityInfos { get; set; }

        /// <summary>
        /// 购买用户UID，对应买家登陆的支付宝账号
        /// </summary>
        [JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 联系方式，买家下单时写入，便于卖家联系买家
        /// </summary>
        [JsonPropertyName("contact")]
        public string Contact { get; set; }

        /// <summary>
        /// 订单资金流水，具体字段如下：  funds_voucher_no:资金凭证ID；  gmt_create:资金流转发生时间;  amount:金额；  shop_id:门店ID；  store_id:外部门店ID,即ISV系统中的门店ID，用于与口碑的对应  account:资金流入账户;  trans_type:资金刘庄类型,PAY/SETTLE/REFUND分别对应支付／打款／退款
        /// </summary>
        [JsonPropertyName("funds_vouchers")]
        public List<KbOrderFundsVoucherModel> FundsVouchers { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 订单最后修改时间(支付/核销/过期退款||用户主动退款)
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 口碑订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部业务流水编号,推荐:yyyymmddhhmmssSSS99999999(年月日时分秒+8位随机码)，开发者可根据该编号与口碑订单一一对应。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 购买门店所属商家PID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 实付金额，单位为元，消费者实际支付金额
        /// </summary>
        [JsonPropertyName("real_amount")]
        public string RealAmount { get; set; }

        /// <summary>
        /// 卖家用户收款账号识别码
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 购买店铺信息，详细字段如下：  shop_id:门店ID;   store_id:外部门店ID,即ISV系统中的门店ID，用于与口碑的对应;  shop_name:门店名称;
        /// </summary>
        [JsonPropertyName("shop")]
        public KbOrderShopModel Shop { get; set; }

        /// <summary>
        /// UNPAY：未支付／待支付  PAY：已支付  FINISH:已完成  CLOSE：已关闭
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 总金额，单位为元，此金额为交易创建金额，为商品优惠前价格*数量。
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 订单支付流水号
        /// </summary>
        [JsonPropertyName("trans_no")]
        public string TransNo { get; set; }

        /// <summary>
        /// 凭证列表，每笔订单会根据购买商品种类数量生成凭证信息；如果交易未成功（比如交易超时关闭等），则不会返回该字段。  具体字段如下：  voucher_id：商品凭证ID;  item_id:商品ID;  shop_id:门店ID;   store_id:外部门店ID,即ISV系统中的门店ID，用于与口碑的对应;  funds_voucher_no:凭证对应资金凭证ID，发货凭证列表,根据funds_voucher_no可从funds_vouchers获取订单资金流;  status:凭证状态，参照凭证状态对照表  refund_type：退款类型，ROLE_DAEMON（超期未使用），ROLE_USER（消费者主动）；  refund_reason：退款理由，由消费者选择或填写内容，系统退款可以为空。
        /// </summary>
        [JsonPropertyName("vouchers")]
        public List<KbOrderVoucherModel> Vouchers { get; set; }
    }
}
