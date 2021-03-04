using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 微信支付分 - 查询用户授权记录（授权协议号）
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_3.shtml">微信支付分 - 查询用户授权记录（授权协议号）API</a> - 最新更新时间：2020.09.14</para>
    /// </remarks>
    public class WeChatPayScorePermissionsQueryForAuthCodeRequest : IWeChatPayGetRequest<WeChatPayScorePermissionsQueryForAuthCodeResponse>
    {
        private WeChatPayObject queryModel;

        /// <summary>
        /// 授权协议号
        /// </summary>
        /// <remarks>
        /// 预授权成功时的授权协议号
        /// <para>示例值：1234323JKHDFE1243252</para>
        /// </remarks>
        public string AuthorizationCode { get; set; }

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/payscore/permissions/authorization-code/{AuthorizationCode}";
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
