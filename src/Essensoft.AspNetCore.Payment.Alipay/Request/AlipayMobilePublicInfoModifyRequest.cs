using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.mobile.public.info.modify
    /// </summary>
    public class AlipayMobilePublicInfoModifyRequest : IAlipayRequest<AlipayMobilePublicInfoModifyResponse>
    {
        /// <summary>
        /// 服务窗名称，2-20个字之间；不得含有违反法律法规和公序良俗的相关信息；不得侵害他人名誉权、知识产权、商业秘密等合法权利；不得以太过广泛的、或产品、行业词组来命名，如：女装、皮革批发；不得以实名认证的媒体资质账号创建服务窗，或媒体相关名称命名服务窗，如：XX电视台、XX杂志等
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 授权运营书，企业商户若为被经营方授权，需上传加盖公章的扫描件，请使用照片上传接口上传图片获得image_url
        /// </summary>
        public string AuthPic { get; set; }

        /// <summary>
        /// 营业执照地址，建议尺寸 320 x 320px，支持.jpg .jpeg .png 格式，小于3M
        /// </summary>
        public string LicenseUrl { get; set; }

        /// <summary>
        /// 服务窗头像地址，建议尺寸 320 x 320px，支持.jpg .jpeg .png 格式，小于3M
        /// </summary>
        public string LogoUrl { get; set; }

        /// <summary>
        /// 服务窗欢迎语，200字以内，首次使用服务窗必须
        /// </summary>
        public string PublicGreeting { get; set; }

        /// <summary>
        /// 第一张门店照片地址，建议尺寸 320 x 320px，支持.jpg .jpeg .png 格式，小于3M
        /// </summary>
        public string ShopPic1 { get; set; }

        /// <summary>
        /// 第二张门店照片地址
        /// </summary>
        public string ShopPic2 { get; set; }

        /// <summary>
        /// 第三张门店照片地址
        /// </summary>
        public string ShopPic3 { get; set; }

        #region IAlipayRequest Members
        private bool needEncrypt = false;
        private string apiVersion = "1.0";
        private string terminalType;
        private string terminalInfo;
        private string prodCode;
        private string notifyUrl;
        private string returnUrl;
        private AlipayObject bizModel;

        public void SetNeedEncrypt(bool needEncrypt)
        {
            this.needEncrypt = needEncrypt;
        }

        public bool GetNeedEncrypt()
        {
            return needEncrypt;
        }

        public void SetNotifyUrl(string notifyUrl)
        {
            this.notifyUrl = notifyUrl;
        }

        public string GetNotifyUrl()
        {
            return notifyUrl;
        }

        public void SetReturnUrl(string returnUrl)
        {
            this.returnUrl = returnUrl;
        }

        public string GetReturnUrl()
        {
            return returnUrl;
        }

        public void SetTerminalType(string terminalType)
        {
            this.terminalType = terminalType;
        }

        public string GetTerminalType()
        {
            return terminalType;
        }

        public void SetTerminalInfo(string terminalInfo)
        {
            this.terminalInfo = terminalInfo;
        }

        public string GetTerminalInfo()
        {
            return terminalInfo;
        }

        public void SetProdCode(string prodCode)
        {
            this.prodCode = prodCode;
        }

        public string GetProdCode()
        {
            return prodCode;
        }

        public string GetApiName()
        {
            return "alipay.mobile.public.info.modify";
        }

        public void SetApiVersion(string apiVersion)
        {
            this.apiVersion = apiVersion;
        }

        public string GetApiVersion()
        {
            return apiVersion;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "app_name", AppName },
                { "auth_pic", AuthPic },
                { "license_url", LicenseUrl },
                { "logo_url", LogoUrl },
                { "public_greeting", PublicGreeting },
                { "shop_pic1", ShopPic1 },
                { "shop_pic2", ShopPic2 },
                { "shop_pic3", ShopPic3 }
            };
            return parameters;
        }

        public AlipayObject GetBizModel()
        {
            return bizModel;
        }

        public void SetBizModel(AlipayObject bizModel)
        {
            this.bizModel = bizModel;
        }

        #endregion
    }
}
