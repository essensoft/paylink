using Essensoft.AspNetCore.Payment.UnionPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.UnionPay.Request
{
    /// <summary>
    /// 银联全渠道开通并支付交易
    /// </summary>
    public class UnionPayForm03_6_7_Token_OpenAndConsumeRequest : IUnionPayRequest<UnionPayForm03_6_7_Token_OpenAndConsumeResponse>
    {
        /// <summary>
        /// 产品类型
        /// </summary>
        public string BizType { get; set; }

        /// <summary>
        /// 订单发送时间
        /// </summary>
        public string TxnTime { get; set; }

        /// <summary>
        /// 后台通知地址
        /// </summary>
        public string BackUrl { get; set; }

        /// <summary>
        /// 交易币种
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        public string TxnAmt { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        public string TxnType { get; set; }

        /// <summary>
        /// 交易子类
        /// </summary>
        public string TxnSubType { get; set; }

        /// <summary>
        /// 渠道类型
        /// </summary>
        public string ChannelType { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 标记化支付信息域
        /// </summary>
        public string TokenPayData { get; set; }

        /// <summary>
        /// 订单描述
        /// </summary>
        public string OrderDesc { get; set; }

        /// <summary>
        /// 二级商户代码
        /// </summary>
        public string SubMerId { get; set; }

        /// <summary>
        /// 二级商户简称
        /// </summary>
        public string SubMerAbbr { get; set; }

        /// <summary>
        /// 二级商户名称
        /// </summary>
        public string SubMerName { get; set; }

        /// <summary>
        /// 分期付款信息域
        /// </summary>
        public string InstalTransInfo { get; set; }

        /// <summary>
        /// 商户简称
        /// </summary>
        public string MerAbbr { get; set; }

        /// <summary>
        /// 商户类别
        /// </summary>
        public string MerCatCode { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        public string MerName { get; set; }

        /// <summary>
        /// 收单机构代码
        /// </summary>
        public string AcqInsCode { get; set; }

        /// <summary>
        /// 银行卡验证信息及身份信息
        /// </summary>
        public string CustomerInfo { get; set; }

        /// <summary>
        /// 有卡交易信息域
        /// </summary>
        public string CardTransData { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        public string AccNo { get; set; }

        /// <summary>
        /// 账号类型(卡介质)
        /// </summary>
        public string AccType { get; set; }

        /// <summary>
        /// 保留域
        /// </summary>
        public string Reserved { get; set; }

        /// <summary>
        /// 持卡人IP
        /// </summary>
        public string CustomerIp { get; set; }

        /// <summary>
        /// 订单接收超时时间
        /// </summary>
        public string OrderTimeout { get; set; }

        /// <summary>
        /// 发卡机构代码
        /// </summary>
        public string IssInsNo { get; set; }

        /// <summary>
        /// 风控信息域
        /// </summary>
        public string RiskRateInfo { get; set; }

        /// <summary>
        /// 前台通知地址
        /// </summary>
        public string FrontUrl { get; set; }

        /// <summary>
        /// 请求方保留域
        /// </summary>
        public string ReqReserved { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        public string TermId { get; set; }

        /// <summary>
        /// 终端信息域
        /// </summary>
        public string UserMac { get; set; }

        #region IUnionPayRequest

        private string version = string.Empty;

        public string GetApiVersion()
        {
            return version;
        }

        public void SetApiVersion(string version)
        {
            this.version = version;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new UnionPayDictionary
            {
                { "bizType", BizType },
                { "txnTime", TxnTime },
                { "backUrl", BackUrl },
                { "currencyCode", CurrencyCode },
                { "txnAmt", TxnAmt },
                { "txnType", TxnType },
                { "txnSubType", TxnSubType },
                { "channelType", ChannelType },
                { "orderId", OrderId },
                { "tokenPayData", TokenPayData },
                { "orderDesc", OrderDesc },
                { "subMerId", SubMerId },
                { "subMerAbbr", SubMerAbbr },
                { "subMerName", SubMerName },
                { "instalTransInfo", InstalTransInfo },
                { "merAbbr", MerAbbr },
                { "merCatCode", MerCatCode },
                { "merName", MerName },
                { "acqInsCode", AcqInsCode },
                { "customerInfo", CustomerInfo },
                { "cardTransData", CardTransData },
                { "accNo", AccNo },
                { "accType", AccType },
                { "reserved", Reserved },
                { "customerIp", CustomerIp },
                { "orderTimeout", OrderTimeout },
                { "issInsNo", IssInsNo },
                { "riskRateInfo", RiskRateInfo },
                { "frontUrl", FrontUrl },
                { "reqReserved", ReqReserved },
                { "termId", TermId },
                { "userMac", UserMac },
            };
            return parameters;
        }

        public string GetRequestUrl(bool isTest)
        {
            return isTest ? "https://gateway.test.95516.com/gateway/api/backTransReq.do" : "https://gateway.95516.com/gateway/api/backTransReq.do";
        }

        public bool HasEncryptCertId()
        {
            return true;
        }

        #endregion
    }
}
