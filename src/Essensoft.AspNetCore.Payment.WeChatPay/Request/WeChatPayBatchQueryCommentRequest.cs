using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 拉取订单评价数据
    /// </summary>
    public class WeChatPayBatchQueryCommentRequest : IWeChatPayCertificateRequest<WeChatPayBatchQueryCommentResponse>
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public string BeginTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// 位移
        /// </summary>
        public string Offset { get; set; }

        /// <summary>
        /// 条数
        /// </summary>
        public string Limit { get; set; }

        #region IWeChatPayCertificateRequest Members

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/billcommentsp/batchquerycomment";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { "appid", AppId },
                { "begin_time", BeginTime },
                { "end_time", EndTime },
                { "offset", Offset },
                { "limit", Limit }
            };
            return parameters;
        }

        public bool IsCheckResponseSign()
        {
            return false;
        }

        #endregion
    }
}
