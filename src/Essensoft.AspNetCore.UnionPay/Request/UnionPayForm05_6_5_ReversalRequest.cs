using System.Collections.Generic;
using Essensoft.AspNetCore.UnionPay.Response;

namespace Essensoft.AspNetCore.UnionPay.Request
{
    /// <summary>
    /// 冲正
    /// </summary>
    public class UnionPayForm05_6_5_ReversalRequest : IUnionPayRequest<UnionPayForm05_6_5_ReversalResponse>
    {
        /// <summary>
        /// 订单发送时间
        /// 商户发送交易时间
        /// </summary>
        public string TxnTime { get; set; }

        /// <summary>
        /// 商户订单号
        /// 同原消费交易
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
        private string txnType = "99";
        private string txnSubType = "01";
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
                { "orderId", OrderId },
                { "subMerId", SubMerId },
                { "subMerAbbr", SubMerAbbr },
                { "subMerName", SubMerName },
                { "accInsCode", AccInsCode },
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
