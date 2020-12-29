using System;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;
using Essensoft.AspNetCore.Payment.Alipay.Utility;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.open.agent.mobilepay.sign
    /// </summary>
    public class AlipayOpenAgentMobilepaySignRequest : IAlipayUploadRequest<AlipayOpenAgentMobilepaySignResponse>
    {
        /// <summary>
        /// APP demo，格式为.apk；或者应用说明文档, 格式为.doc .docx .pdf格式
        /// </summary>
        public FileItem AppDemo { get; set; }

        /// <summary>
        /// 应用在哪些市场上架，枚举值为：苹果,应用宝,豌豆荚,其他
        /// </summary>
        public List<string> AppMarket { get; set; }

        /// <summary>
        /// 商户的APP应用名称
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 应用上架状态，枚举值为 已上架，未上架
        /// </summary>
        public string AppStatus { get; set; }

        /// <summary>
        /// 可以登录该应用的测试账户
        /// </summary>
        public string AppTestAccount { get; set; }

        /// <summary>
        /// 可以登录此应用的账户的密码。对应app_test_account的登录密码
        /// </summary>
        public string AppTestAccountPassword { get; set; }

        /// <summary>
        /// 应用类型，枚举值为：IOS，安卓
        /// </summary>
        public List<string> AppType { get; set; }

        /// <summary>
        /// 代商户操作事务编号，通过alipay.open.isv.agent.create接口进行创建。
        /// </summary>
        public string BatchNo { get; set; }

        /// <summary>
        /// 营业执照授权函图片，个体工商户如果使用总公司或其他公司的营业执照认证需上传该授权函图片，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem BusinessLicenseAuthPic { get; set; }

        /// <summary>
        /// 营业执照号码。
        /// </summary>
        public string BusinessLicenseNo { get; set; }

        /// <summary>
        /// 营业执照图片，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem BusinessLicensePic { get; set; }

        /// <summary>
        /// 营业期限
        /// </summary>
        public string DateLimitation { get; set; }

        /// <summary>
        /// 应用下载链接
        /// </summary>
        public string DownloadLink { get; set; }

        /// <summary>
        /// 应用首页截图，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem HomeScreenshot { get; set; }

        /// <summary>
        /// 应用内截图，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem InAppScreenshot { get; set; }

        /// <summary>
        /// 营业期限是否长期有效
        /// </summary>
        public Nullable<bool> LongTerm { get; set; }

        /// <summary>
        /// 所属MCCCode，详情可参考  <a href="https://doc.open.alipay.com/doc2/detail.htm?spm=a219a.7629140.0.0.59bgD2&treeId=222&articleId=105364&docType=1#s1  ">商家经营类目</a> 中的“经营类目编码”
        /// </summary>
        public string MccCode { get; set; }

        /// <summary>
        /// 应用内支付页截图，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem PayScreenshot { get; set; }

        /// <summary>
        /// 企业特殊资质图片，可参考  <a href="https://doc.open.alipay.com/doc2/detail.htm?spm=a219a.7629140.0.0.59bgD2&treeId=222&articleId=105364&docType=1#s1  ">商家经营类目</a> 中的“需要的特殊资质证书”，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
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
            return "alipay.open.agent.mobilepay.sign";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "app_market", AppMarket },
                { "app_name", AppName },
                { "app_status", AppStatus },
                { "app_test_account", AppTestAccount },
                { "app_test_account_password", AppTestAccountPassword },
                { "app_type", AppType },
                { "batch_no", BatchNo },
                { "business_license_no", BusinessLicenseNo },
                { "date_limitation", DateLimitation },
                { "download_link", DownloadLink },
                { "long_term", LongTerm },
                { "mcc_code", MccCode }
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

        #region IAlipayUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>
            {
                { "app_demo", AppDemo },
                { "business_license_auth_pic", BusinessLicenseAuthPic },
                { "business_license_pic", BusinessLicensePic },
                { "home_screenshot", HomeScreenshot },
                { "in_app_screenshot", InAppScreenshot },
                { "pay_screenshot", PayScreenshot },
                { "special_license_pic", SpecialLicensePic }
            };
            return parameters;
        }

        #endregion
    }
}
