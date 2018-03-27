using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.UnionPay.Response;

namespace Essensoft.AspNetCore.Payment.UnionPay.Request
{
    /// <summary>
    /// 文件传输类交易接口
    /// </summary>
    public class UnionPayForm_6_6_FileTransferRequest : IUnionPayRequest<UnionPayForm_6_6_FileTransferResponse>
    {
        /// <summary>
        /// 订单发送时间	
        /// </summary>
        public string TxnTime { get; set; }

        /// <summary>
        /// 清算日期	
        /// </summary>
        public string SettleDate { get; set; }

        /// <summary>
        /// 文件类型	
        /// 依据实际业务情况定义
        /// 参考7.1：商户索取的文件类型约定
        /// </summary>
        public string FileType { get; set; }

        /// <summary>
        /// 请求方保留域
        /// 商户自定义保留域，交易应答时会原样返回
        /// </summary>
        public string ReqReserved { get; set; }

        #region IUnionPayRequest
        private string version = string.Empty;
        private string txnType = "76";
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
                { "txnTime", TxnTime  },
                { "settleDate", SettleDate },
                { "fileType", FileType },
                { "reqReserved", ReqReserved },
            };
            return parameters;
        }

        public string GetRequestUrl(bool isTest)
        {
            return isTest ? "https://filedownload.test.95516.com/" : "https://filedownload.95516.com/";
        }

        #endregion
    }
}
