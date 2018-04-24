using Essensoft.AspNetCore.Payment.UnionPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.UnionPay.Request
{
    /// <summary>
    /// 解除标记
    /// </summary>
    public class UnionPayForm03_6_4_Token_DeleteTokenRequest : IUnionPayRequest<UnionPayForm03_6_4_Token_DeleteTokenResponse>
    {
        /// <summary>
        /// 标记化支付信息域
        /// </summary>
        public string TokenPayData { get; set; }

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
        /// 渠道类型
        /// </summary>
        public string ChannelType { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 二级商户代码
        /// </summary>
        public string SubMerId { get; set; }

        /// <summary>
        /// 二级商户简称
        /// </summary>
        public string SubMerAbbr { get; set; }

        /// <summary>
        /// 二级商户名称
        /// </summary>
        public string SubMerName { get; set; }

        /// <summary>
        /// 保留域
        /// </summary>
        public string Reserved { get; set; }

        /// <summary>
        /// 请求方保留域
        /// </summary>
        public string ReqReserved { get; set; }

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
                { "tokenPayData", TokenPayData },
                { "bizType", BizType },
                { "txnTime", TxnTime },
                { "txnType", TxnType },
                { "txnSubType", TxnSubType },
                { "channelType", ChannelType },
                { "orderId", OrderId },
                { "subMerId", SubMerId },
                { "subMerAbbr", SubMerAbbr },
                { "subMerName", SubMerName },
                { "reserved", Reserved },
                { "reqReserved", ReqReserved },
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
