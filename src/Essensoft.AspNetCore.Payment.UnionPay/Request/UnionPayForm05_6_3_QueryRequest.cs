using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.UnionPay.Response;

namespace Essensoft.AspNetCore.Payment.UnionPay.Request
{
    /// <summary>
    /// 交易状态查询
    /// </summary>
    public class UnionPayForm05_6_3_QueryRequest : IUnionPayRequest<UnionPayForm05_6_3_QueryResponse>
    {
        /// <summary>
        /// 查询流水号	
        /// </summary>
        public string QueryId { get; set; }

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
        /// 接入机构代码	
        /// </summary>
        public string AccInsCode { get; set; }

        /// <summary>
        /// 商户订单号	
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 保留域	
        /// </summary>
        public string Reserved { get; set; }

        /// <summary>
        /// 控制规则	
        /// </summary>
        public string CtrlRule { get; set; }

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
                { "txnType", TxnType },
                { "txnSubType", TxnSubType },
                { "queryId", QueryId },
                { "txnTime", TxnTime },
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

        public bool HasEncryptCertId()
        {
            return false;
        }

        #endregion
    }
}
