using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 微信支付分 - 查询用户授权记录（openid）
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_5.shtml">微信支付分 - 查询用户授权记录（openid）API</a> - 最新更新时间：2020.09.14</para>
    /// </remarks>
    public class WeChatPayScorePermissionsQueryForOpenIdRequest : IWeChatPayGetRequest<WeChatPayScorePermissionsQueryForOpenIdResponse>
    {
        private WeChatPayObject queryModel;

        /// <summary>
        /// 用户标识
        /// </summary>
        /// <remarks>
        /// 微信用户在商户对应appid下的唯一标识 
        /// <para>示例值：oUpF8uMuAJO_M2pxb1Q9zNjWeS6o</para>
        /// </remarks>
        public string OpenId { get; set; }

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/payscore/permissions/openid/{OpenId}";
        }

        public WeChatPayObject GetQueryModel()
        {
            return queryModel;
        }

        public void SetQueryModel(WeChatPayObject queryModel)
        {
            this.queryModel = queryModel;
        }
    }
}
