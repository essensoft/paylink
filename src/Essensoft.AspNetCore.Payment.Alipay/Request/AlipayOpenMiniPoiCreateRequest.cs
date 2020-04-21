using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;
using Essensoft.AspNetCore.Payment.Alipay.Utility;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.open.mini.poi.create
    /// </summary>
    public class AlipayOpenMiniPoiCreateRequest : IAlipayUploadRequest<AlipayOpenMiniPoiCreateResponse>
    {
        /// <summary>
        /// 经营资质号
        /// </summary>
        public string Certificate { get; set; }

        /// <summary>
        /// 营业执照，同主体可以不传,最多5张，单张不能超过2M
        /// </summary>
        public FileItem FifthRelatedMaterial { get; set; }

        /// <summary>
        /// 营业执照，同主体可以不传,最多5张，单张不能超过2M
        /// </summary>
        public FileItem FirstRelatedMaterial { get; set; }

        /// <summary>
        /// 营业执照，同主体可以不传,最多5张，单张不能超过2M
        /// </summary>
        public FileItem FourthRelatedMaterial { get; set; }

        /// <summary>
        /// POI的具体地址信息，建议按照：省市区县街道门牌号的顺序精确描述地址
        /// </summary>
        public string PoiAddress { get; set; }

        /// <summary>
        /// 相关主体名称，需要与经营材料上的名称保持一致.若地点的相关资质与小程序账号主体一致，则不用填写
        /// </summary>
        public string RelatedName { get; set; }

        /// <summary>
        /// 营业执照，同主体可以不传,最多5张，单张不能超过2M
        /// </summary>
        public FileItem SecondRelatedMaterial { get; set; }

        /// <summary>
        /// 营业执照，同主体可以不传,最多5张，单张不能超过2M
        /// </summary>
        public FileItem ThirdRelatedMaterial { get; set; }

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
            return "alipay.open.mini.poi.create";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "certificate", Certificate },
                { "poi_address", PoiAddress },
                { "related_name", RelatedName }
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
                { "fifth_related_material", FifthRelatedMaterial },
                { "first_related_material", FirstRelatedMaterial },
                { "fourth_related_material", FourthRelatedMaterial },
                { "second_related_material", SecondRelatedMaterial },
                { "third_related_material", ThirdRelatedMaterial }
            };
            return parameters;
        }

        #endregion
    }
}
