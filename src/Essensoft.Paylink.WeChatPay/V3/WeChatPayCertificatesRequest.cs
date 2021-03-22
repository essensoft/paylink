using System;

namespace Essensoft.Paylink.WeChatPay.V3
{
    /// <summary>
    /// 获取平台证书列表
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay5_1.shtml">获取平台证书列表</a></para>
    /// </remarks>
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

        public bool GetNeedQueryModel()
        {
            return false;
        }
    }
}
