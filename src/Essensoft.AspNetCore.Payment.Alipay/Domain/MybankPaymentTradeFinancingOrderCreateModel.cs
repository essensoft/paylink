using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankPaymentTradeFinancingOrderCreateModel Data Structure.
    /// </summary>
    public class MybankPaymentTradeFinancingOrderCreateModel : AlipayObject
    {
        /// <summary>
        /// 交易金额，单位：分
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 填ANT_OPEN -表示开发平台
        /// </summary>
        [JsonPropertyName("biz_channel")]
        public string BizChannel { get; set; }

        /// <summary>
        /// 外部订单号，阿里云或外部商业平台订单号
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 融易收卡号（路由使用）
        /// </summary>
        [JsonPropertyName("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 交易币种，默认：156
        /// </summary>
        [JsonPropertyName("currency_value")]
        public string CurrencyValue { get; set; }

        /// <summary>
        /// 合作机构编码，如aliyun
        /// </summary>
        [JsonPropertyName("ext_partner")]
        public string ExtPartner { get; set; }

        /// <summary>
        /// 购买的商品详情，JSON格式，UTF-8编码，如购买的商品信息：商品名称，购买件数等
        /// </summary>
        [JsonPropertyName("goods_info")]
        public string GoodsInfo { get; set; }

        /// <summary>
        /// 商业平台会员ID，开通子户场景必填
        /// </summary>
        [JsonPropertyName("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 订单关闭时间，格式yyyyMMddHHmmss
        /// </summary>
        [JsonPropertyName("order_close_time")]
        public string OrderCloseTime { get; set; }

        /// <summary>
        /// 订单扩展字段，JSON格式，key如下：  买家支付宝Id，  卖家支付宝id，  销售产品码，  借款金额，  保证金金额，  还款信息：如借款期限，日利率，还款方式  样例：  {   "ALIPAY_PAYER_USER_ID": "20885656565656",//买家支付宝id   "ALIPAY_PAYEE_USER_ID": "20885998980000",//卖家支付宝id     "SALE_PD_CODE": "销售产品码",      "LOAN_AMOUNT": "300",//借款金额   "DEPOSIT_AMOUNT": "100",//保证金金额   "LOAN_INFO": //还款信息   "[{\"loanTerm\":{\"term\":12,\"termUnit\":\"M\",\"instalItrv\":1,\"instalType\":\"M\"},\"loanRate\":{\"riskIntRate\":{\"termUnitCode\":\"01\",\"amount\":0.005,\"ratioUnitCode\":\"RM\"}},\"loanRepay\":{\"repayMode\":\"1\"}}]"  }  的URLEncoder.encode（UTF-8）  "LOAN_INFO": //还款信息   具体含义如下，可以下载融资的jar来组织：  [{   "loanTerm": {//还款期限    "term": 12,//总共还款期数    "termUnit": "M",//贷款期限的长度单位(必填)，一般是有年、月、日    "instalItrv": 1,    "instalType": "M"//和termUnit一致   },   "loanRate": {//还款利率    "riskIntRate": {//贷款风险利率（年化）     "termUnitCode": "01",     "amount": 0.005,     "ratioUnitCode": "RM"    }   },   "loanRepay": {//还款方式    "repayMode": "1"   }  }]
        /// </summary>
        [JsonPropertyName("order_ext")]
        public string OrderExt { get; set; }

        /// <summary>
        /// 订单类型，FINANCING_PAY-预付融资
        /// </summary>
        [JsonPropertyName("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 收款方资金明细，JSON格式，UTF-8编码，编码前：[{"accountName":"贵州达","accountExtNo":"8888888222222222","accountType":"CURRENT","instCode":"机构外标即联行号",branchInstCode":"分行机构外标",amount":""}]  其中必填：  accountType-账户类型，阿里云场景填：CURRENT  accountName-户名  accountNo-卡号  amount-付方金额，只有一个付方的场景填订单的amount  instCode-机构外标即联行号，阿里云填323331000001  branchInstCode-机构分行外标，阿里云填323331000001
        /// </summary>
        [JsonPropertyName("payee_fund_detail")]
        public string PayeeFundDetail { get; set; }

        /// <summary>
        /// 付款方资金明细，JSON格式，需要UTF-8编码，使用URLEncoder.encode(String,"UTF-8")，编码前的JSON：  [{"accountName":"贵州达","accountExtNo":"8888888222222222","accountType":"CURRENT","instCode":"机构外标即联行号",branchInstCode":"分行机构外标",amount":""}]  必填：  accountType-账户类型，阿里云场景填：CURRENT  accountName-户名  accountNo-卡号  amount-付方金额，只有一个付方的场景填订单的amount  instCode-机构外标即联行号，阿里云填323331000001  branchInstCode-机构分行外标，阿里云填323331000001
        /// </summary>
        [JsonPropertyName("payer_fund_detail")]
        public string PayerFundDetail { get; set; }

        /// <summary>
        /// 交易备注,URLEncoder.encode(String,"UTF-8")
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 请求流水号，根据此字段做幂等控制
        /// </summary>
        [JsonPropertyName("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 请求时间，格式yyyyMMddHHmmss
        /// </summary>
        [JsonPropertyName("request_time")]
        public string RequestTime { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [JsonPropertyName("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
