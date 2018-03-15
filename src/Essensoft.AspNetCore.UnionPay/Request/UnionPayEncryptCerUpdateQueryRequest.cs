using Essensoft.AspNetCore.UnionPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.UnionPay.Request
{
    /// <summary>
    /// 银联加密公钥更新查询接口
    /// </summary>
    public class UnionPayEncryptCerUpdateQueryRequest : IUnionPayRequest<UnionPayEncryptCerUpdateQueryResponse>
    {
        /// <summary>
        /// 订单发送时间
        /// </summary>
        public string TxnTime { get; set; }

        /// <summary>
        /// 商户订单号
        /// 退货交易的订单号，由商户生成
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 证书类型
        /// 01：敏感信息加密公钥
        /// </summary>
        public string CertType { get; set; }

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
        /// 商户简称
        /// 商户类型为平台类商户接入时必须上送
        /// </summary>
        public string MerAbbr { get; set; }

        /// <summary>
        /// 商户类别
        /// 商户类型为平台类商户接入时必须上送
        /// </summary>
        public string MerCatCode { get; set; }

        /// <summary>
        /// 商户名称
        /// 商户类型为平台类商户接入时必须上送
        /// </summary>
        public string MerName { get; set; }

        /// <summary>
        /// 收单机构代码
        /// 商户类型为平台类商户接入时必须上送
        /// </summary>
        public string AcqInsCode { get; set; }

        /// <summary>
        /// 保留域
        /// </summary>
        public string Reserved { get; set; }

        /// <summary>
        /// 请求方保留域
        /// 商户自定义保留域，交易应答时会原样返回
        /// </summary>
        public string ReqReserved { get; set; }

        #region IUnionPayRequest
        private string version = string.Empty;
        private string txnType = "95";
        private string txnSubType = "00";
        private string bizType = "000000";
        private string channelType = "08";

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
                { "orderId", OrderId  },
                { "subMerId", SubMerId },
                { "subMerAbbr", SubMerAbbr },
                { "subMerName", SubMerName },
                { "merAbbr", MerAbbr },
                { "merCatCode", MerCatCode },
                { "merName", MerName },
                { "reserved", Reserved },
                { "acqInsCode", AcqInsCode },
                { "reqReserved", ReqReserved },
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
