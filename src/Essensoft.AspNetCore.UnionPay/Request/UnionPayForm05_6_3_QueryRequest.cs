using System.Collections.Generic;
using Essensoft.AspNetCore.UnionPay.Response;

namespace Essensoft.AspNetCore.UnionPay.Request
{
    /// <summary>
    /// 交易状态查询
    /// </summary>
    public class UnionPayForm05_6_3_QueryRequest : IUnionPayRequest<UnionPayForm05_6_3_QueryResponse>
    {
        /// <summary>
        /// 查询流水号	
        /// 交易子类为02流水号查询时必填
        /// </summary>
        public string QueryId { get; set; }

        /// <summary>
        /// 订单发送时间	
        /// 同被查询交易 交易子类为00时必填
        /// </summary>
        public string TxnTime { get; set; }

        /// <summary>
        /// 接入机构代码	
        /// 接入机构接入时必送
        /// </summary>
        public string AccInsCode { get; set; }

        /// <summary>
        /// 商户订单号	
        /// 同被查询交易 交易子类为00时必填
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 保留域	
        /// </summary>
        public string Reserved { get; set; }

        /// <summary>
        /// 控制规则	
        /// 32位01字符串控制位，从左至右第二位取值为1时表示小微商户
        /// </summary>
        public string CtrlRule { get; set; }

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
                { "queryId", QueryId },
                { "txnTime", TxnTime  },
                { "accInsCode", AccInsCode },
                { "orderId", OrderId },
                { "reserved", Reserved },
                { "ctrlRule", CtrlRule },
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
