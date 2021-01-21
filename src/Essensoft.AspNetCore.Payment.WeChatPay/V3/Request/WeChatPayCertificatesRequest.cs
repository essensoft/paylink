using System;
using Essensoft.AspNetCore.Payment.WeChatPay.V3.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Request
{
    /// <summary>
    /// 获取平台证书列表
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay5_1.shtml
    /// </summary>
    public class WeChatPayCertificatesRequest : IWeChatPayGetRequest<WeChatPayCertificatesResponse>
    {
        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/v3/certificates";
        }

        public WeChatPayObject GetQueryModel()
        {
            throw new NotImplementedException();
        }

        public void SetQueryModel(WeChatPayObject queryModel)
        {
            throw new NotImplementedException();
        }

        public bool GetNeedCheckSign()
        {
            return false;
        }
    }
}
