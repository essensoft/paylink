using System.Xml.Serialization;

namespace Essensoft.AspNetCore.QPay.Response
{
    public class QPayRefundQueryResponse : QPayResponse
    {
        /// <summary>
        /// QQ钱包订单号	
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 商户订单号	
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("total_fee")]
        public int TotalFee { get; set; }

        /// <summary>
        /// 用户支付金额	
        /// </summary>
        [XmlElement("cash_fee")]
        public int CashFee { get; set; }

        /// <summary>
        /// 货币类型定义
        /// </summary>
        [XmlElement("fee_type")]
        public string FeeType { get; set; }

        /*
         out_refund_no_$n
商户退款单号
String(32)
是
商户系统内部的退款单号，商户系统内部唯一，同一退款单号多次请求只退一笔
2015080612
refund_id_$n
QQ钱包退款单号
String(32)
是
QQ钱包退款单号，在成功受理商户的退款申请后，QQ钱包会为本次退款申请生成该 QQ钱包退款单号
1121218133801201611098791376
refund_channel_$n
退款方式
String(16)
是
ORIGINAL 原路退回    
BALANCE 退款到余额
ORIGINAL
refund_fee_$n
退款申请金额
Int
是
本次退款申请的退回金额。单位：分  币种：人民币
666 
coupon_refund_fee_$n
退款申请金额中，优惠或者立减的金额
Int
否
退款申请金额中，优惠或者立减的金额。
n 从0开始。
666
cash_refund_fee_$n
退款申请中的现金金额
Int
否
退款申请中的现金金额。
n 从0开始。
666
refund_status_$n
退款状态定义
String(16)
是
SUCCESS—退款成功  
FAIL—退款失败  
PROCESSING—退款发起成功，正在处理中 
CHANGE—转入代发，退款到银行发现用户的卡作废或者冻结了，导致原路退款银行卡失败，资金回流到商户的现金帐号，需要商户人工干预，通过线下或者财付通转账的方式进行退款。   
n 从0开始。
SUCCESS
refund_recv_accout_$n
退款入账账户
String(64)
是
取当前退款单的退款入账方
1）退回银行卡：
{银行名称}{卡类型}{卡尾号}
2）退回支付用户余额:
支付用户余额
招商银行信用卡0403
         */
    }
}
