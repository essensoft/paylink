using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 微信支付分 - 解除用户授权关系（openid）
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_6.shtml">微信支付分 - 解除用户授权关系（openid）API</a> - 最新更新时间：2020.07.20</para>
    /// </remarks>
    public class WeChatPayScorePermissionsTerminateForOpenIdRequest : IWeChatPayPostRequest<WeChatPayScorePermissionsTerminateForOpenIdResponse>
    {
        private WeChatPayObject bodyModel;

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
            return $"https://api.mch.weixin.qq.com/v3/payscore/permissions/openid/{OpenId}/terminate";
        }

        public WeChatPayObject GetBodyModel()
        {
            return bodyModel;
        }

        public void SetBodyModel(WeChatPayObject bodyModel)
        {
            this.bodyModel = bodyModel;
        }
    }
}
