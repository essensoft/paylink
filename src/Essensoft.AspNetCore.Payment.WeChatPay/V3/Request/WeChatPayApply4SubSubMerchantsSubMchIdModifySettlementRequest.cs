using Essensoft.AspNetCore.Payment.WeChatPay.V3.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Request
{
    /// <summary>
    /// 商户进件 - 修改结算帐号API（普通服务商）
    /// 最新更新时间：最新更新时间：2019.09.09
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/tool/applyment4sub/chapter3_3.shtml
    /// </summary>
    public class WeChatPayApply4SubSubMerchantsSubMchIdModifySettlementRequest : IWeChatPayPrivacyPostRequest<WeChatPayApply4SubSubMerchantsSubMchIdModifySettlementResponse>
    {
        private WeChatPayObject bodyModel;

        /// <summary>
        /// 特约商户号
        /// 请填写本服务商负责进件的特约商户号。
        /// 特殊规则：长度最小8个字节。
        /// 示例值：1511101111
        /// </summary>
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
