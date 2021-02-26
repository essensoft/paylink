using Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.V3;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Request
{
    /// <summary>
    ///  微信支付分 - 查询用户授权记录（openid）
    ///  <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_5.shtml">查询用户授权记录（openid）API</a></para>
    /// </summary>
    public class WeChatPayScorePermissionsQueryForOpenIdRequest : IWeChatPayGetRequest<WeChatPayScorePermissionsQueryForOpenIdResponse>
    {
        private WeChatPayObject _queryModel;

        /// <summary>
        /// 用户标识。
        /// </summary>
        public string OpenId { get; set; }

        public WeChatPayObject GetQueryModel()
        {
            return _queryModel;
        }

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/payscore/permissions/openid/{OpenId}";
        }

        public void SetQueryModel(WeChatPayObject queryModel)
        {
            _queryModel = queryModel;
        }

    }
}
