using System;
using System.Collections.Generic;
using System.Text;
using Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.V3;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Request
{
    /// <summary>
    ///  微信支付分 - 查询用户授权记录（授权协议号）
    ///  <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_3.shtml">查询用户授权记录（授权协议号）API</a></para>
    /// </summary>
    public class WeChatPayScorePermissionsQueryForAuthCodeRequest : IWeChatPayGetRequest<WeChatPayScorePermissionsQueryForAuthCodeResponse>
    {
        private WeChatPayObject _queryModel;

        /// <summary>
        /// 预授权成功时的授权协议号。
        /// </summary>
        public string AuthorizationCode { get; set; }

        public WeChatPayObject GetQueryModel()
        {
            return _queryModel;
        }

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/payscore/permissions/authorization-code/{AuthorizationCode}";
        }

        public void SetQueryModel(WeChatPayObject queryModel)
        {
            _queryModel = queryModel;
        }
    }
}
