using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.UnionPay.Response;

namespace Essensoft.AspNetCore.Payment.UnionPay.Request
{
    /// <summary>
    /// 手机网页支付(V2.2) 交易状态查询接口
    /// </summary>
    public class UnionPayWapPayQueryRequest : IUnionPayRequest<UnionPayWapPayQueryResponse>
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
        /// 签名公钥证书	
        /// </summary>
        public string SignPubKeyCert { get; set; }

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
                { "signPubKeyCert", SignPubKeyCert },
                { "acqInsCode", AcqInsCode },
                { "reserved", Reserved }
            };
            return parameters;
        }

        public string GetRequestUrl(bool isTest)
        {
            return isTest ? "https://101.231.204.80:5000/gateway/api/backTransReq.do" : "https://gateway.95516.com/gateway/api/queryTrans.do";
        }

        public bool HasEncryptCertId()
        {
            return false;
        }

        #endregion
    }
}
