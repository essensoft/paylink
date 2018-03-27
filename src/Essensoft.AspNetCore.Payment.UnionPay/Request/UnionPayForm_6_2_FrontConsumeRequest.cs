using Essensoft.AspNetCore.Payment.UnionPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.UnionPay.Request
{
    /// <summary>
    /// 消费接口
    /// </summary>
    public class UnionPayForm_6_2_FrontConsumeRequest : IUnionPayRequest<UnionPayForm_6_2_FrontConsumeResponse>
    {
        /// <summary>
        /// 订单发送时间
        /// 商户发送交易时间
        /// </summary>
        public string TxnTime { get; set; }

        /// <summary>
        /// 后台通知地址
        /// 后台返回商户结果时使用，如上送，则发送商户后台交易结果通知，如需通过专线通知，需要在通知地址前面加上前缀：专线的首字母加竖线ZX|
        /// </summary>
        public string BackUrl { get; set; }

        /// <summary>
        /// 交易币种
        /// 默认为156
        /// </summary>
        public string CurrencyCode { get; set; }

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
        /// 订单描述
        /// 移动支付上送
        /// </summary>
        public string OrderDesc { get; set; }

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
        /// 发卡机构代码
        /// 当账号类型为02-存折时需填写 2、在前台类交易时填写默认银行代码，支持直接跳转到网银。银行简码列表参考附录：C.1、C.2， 其中C.2银行列表仅支持借记卡
        /// </summary>
        public string IssInsNo { get; set; }

        /// <summary>
        /// 分期付款信息域
        /// </summary>
        public string InstalTransInfo { get; set; }

        /// <summary>
        /// 前台通知地址
        /// 前台返回商户结果时使用，前台类交易需上送
        /// </summary>
        public string FrontUrl { get; set; }

        /// <summary>
        /// 银行卡验证信息及身份信息
        /// </summary>
        public string CustomerInfo { get; set; }

        /// <summary>
        /// 有卡交易信息域
        /// </summary>
        public string CardTransData { get; set; }

        /// <summary>
        /// 预付卡通道
        /// 预付卡的专享支付页面
        /// </summary>
        public string AccountPayChannel { get; set; }

        /// <summary>
        /// 账号
        /// 1、后台类消费交易时上送全卡号或卡号后4位 
        /// 2、跨行收单且收单机构收集银行卡信息时上送
        /// 3、前台类交易可通过配置后返回，卡号可选上送
        /// </summary>
        public string AccNo { get; set; }

        /// <summary>
        /// 账号类型(卡介质)
        /// 后台类交易且卡号上送；
        /// 跨行收单且收单机构收集银行卡信息时上送
        /// 01：银行卡
        /// 02：存折
        /// 03：IC卡
        /// 默认取值：01
        /// 取值“03”表示以IC终端发起的IC卡交易，IC作为普通银行卡进行支付时，此域填写为“01”
        /// </summary>
        public string AccType { get; set; }

        /// <summary>
        /// 保留域
        /// </summary>
        public string Reserved { get; set; }

        /// <summary>
        /// 持卡人IP
        /// 前台交易，有IP防钓鱼要求的商户上送
        /// </summary>
        public string CustomerIp { get; set; }

        /// <summary>
        /// 订单接收超时时间
        /// 1、前台类消费交易时上送 2、认证支付2.0，后台交易时可选
        /// </summary>
        public string OrderTimeout { get; set; }

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
        /// 32位01字符串控制位，从左至右第四位取值为1时表示需要强制分期处理
        /// </summary>
        public string CtrlRule { get; set; }

        /// <summary>
        /// 默认支付方式
        /// 取值参考数据元说明
        /// </summary>
        public string DefaultPayType { get; set; }

        /// <summary>
        /// 请求方保留域
        /// 商户自定义保留域，交易应答时会原样返回
        /// </summary>
        public string ReqReserved { get; set; }

        /// <summary>
        /// 失败交易前台跳转地址
        /// 前台消费交易若商户上送此字段，则在支付失败时，页面跳转至商户该URL（不带交易信息，仅跳转）
        /// </summary>
        public string FrontFailUrl { get; set; }

        /// <summary>
        /// 支持支付方式
        /// 仅仅pc使用，使用哪种支付方式 由收单机构填写，取值为以下内容的一种或多种，通过逗号（，）分割。取值参考数据字典
        /// </summary>
        public string SupPayType { get; set; }

        /// <summary>
        /// 支付超时时间
        /// 超过此时间用户支付成功的交易，不通知商户，系统自动退款，大约5个工作日金额返还到用户账户
        /// </summary>
        public string PayTimeout { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        public string TermId { get; set; }

        /// <summary>
        /// 终端信息域
        /// 移动支付业务需要上送
        /// </summary>
        public string UserMac { get; set; }

        #region IUnionPayRequest
        private string version = string.Empty;
        private string txnType = "01";
        private string txnSubType = "01";
        private string bizType = "000201";
        private string channelType = "08";

        public string GetApiVersion()
        {
            return version;
        }

        public void SetApiVersion(string version)
        {
            this.version = version;
        }

        public string GetTxnType()
        {
            return txnType;
        }

        public void SetTxnType(string txnType)
        {
            this.txnType = txnType;
        }

        public string GetTxnSubType()
        {
            return txnSubType;
        }

        public void SetTxnSubType(string txnSubType)
        {
            this.txnSubType = txnSubType;
        }

        public string GetBizType()
        {
            return bizType;
        }

        public void SetBizType(string bizType)
        {
            this.bizType = bizType;
        }

        public string GetChannelType()
        {
            return channelType;
        }

        public void SetChannelType(string channelType)
        {
            this.channelType = channelType;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new UnionPayDictionary
            {
                { "txnTime", TxnTime },
                { "backUrl", BackUrl },
                { "currencyCode", CurrencyCode },
                { "txnAmt", TxnAmt },
                { "orderId", OrderId },
                { "orderDesc", OrderDesc },
                { "subMerId", SubMerId },
                { "subMerAbbr", SubMerAbbr },
                { "subMerName", SubMerName },
                { "issInsNo", IssInsNo },
                { "instalTransInfo", InstalTransInfo },
                { "frontUrl", FrontUrl },
                { "customerInfo", CustomerInfo },
                { "cardTransData", CardTransData },
                { "accountPayChannel", AccountPayChannel },
                { "accNo", AccNo },
                { "accType", AccType },
                { "reserved", Reserved },
                { "customerIp", CustomerIp },
                { "orderTimeout", OrderTimeout },
                { "accSplitData", AccSplitData },
                { "riskRateInfo", RiskRateInfo },
                { "ctrlRule", CtrlRule },
                { "defaultPayType", DefaultPayType },
                { "reqReserved", ReqReserved },
                { "frontFailUrl", FrontFailUrl },
                { "supPayType", SupPayType },
                { "payTimeout", PayTimeout },
                { "termId", TermId },
                { "userMac", UserMac },
            };
            return parameters;
        }

        public string GetRequestUrl(bool isTest)
        {
            return isTest ? "https://gateway.test.95516.com/gateway/api/frontTransReq.do" : "https://gateway.95516.com/gateway/api/frontTransReq.do";
        }

        #endregion
    }
}
