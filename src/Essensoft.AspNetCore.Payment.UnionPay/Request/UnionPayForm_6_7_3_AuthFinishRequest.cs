using Essensoft.AspNetCore.Payment.UnionPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.UnionPay.Request
{
    /// <summary>
    /// 预授权完成
    /// </summary>
    public class UnionPayForm_6_7_3_AuthFinishRequest : IUnionPayRequest<UnionPayForm_6_7_3_AuthFinishResponse>
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
        /// 交易金额
        /// 单位为分
        /// </summary>
        public string TxnAmt { get; set; }

        /// <summary>
        /// 商户订单号
        /// 预授权完成的订单号，由商户生成
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 原交易查询流水号
        /// 原始预授权交易的queryId
        /// </summary>
        public string OrigQryId { get; set; }

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
        /// 保留域
        /// </summary>
        public string Reserved { get; set; }

        /// <summary>
        /// 请求方保留域
        /// 商户自定义保留域，交易应答时会原样返回
        /// </summary>
        public string ReqReserved { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        public string TermId { get; set; }

        #region IUnionPayRequest
        private string version = string.Empty;
        private string txnType = "03";
        private string txnSubType = "00";
        private string bizType = "000201";
        private string channelType = "07";

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
                { "txnAmt", TxnAmt },
                { "orderId", OrderId },
                { "origQryId", OrigQryId },
                { "subMerId", SubMerId },
                { "subMerAbbr", SubMerAbbr },
                { "subMerName", SubMerName },
                { "reserved", Reserved },
                { "reqReserved", ReqReserved },
                { "termId", TermId },
            };
            return parameters;
        }

        public string GetRequestUrl(bool isTest)
        {
            return isTest ? "https://gateway.test.95516.com/gateway/api/backTransReq.do" : "https://gateway.95516.com/gateway/api/backTransReq.do";
        }

        #endregion
    }
}
