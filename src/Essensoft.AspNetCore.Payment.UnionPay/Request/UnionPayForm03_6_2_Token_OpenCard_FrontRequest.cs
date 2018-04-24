using Essensoft.AspNetCore.Payment.UnionPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.UnionPay.Request
{
    /// <summary>
    /// 银联全渠道支付开通交易
    /// </summary>
    public class UnionPayForm03_6_2_Token_OpenCard_FrontRequest : IUnionPayRequest<UnionPayForm03_6_2_Token_OpenCard_FrontResponse>
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
        /// 后台通知地址
        /// 后台返回商户结果时使用，如上送，则发送商户后台交易结果通知，如需通过专线通知，需要在通知地址前面加上前缀：专线的首字母加竖线ZX|
        /// </summary>
        public string BackUrl { get; set; }

        /// <summary>
        /// 交易金额
        /// 单位为分
        /// </summary>
        public string TxnAmt { get; set; }

        /// <summary>
        /// 商户订单号
        /// 商户端生成
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 二级商户代码
        /// 商户类型为平台类商户接入时必须上送
        /// </summary>
        public string SubMerId { get; set; }

        /// <summary>
        /// 二级商户简称
        /// 商户类型为平台类商户接入时必须上送
        /// </summary>
        public string SubMerAbbr { get; set; }

        /// <summary>
        /// 二级商户名称
        /// 商户类型为平台类商户接入时必须上送
        /// </summary>
        public string SubMerName { get; set; }

        /// <summary>
        /// 控制规则
        /// 32位01字符串控制位，从左至右第一位表示财税库银信息控制位，当第一位为1时，财税库银行业信息域taxIndustryInfo必上送
        /// </summary>
        public string CtrlRule { get; set; }

        /// <summary>
        /// 前台通知地址
        /// 前台交易必送
        /// </summary>
        public string FrontUrl { get; set; }

        /// <summary>
        /// 账单要素
        /// </summary>
        public string BillQueryInfo { get; set; }

        /// <summary>
        /// 账号
        /// 产品类型为Token时不上送
        /// </summary>
        public string AccNo { get; set; }

        /// <summary>
        /// 保留域
        /// </summary>
        public string Reserved { get; set; }

        /// <summary>
        /// 风控信息域
        /// </summary>
        public string RiskRateInfo { get; set; }

        /// <summary>
        /// 请求方保留域
        /// 商户自定义保留域，交易应答时会原样返回
        /// </summary>
        public string ReqReserved { get; set; }

        /// <summary>
        /// 银行卡验证信息及身份信息
        /// </summary>
        public string CustomerInfo { get; set; }

        /// <summary>
        /// 账号类型(卡介质)
        /// </summary>
        public string AccType { get; set; }

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
                { "txnType", TxnType },
                { "txnSubType", TxnSubType },
                { "channelType", ChannelType },
                { "backUrl", BackUrl },
                { "txnAmt", TxnAmt },
                { "orderId", OrderId },
                { "subMerId", SubMerId },
                { "subMerAbbr", SubMerAbbr },
                { "subMerName", SubMerName },
                { "ctrlRule", CtrlRule },
                { "frontUrl", FrontUrl },
                { "billQueryInfo", BillQueryInfo },
                { "accNo", AccNo },
                { "reserved", Reserved },
                { "riskRateInfo", RiskRateInfo },
                { "reqReserved", ReqReserved },
                { "customerInfo", CustomerInfo },
                { "accType", AccType },
            };
            return parameters;
        }

        public string GetRequestUrl(bool isTest)
        {
            return isTest ? "https://gateway.test.95516.com/gateway/api/frontTransReq.do" : "https://gateway.95516.com/gateway/api/frontTransReq.do";
        }

        public bool HasEncryptCertId()
        {
            return true;
        }

        #endregion
    }
}
