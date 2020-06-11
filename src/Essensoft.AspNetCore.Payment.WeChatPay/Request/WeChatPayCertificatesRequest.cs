using Essensoft.AspNetCore.Payment.WeChatPay.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 获取平台证书列表
    /// https://wechatpay-api.gitbook.io/wechatpay-api-v3/jie-kou-wen-dang/ping-tai-zheng-shu
    /// </summary>
    public class WeChatPayCertificatesRequest : IWeChatPayV3GetRequest<WeChatPayCertificatesResponse>
    {
        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/v3/certificates";
        }
    }
}
