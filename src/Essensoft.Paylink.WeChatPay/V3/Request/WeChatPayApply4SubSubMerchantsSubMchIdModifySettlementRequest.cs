using Essensoft.Paylink.WeChatPay.V3.Response;

namespace Essensoft.Paylink.WeChatPay.V3.Request
{
    /// <summary>
    /// 特约商户进件 - 修改结算帐号
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter11_1_3.shtml">特约商户进件 - 修改结算帐号API</a> - 最新更新时间：2019.09.09</para>
    /// </remarks>
    public class WeChatPayApply4SubSubMerchantsSubMchIdModifySettlementRequest : IWeChatPayPrivacyPostRequest<WeChatPayApply4SubSubMerchantsSubMchIdModifySettlementResponse>
    {
        private WeChatPayObject bodyModel;

        /// <summary>
        /// 特约商户号
        /// </summary>
        /// <remarks>
        /// 请填写本服务商负责进件的特约商户号。
        /// 特殊规则：长度最小8个字节。
        /// <para>示例值：1511101111</para>
        /// </remarks>
        public string SubMchId { get; set; }

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/apply4sub/sub_merchants/{SubMchId}/modify-settlement";
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
