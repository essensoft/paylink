using Essensoft.AspNetCore.Alipay.Domain;
using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Response;
using Essensoft.AspNetCore.Alipay.Utility;

namespace Essensoft.AspNetCore.Alipay.Request
{
    /// <summary>
    /// AOP API: alipay.open.mini.version.audit.apply
    /// </summary>
    public class AlipayOpenMiniVersionAuditApplyRequest : IAlipayUploadRequest<AlipayOpenMiniVersionAuditApplyResponse>
    {
        /// <summary>
        /// 小程序类目，格式为 第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目
        /// </summary>
        public string AppCategoryIds { get; set; }

        /// <summary>
        /// 小程序应用描述，20-200个字
        /// </summary>
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序应用英文名称
        /// </summary>
        public string AppEnglishName { get; set; }

        /// <summary>
        /// 小程序logo图标，图片格式必须为：png、jpeg、jpg，建议上传像素为180*180
        /// </summary>
        public FileItem AppLogo { get; set; }

        /// <summary>
        /// 小程序应用名称
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 小程序应用简介，一句话描述小程序功能
        /// </summary>
        public string AppSlogan { get; set; }

        /// <summary>
        /// 小程序版本号
        /// </summary>
        public string AppVersion { get; set; }

        /// <summary>
        /// 小程序第四张应用截图，不能超过4MB，图片格式只支持jpg，png
        /// </summary>
        public FileItem FifthScreenShot { get; set; }

        /// <summary>
        /// 小程序第一张应用截图，不能超过4MB，图片格式只支持jpg，png
        /// </summary>
        public FileItem FirstScreenShot { get; set; }

        /// <summary>
        /// 小程序第四张应用截图，不能超过4MB，图片格式只支持jpg，png
        /// </summary>
        public FileItem FourthScreenShot { get; set; }

        /// <summary>
        /// 小程序备注
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 小程序服务区域类型，GLOBLE-全球，CHINA-中国，LOCATION-指定区域
        /// </summary>
        public string RegionType { get; set; }

        /// <summary>
        /// 小程序第二张应用截图，不能超过4MB，图片格式只支持jpg，png
        /// </summary>
        public FileItem SecondScreenShot { get; set; }

        /// <summary>
        /// 小程序客服邮箱
        /// </summary>
        public string ServiceEmail { get; set; }

        /// <summary>
        /// 小程序客服电话
        /// </summary>
        public string ServicePhone { get; set; }

        /// <summary>
        /// 省市区信息，当区域类型为LOCATION时，不能为空，province_code不能为空，当填写city_code时，province_code不能为空，当填写area_code时，province_code和city_code不能为空
        /// </summary>
        public List<RegionInfo> ServiceRegionInfo { get; set; }

        /// <summary>
        /// 小程序第三张应用截图，不能超过4MB，图片格式只支持jpg，png
        /// </summary>
        public FileItem ThirdScreenShot { get; set; }

        /// <summary>
        /// 小程序版本描述
        /// </summary>
        public string VersionDesc { get; set; }

        #region IAlipayRequest Members
		private bool needEncrypt=false;
		private string apiVersion = "1.0";
		private string terminalType;
		private string terminalInfo;
        private string prodCode;
		private string notifyUrl;
        private string returnUrl;
		private AlipayObject bizModel;

    	 public void SetNeedEncrypt(bool needEncrypt){
             this.needEncrypt=needEncrypt;
        }

        public bool GetNeedEncrypt(){

            return needEncrypt;
        }

		public void SetNotifyUrl(string notifyUrl){
            this.notifyUrl = notifyUrl;
        }

        public string GetNotifyUrl(){
            return notifyUrl;
        }

        public void SetReturnUrl(string returnUrl){
            this.returnUrl = returnUrl;
        }

        public string GetReturnUrl(){
            return returnUrl;
        }

		public void SetTerminalType(string terminalType){
			this.terminalType=terminalType;
		}

    	public string GetTerminalType(){
    		return terminalType;
    	}

    	public void SetTerminalInfo(string terminalInfo){
    		this.terminalInfo=terminalInfo;
    	}

    	public string GetTerminalInfo(){
    		return terminalInfo;
    	}

        public void SetProdCode(string prodCode){
            this.prodCode=prodCode;
        }

        public string GetProdCode(){
            return prodCode;
        }

		public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return apiVersion;
        }

        public string GetApiName()
        {
            return "alipay.open.mini.version.audit.apply";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "app_category_ids", AppCategoryIds },
                { "app_desc", AppDesc },
                { "app_english_name", AppEnglishName },
                { "app_name", AppName },
                { "app_slogan", AppSlogan },
                { "app_version", AppVersion },
                { "memo", Memo },
                { "region_type", RegionType },
                { "service_email", ServiceEmail },
                { "service_phone", ServicePhone },
                { "service_region_info", ServiceRegionInfo },
                { "version_desc", VersionDesc }
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
                { "app_logo", AppLogo },
                { "fifth_screen_shot", FifthScreenShot },
                { "first_screen_shot", FirstScreenShot },
                { "fourth_screen_shot", FourthScreenShot },
                { "second_screen_shot", SecondScreenShot },
                { "third_screen_shot", ThirdScreenShot }
            };
            return parameters;
        }

        #endregion
    }
}
