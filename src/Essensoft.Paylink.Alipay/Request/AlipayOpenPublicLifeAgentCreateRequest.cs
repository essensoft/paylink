using System.Collections.Generic;
using Essensoft.Paylink.Alipay.Response;
using Essensoft.Paylink.Alipay.Utility;

namespace Essensoft.Paylink.Alipay.Request
{
    /// <summary>
    /// alipay.open.public.life.agent.create
    /// </summary>
    public class AlipayOpenPublicLifeAgentCreateRequest : IAlipayUploadRequest<AlipayOpenPublicLifeAgentCreateResponse>
    {
        /// <summary>
        /// 服务商代开通生活号的商户支付宝账号或商户支付宝账号 pid（2088开头16位长度的字符串）。 注意：账号需通过 <a href="https://opendocs.alipay.com/open/200/qyzfbsmrz">实名认证</a>。
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 生活号背景图片
        /// </summary>
        public FileItem BackgroundPic { get; set; }

        /// <summary>
        /// 营业执照授权函图片，个体工商户如果使用总公司或其他公司的营业执照认证需上传该授权函图片
        /// </summary>
        public FileItem BusinessLicenseAuthPic { get; set; }

        /// <summary>
        /// 营业执照号码。被代创建商户运营主体为个人账户必填，企业账户无需填写
        /// </summary>
        public string BusinessLicenseNo { get; set; }

        /// <summary>
        /// 营业执照图片。被代创建商户运营主体为个人账户必填，企业账户无需填写
        /// </summary>
        public FileItem BusinessLicensePic { get; set; }

        /// <summary>
        /// 联系人邮箱
        /// </summary>
        public string ContactEmail { get; set; }

        /// <summary>
        /// 联系人手机号
        /// </summary>
        public string ContactMobile { get; set; }

        /// <summary>
        /// 联系人名称
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// 生活号头像
        /// </summary>
        public FileItem LogoPic { get; set; }

        /// <summary>
        /// 所属MCCCode，详情可参考<a href="https://opendocs.alipay.com/open/01n22g#%E5%95%86%E5%AE%B6%E7%BB%8F%E8%90%A5%E7%B1%BB%E7%9B%AE">商家经营类目</a>中的“类目code”。
        /// </summary>
        public string MccCode { get; set; }

        /// <summary>
        /// 外部入驻申请单据号，由开发者自行生成，并需保证在开发者端不重复。 注意：如果代创建申请被驳回，需更换新的申请号，原申请号不能再次使用。
        /// </summary>
        public string OutBizNo { get; set; }

        /// <summary>
        /// 自有知识产权证书图片
        /// </summary>
        public FileItem OwnIntellectualPic { get; set; }

        /// <summary>
        /// 生活号简介
        /// </summary>
        public string PublicDesc { get; set; }

        /// <summary>
        /// 生活号名称
        /// </summary>
        public string PublicName { get; set; }

        /// <summary>
        /// 店铺内景图片，被代创建商户运营主体为个人账户必填，企业账户选填
        /// </summary>
        public FileItem ShopScenePic { get; set; }

        /// <summary>
        /// 店铺门头照图片，被代创建商户运营主体为个人账户必填，企业账户选填
        /// </summary>
        public FileItem ShopSignBoardPic { get; set; }

        /// <summary>
        /// 企业特殊资质图片，可参考<a href="https://opendocs.alipay.com/open/01n22g#%E5%95%86%E5%AE%B6%E7%BB%8F%E8%90%A5%E7%B1%BB%E7%9B%AE">商家经营类目</a>中的 “所需资质”。
        /// </summary>
        public FileItem SpecialLicensePic { get; set; }

        #region IAlipayRequest Members

        private bool needEncrypt = false;
        private string apiVersion = "1.0";
        private string terminalType;
        private string terminalInfo;
        private string prodCode;
        private string notifyUrl;
        private string returnUrl;
        private AlipayObject bizModel;
        private Dictionary<string, string> udfParams; //add user-defined text parameters

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

        public void SetApiVersion(string apiVersion)
        {
            this.apiVersion = apiVersion;
        }

        public string GetApiVersion()
        {
            return apiVersion;
        }

        public string GetApiName()
        {
            return "alipay.open.public.life.agent.create";
        }

        public void PutOtherTextParam(string key, string value)
        {
            if (udfParams == null)
            {
                udfParams = new Dictionary<string, string>();
            }
            udfParams.Add(key, value);
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "account", Account },
                { "business_license_no", BusinessLicenseNo },
                { "contact_email", ContactEmail },
                { "contact_mobile", ContactMobile },
                { "contact_name", ContactName },
                { "mcc_code", MccCode },
                { "out_biz_no", OutBizNo },
                { "public_desc", PublicDesc },
                { "public_name", PublicName }
            };
            if (udfParams != null)
            {
                parameters.AddAll(udfParams);
            }
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

        #region IAlipayUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            var parameters = new Dictionary<string, FileItem>
            {
                { "background_pic", BackgroundPic },
                { "business_license_auth_pic", BusinessLicenseAuthPic },
                { "business_license_pic", BusinessLicensePic },
                { "logo_pic", LogoPic },
                { "own_intellectual_pic", OwnIntellectualPic },
                { "shop_scene_pic", ShopScenePic },
                { "shop_sign_board_pic", ShopSignBoardPic },
                { "special_license_pic", SpecialLicensePic }
            };
            return parameters;
        }

        #endregion
    }
}
