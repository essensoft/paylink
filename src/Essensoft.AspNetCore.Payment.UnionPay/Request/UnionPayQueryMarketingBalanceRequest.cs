using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.UnionPay.Response;

namespace Essensoft.AspNetCore.Payment.UnionPay.Request
{
    /// <summary>
    /// 营销活动余额查询
    /// </summary>
    public class UnionPayQueryMarketingBalanceRequest : IUnionPayRequest<UnionPayQueryMarketingBalanceResponse>
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
        /// 营销活动编号
        /// </summary>
        public string DiscountId { get; set; }

        /// <summary>
        /// 商户简称
        /// </summary>
        public string MerAbbr { get; set; }

        /// <summary>
        /// 商户类别
        /// </summary>
        public string MerCatCode { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        public string MerName { get; set; }

        /// <summary>
        /// 收单机构代码
        /// </summary>
        public string AcqInsCode { get; set; }

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
                { "discountId", DiscountId },
                { "merAbbr", MerAbbr },
                { "merCatCode", MerCatCode },
                { "merName", MerName },
                { "acqInsCode", AcqInsCode }
            };
            return parameters;
        }

        public string GetRequestUrl(bool isTest)
        {
            return isTest ? "https://gateway.test.95516.com/gateway/api/backTransReq.do" : "https://gateway.95516.com/gateway/api/backTransReq.do";
        }

        public bool HasEncryptCertId()
        {
            return false;
        }

        #endregion
    }
}
