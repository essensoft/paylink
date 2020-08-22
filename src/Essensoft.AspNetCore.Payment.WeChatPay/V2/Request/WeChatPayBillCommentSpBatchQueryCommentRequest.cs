using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.V2.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Request
{
    /// <summary>
    /// 拉取订单评价数据
    /// </summary>
    public class WeChatPayBillCommentSpBatchQueryCommentRequest : IWeChatPayCertRequest<WeChatPayBillCommentSpBatchQueryCommentResponse>
    {
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
        public uint Offset { get; set; }

        /// <summary>
        /// 条数
        /// </summary>
        public uint Limit { get; set; }

        #region IWeChatPayCertificateRequest Members

        private string requestUrl = "https://api.mch.weixin.qq.com/billcommentsp/batchquerycomment";

        public string GetRequestUrl()
        {
            return requestUrl;
        }

        public void SetRequestUrl(string url)
        {
            requestUrl = url;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { "begin_time", BeginTime },
                { "end_time", EndTime },
                { "offset", Offset },
                { "limit", Limit }
            };
            return parameters;
        }

        public void PrimaryHandler(WeChatPayOptions options, WeChatPaySignType signType, WeChatPayDictionary sortedTxtParams)
        {
            sortedTxtParams.Add(WeChatPayConsts.nonce_str, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.appid, options.AppId);
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);

            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key, signType));
        }

        public bool GetNeedCheckSign()
        {
            return false;
        }

        #endregion
    }
}
