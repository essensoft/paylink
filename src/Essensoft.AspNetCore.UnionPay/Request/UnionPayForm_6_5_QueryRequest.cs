using System.Collections.Generic;
using Essensoft.AspNetCore.UnionPay.Response;

namespace Essensoft.AspNetCore.UnionPay.Request
{
    /// <summary>
    /// 交易状态查询
    /// </summary>
    public class UnionPayForm_6_5_QueryRequest : IUnionPayRequest<UnionPayForm_6_5_QueryResponse>
    {
        /// <summary>
        /// 订单发送时间	
        /// </summary>
        public string TxnTime { get; set; }

        /// <summary>
        /// 商户订单号	
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 保留域	
        /// </summary>
        public string Reserved { get; set; }

        #region IUnionPayRequest
        private string version = string.Empty;
        private string txnType = "00";
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
                { "txnTime", TxnTime  },
                { "orderId", OrderId },
                { "reserved", Reserved },
            };
            return parameters;
        }

        public string GetRequestUrl(bool isTest)
        {
            return isTest ? "https://gateway.test.95516.com/gateway/api/queryTrans.do" : "https://gateway.95516.com/gateway/api/queryTrans.do";
        }

        #endregion
    }
}
