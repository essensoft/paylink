using Essensoft.AspNetCore.Payment.JDPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.JDPay.Request
{
    /// <summary>
    /// 代付交易请求接口
    /// </summary>
    public class JDPayDefrayPayRequest : IJDPayNPP10Request<JDPayDefrayPayResponse>
    {
        /// <summary>
        /// 请求时间
        /// </summary>
        public string RequestDatetime { get; set; }

        /// <summary>
        /// 商户订单流水号
        /// </summary>
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 业务订单流水号
        /// </summary>
        public string BizTradeNo { get; set; }

        /// <summary>
        /// 外部订单日
        /// </summary>
        public string OutTradeDate { get; set; }

        /// <summary>
        /// 订单交易金额
        /// </summary>
        public string TradeAmount { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        public string TradeCurrency { get; set; }

        /// <summary>
        /// 卖方信息
        /// </summary>
        public string SellerInfo { get; set; }

        /// <summary>
        /// 订单摘要
        /// </summary>
        public string TradeSubject { get; set; }

        /// <summary>
        /// 商户售卖的商品分类码
        /// </summary>
        public string CategoryCode { get; set; }

        /// <summary>
        /// 支付工具
        /// </summary>
        public string PayTool { get; set; }

        /// <summary>
        /// 提交业务渠道
        /// </summary>
        public string TradeSource { get; set; }

        /// <summary>
        /// 收款银行编码
        /// </summary>
        public string PayeeBankCode { get; set; }

        /// <summary>
        /// 收款联行号
        /// </summary>
        public string PayeeBankAssociatedCode { get; set; }

        /// <summary>
        /// 收款银行全称
        /// </summary>
        public string PayeeBankFullname { get; set; }

        /// <summary>
        /// 收款行所在国家地区码
        /// </summary>
        public string PayeeBankCountryCode { get; set; }

        /// <summary>
        /// 收款行所在省编码
        /// </summary>
        public string PayeeBankProvinceCode { get; set; }

        /// <summary>
        /// 收款行所在市编码
        /// </summary>
        public string PayeeBankCityCode { get; set; }

        /// <summary>
        /// 收款卡种
        /// </summary>
        public string PayeeCardType { get; set; }

        /// <summary>
        /// 收款账户类型
        /// </summary>
        public string PayeeAccountType { get; set; }

        /// <summary>
        /// 收款账户号
        /// </summary>
        public string PayeeAccountNo { get; set; }

        /// <summary>
        /// 收款账户名称
        /// </summary>
        public string PayeeAccountName { get; set; }

        /// <summary>
        /// 持卡人证件类型
        /// </summary>
        public string PayeeIdType { get; set; }

        /// <summary>
        /// 持卡人证件号
        /// </summary>
        public string PayeeIdNo { get; set; }

        /// <summary>
        /// 持卡人手机
        /// </summary>
        public string PayeeMobile { get; set; }

        /// <summary>
        /// 服务器通知地址
        /// </summary>
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 交易回传参数
        /// </summary>
        public string ReturnParams { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        public string ExtendParams { get; set; }

        /// <summary>
        /// 银行卡信息类型
        /// </summary>
        public string BankCardInfoType { get; set; }

        /// <summary>
        /// 卡ID
        /// </summary>
        public string BankCardId { get; set; }

        #region IJDPayNPP10Request

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new JDPayDictionary()
            {
                { "request_datetime", RequestDatetime },
                { "out_trade_no",  OutTradeNo },
                { "biz_trade_no", BizTradeNo },
                { "out_trade_date", OutTradeDate },
                { "trade_amount", TradeAmount },
                { "trade_currency", TradeCurrency },
                { "seller_info", SellerInfo },
                { "trade_subject", TradeSubject },
                { "category_code", CategoryCode },
                { "pay_tool", PayTool },
                { "trade_source", TradeSource },
                { "payee_bank_code", PayeeBankCode },
                { "payee_bank_associated_code", PayeeBankAssociatedCode },
                { "payee_bank_fullname", PayeeBankFullname },
                { "payee_bank_country_code", PayeeBankCountryCode },
                { "payee_bank_province_code", PayeeBankProvinceCode },
                { "payee_bank_city_code", PayeeBankCityCode },
                { "payee_card_type", PayeeCardType },
                { "payee_account_type", PayeeAccountType },
                { "payee_account_no", PayeeAccountNo },
                { "payee_account_name", PayeeAccountName },
                { "payee_id_type", PayeeIdType },
                { "payee_id_no", PayeeIdNo },
                { "payee_mobile", PayeeMobile },
                { "notify_url", NotifyUrl },
                { "return_params", ReturnParams },
                { "extend_params", ExtendParams },
                { "bank_card_info_type", BankCardInfoType },
                { "bank_card_id", BankCardId },
            };

            return parameters;
        }

        public string GetRequestUrl()
        {
            return "https://mapi.jdpay.com/npp10/defray_pay";
        }

        #endregion
    }
}
