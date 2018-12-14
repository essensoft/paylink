using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 拉取订单评价数据
    /// </summary>
    public class WeChatPayBatchQueryCommentRequest : WeChatPayCertificateRequest<WeChatPayBatchQueryCommentResponse>
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

        public override string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/billcommentsp/batchquerycomment";
        }

        protected override IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { ConstKey.Key_appid, AppId },
                { ConstKey.Key_begin_time, BeginTime },
                { ConstKey.Key_end_time, EndTime },
                { ConstKey.Key_offset, Offset },
                { ConstKey.Key_limit, Limit }
            };
            return parameters;
        }
        public override void CheckResponseSign(WeChatPayResponse response, WeChatPayOptions options)
        {
        }
        protected override void HandleParametersInOptions(WeChatPayDictionary sortedTxtParams, WeChatPayOptions options)
        {
            base.HandleParametersInOptions(sortedTxtParams, options);

            if (string.IsNullOrEmpty(sortedTxtParams.GetValue(ConstKey.Key_appid)))
            {
                sortedTxtParams.Add(ConstKey.Key_appid, options.AppId);
            }

            sortedTxtParams.Add(ConstKey.Key_mch_id, options.MchId);
        }
        #endregion
    }
}
