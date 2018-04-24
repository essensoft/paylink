using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.UnionPay.Response;

namespace Essensoft.AspNetCore.Payment.UnionPay.Request
{
    /// <summary>
    /// 交易状态查询接口
    /// </summary>
    public class UnionPayForm03_6_5_QueryRequest : IUnionPayRequest<UnionPayForm03_6_5_QueryResponse>
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
        /// 商户订单号	
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 收单机构代码	
        /// </summary>
        public string AcqInsCode { get; set; }

        /// <summary>
        /// 保留域	
        /// </summary>
        public string Reserved { get; set; }

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
                { "orderId", OrderId },
                { "acqInsCode", AcqInsCode },
                { "reserved", Reserved },
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
