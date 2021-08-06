using System;
using System.Collections.Generic;
using Essensoft.Paylink.Alipay.Domain;
using Essensoft.Paylink.Alipay.Response;
using Essensoft.Paylink.Alipay.Utility;

namespace Essensoft.Paylink.Alipay.Request
{
    /// <summary>
    /// alipay.open.agent.facetoface.sign
    /// </summary>
    public class AlipayOpenAgentFacetofaceSignRequest : IAlipayUploadRequest<AlipayOpenAgentFacetofaceSignResponse>
    {
        /// <summary>
        /// 代商户操作事务编号，通过https://opendocs.alipay.com/apis/api_50/alipay.open.agent.create (开启代商户签约、创建应用事务)接口进行事务创建后获取。
        /// </summary>
        public string BatchNo { get; set; }

        /// <summary>
        /// 营业执照授权函图片，个体工商户如果使用总公司或其他公司的营业执照认证需上传该授权函图片，最小5KB，最大5M（暂不限制图片宽高），图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem BusinessLicenseAuthPic { get; set; }

        /// <summary>
        /// 营业执照法人手机号码
        /// </summary>
        public string BusinessLicenseMobile { get; set; }

        /// <summary>
        /// 营业执照号码
        /// </summary>
        public string BusinessLicenseNo { get; set; }

        /// <summary>
        /// 营业执照图片。被代创建商户运营主体为个人账户必填，企业账户无需填写，最小5KB，最大5M（暂不限制图片宽高），图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem BusinessLicensePic { get; set; }

        /// <summary>
        /// 营业期限
        /// </summary>
        public string DateLimitation { get; set; }

        /// <summary>
        /// 营业期限是否长期有效
        /// </summary>
        public Nullable<bool> LongTerm { get; set; }

        /// <summary>
        /// 商家经营类目编码。详情可参考 <a href="https://opendocs.alipay.com/open/01n22g#%E5%95%86%E5%AE%B6%E7%BB%8F%E8%90%A5%E7%B1%BB%E7%9B%AE">商家经营类目</a> 中的“二级类目code”。
        /// </summary>
        public string MccCode { get; set; }

        /// <summary>
        /// 服务费率（%），0.38~0.6 之间（小数点后两位，可取0.38%及0.6%）。 当签约且授权标识 sign_and_auth=true 时，该费率信息必填。
        /// </summary>
        public string Rate { get; set; }

        /// <summary>
        /// 店铺地址
        /// </summary>
        public SignAddressInfo ShopAddress { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺内景图片，最小5KB，最大5M（暂不限制图片宽高），图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem ShopScenePic { get; set; }

        /// <summary>
        /// 店铺门头照图片，最小5KB，最大5M（暂不限制图片宽高），图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem ShopSignBoardPic { get; set; }

        /// <summary>
        /// 签约且授权标识，默认为false，只进行签约操作； 如果设置为true，则表示签约成功后，会自动进行应用授权操作。
        /// </summary>
        public Nullable<bool> SignAndAuth { get; set; }

        /// <summary>
        /// 企业特殊资质图片，当mcc_code为需要特殊资质类目时必填。可参考 <a href="https://opendocs.alipay.com/open/01n22g#%E5%95%86%E5%AE%B6%E7%BB%8F%E8%90%A5%E7%B1%BB%E7%9B%AE">商家经营类目</a> 中的“所需资质”，最小5KB ，最大5M（暂不限制图片宽高），图片格式必须为：png、bmp、gif、jpg、jpeg
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
            return "alipay.open.agent.facetoface.sign";
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
                { "batch_no", BatchNo },
                { "business_license_mobile", BusinessLicenseMobile },
                { "business_license_no", BusinessLicenseNo },
                { "date_limitation", DateLimitation },
                { "long_term", LongTerm },
                { "mcc_code", MccCode },
                { "rate", Rate },
                { "shop_address", ShopAddress },
                { "shop_name", ShopName },
                { "sign_and_auth", SignAndAuth }
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
                { "business_license_auth_pic", BusinessLicenseAuthPic },
                { "business_license_pic", BusinessLicensePic },
                { "shop_scene_pic", ShopScenePic },
                { "shop_sign_board_pic", ShopSignBoardPic },
                { "special_license_pic", SpecialLicensePic }
            };
            return parameters;
        }

        #endregion
    }
}
