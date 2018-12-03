using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.UnionPay.Response;

namespace Essensoft.AspNetCore.Payment.UnionPay.Request
{
    /// <summary>
    /// 手机控件支付(V2.2) 消费接口
    /// </summary>

    public class UnionPayMobileControlPayConsumeRequest : IUnionPayRequest<UnionPayMobileControlPayConsumeResponse>
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
        /// 前台通知地址
        /// </summary>
        public string FrontUrl { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        public string AccNo { get; set; }

        /// <summary>
        /// 支付卡类型
        /// </summary>
        public string PayCardType { get; set; }

        /// <summary>
        /// 保留域
        /// </summary>
        public string Reserved { get; set; }

        /// <summary>
        /// 发卡机构代码
        /// </summary>
        public string IssInsCode { get; set; }

        /// <summary>
        /// 分账域
        /// </summary>
        public string AccSplitData { get; set; }

        /// <summary>
        /// 风控信息域
        /// </summary>
        public string RiskRateInfo { get; set; }

        /// <summary>
        /// 控制规则
        /// </summary>
        public string CtrlRule { get; set; }

        /// <summary>
        /// 默认支付方式
        /// </summary>
        public string DefaultPayType { get; set; }

        /// <summary>
        /// 请求方保留域
        /// </summary>
        public string ReqReserved { get; set; }

        /// <summary>
        /// 银行卡验证信息及身份信息
        /// </summary>
        public string CustomerInfo { get; set; }

        /// <summary>
        /// 订单接收超时时间
        /// </summary>
        public string OrderTimeOut { get; set; }

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
                { "orderDesc", OrderDesc },
                { "subMerId", SubMerId },
                { "subMerAbbr", SubMerAbbr },
                { "subMerName", SubMerName },
                { "instalTransInfo", InstalTransInfo },
                { "frontUrl", FrontUrl },
                { "accNo", AccNo },
                { "payCardType", PayCardType },
                { "reserved", Reserved },
                { "issInsCode", IssInsCode },
                { "accSplitData", AccSplitData },
                { "riskRateInfo", RiskRateInfo },
                { "ctrlRule", CtrlRule },
                { "defaultPayType", DefaultPayType },
                { "reqReserved", ReqReserved },
                { "customerInfo", CustomerInfo },
                { "orderTimeout", OrderTimeOut },
            };
            return parameters;
        }

        public string GetRequestUrl(bool isTest)
        {
            return isTest ? "https://gateway.test.95516.com/gateway/api/appTransReq.do" : "https://gateway.95516.com/gateway/api/appTransReq.do";
        }

        public bool HasEncryptCertId()
        {
            return false;
        }

        #endregion
    }

}
