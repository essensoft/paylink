using Essensoft.AspNetCore.Payment.UnionPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.UnionPay.Request
{
    /// <summary>
    /// 退货类（消费撤销类）
    /// </summary>
    public class UnionPayPurchaseUndoRequest : IUnionPayRequest<UnionPayPurchaseUndoResponse>
    {
        /// <summary>
        /// 订单发送时间
        /// </summary>
        public string TxnTime { get; set; }

        /// <summary>
        /// 后台通知地址
        /// 后台返回商户结果时使用，如上送，则发送商户后台交易结果通知，如需通过专线通知，需要在通知地址前面加上前缀：专线的首字母加竖线ZX|
        /// </summary>
        public string BackUrl { get; set; }

        /// <summary>
        /// 交易金额
        /// 与原始消费交易一致
        /// </summary>
        public string TxnAmt { get; set; }

        /// <summary>
        /// 商户订单号
        /// 消费撤销的订单号，由商户生成
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
        /// 接入机构代码
        /// 接入机构接入时必送
        /// </summary>
        public string AccInsCode { get; set; }

        /// <summary>
        /// 原交易查询流水号
        /// 1.原始消费交易的queryId； 2.origQryId、origOrderId + origTxnTime、 二者必送其一
        /// </summary>
        public string OrigQryId { get; set; }

        /// <summary>
        /// 原交易商户订单号
        /// 1.原始消费交易的orderId； 2.origQryId、origOrderId + origTxnTime二者必送其一
        /// </summary>
        public string OrigOrderId { get; set; }

        /// <summary>
        /// 原交易商户发送交易时间
        /// 1.原始消费交易的orderId； 2.origQryId、origOrderId + origTxnTime二者必送其一
        /// </summary>
        public string OrigTxnTime { get; set; }

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
        /// 原则是可以通过交易上送的终端编号准确定位商户每一个门店内每一台收银设备，建议按“门店编号+收银机编号”或“设备编号”组成8位终端编号在交易中上送。商户需将终端编号与门店对应关系反馈给银联。
        /// </summary>
        public string TermId { get; set; }

        #region IUnionPayRequest
        private string version = string.Empty;
        private string txnType = "31";
        private string txnSubType = "00";
        private string bizType = "000000";
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
                { "orderId", OrderId  },
                { "subMerId", SubMerId },
                { "subMerAbbr", SubMerAbbr },
                { "subMerName", SubMerName },
                { "accInsCode", AccInsCode },
                { "origQryId", OrigQryId },
                { "origOrderId", OrigOrderId },
                { "origTxnTime", OrigTxnTime },
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
