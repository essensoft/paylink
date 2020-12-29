using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Response;

namespace Essensoft.AspNetCore.Payment.Alipay.Request
{
    /// <summary>
    /// alipay.security.risk.detect
    /// </summary>
    public class AlipaySecurityRiskDetectRequest : IAlipayRequest<AlipaySecurityRiskDetectResponse>
    {
        /// <summary>
        /// 买家账户编号
        /// </summary>
        public string BuyerAccountNo { get; set; }

        /// <summary>
        /// 买家绑定银行卡号
        /// </summary>
        public string BuyerBindBankcard { get; set; }

        /// <summary>
        /// 买家绑定银行卡的卡类型
        /// </summary>
        public string BuyerBindBankcardType { get; set; }

        /// <summary>
        /// 买家绑定手机号
        /// </summary>
        public string BuyerBindMobile { get; set; }

        /// <summary>
        /// 买家账户在商家的等级，范围：VIP（高级买家）, NORMAL(普通买家）。为空默认NORMAL
        /// </summary>
        public string BuyerGrade { get; set; }

        /// <summary>
        /// 买家证件号码
        /// </summary>
        public string BuyerIdentityNo { get; set; }

        /// <summary>
        /// 买家证件类型
        /// </summary>
        public string BuyerIdentityType { get; set; }

        /// <summary>
        /// 买家真实姓名
        /// </summary>
        public string BuyerRealName { get; set; }

        /// <summary>
        /// 买家注册时间
        /// </summary>
        public string BuyerRegDate { get; set; }

        /// <summary>
        /// 买家注册时留的Email
        /// </summary>
        public string BuyerRegEmail { get; set; }

        /// <summary>
        /// 买家注册手机号
        /// </summary>
        public string BuyerRegMobile { get; set; }

        /// <summary>
        /// 买家业务处理时使用的银行卡号
        /// </summary>
        public string BuyerSceneBankcard { get; set; }

        /// <summary>
        /// 买家业务处理时使用的银行卡类型
        /// </summary>
        public string BuyerSceneBankcardType { get; set; }

        /// <summary>
        /// 买家业务处理时使用的邮箱
        /// </summary>
        public string BuyerSceneEmail { get; set; }

        /// <summary>
        /// 买家业务处理时使用的手机号
        /// </summary>
        public string BuyerSceneMobile { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// 客户端的基带版本
        /// </summary>
        public string EnvClientBaseBand { get; set; }

        /// <summary>
        /// 客户端连接的基站信息,格式为：CELLID^LAC
        /// </summary>
        public string EnvClientBaseStation { get; set; }

        /// <summary>
        /// 客户端的经纬度坐标,格式为：精度^维度
        /// </summary>
        public string EnvClientCoordinates { get; set; }

        /// <summary>
        /// 操作的客户端的imei
        /// </summary>
        public string EnvClientImei { get; set; }

        /// <summary>
        /// 操作的客户端IMSI识别码
        /// </summary>
        public string EnvClientImsi { get; set; }

        /// <summary>
        /// IOS设备的UDID
        /// </summary>
        public string EnvClientIosUdid { get; set; }

        /// <summary>
        /// 操作的客户端ip
        /// </summary>
        public string EnvClientIp { get; set; }

        /// <summary>
        /// 操作的客户端mac
        /// </summary>
        public string EnvClientMac { get; set; }

        /// <summary>
        /// 操作的客户端分辨率，格式为：水平像素^垂直像素；如：800^600
        /// </summary>
        public string EnvClientScreen { get; set; }

        /// <summary>
        /// 客户端设备的统一识别码UUID
        /// </summary>
        public string EnvClientUuid { get; set; }

        /// <summary>
        /// 订单产品数量，购买产品的数量（不可为小数）
        /// </summary>
        public string ItemQuantity { get; set; }

        /// <summary>
        /// 订单产品单价，取值范围为[0.01,100000000.00]，精确到小数点后两位。 curren...
        /// </summary>
        public string ItemUnitPrice { get; set; }

        /// <summary>
        /// JS SDK生成的 tokenID
        /// </summary>
        public string JsTokenId { get; set; }

        /// <summary>
        /// 订单总金额，取值范围为[0.01,100000000.00]，精确到小数点后两位。
        /// </summary>
        public string OrderAmount { get; set; }

        /// <summary>
        /// 订单商品所在类目
        /// </summary>
        public string OrderCategory { get; set; }

        /// <summary>
        /// 订单下单时间
        /// </summary>
        public string OrderCredateTime { get; set; }

        /// <summary>
        /// 订单商品所在城市
        /// </summary>
        public string OrderItemCity { get; set; }

        /// <summary>
        /// 订单产品名称
        /// </summary>
        public string OrderItemName { get; set; }

        /// <summary>
        /// 商户订单唯一标识号
        /// </summary>
        public string OrderNo { get; set; }

        /// <summary>
        /// 签约的支付宝账号对应的支付宝唯一用户号
        /// </summary>
        public string PartnerId { get; set; }

        /// <summary>
        /// 订单收货人地址
        /// </summary>
        public string ReceiverAddress { get; set; }

        /// <summary>
        /// 订单收货人地址城市
        /// </summary>
        public string ReceiverCity { get; set; }

        /// <summary>
        /// 订单收货人地址所在区
        /// </summary>
        public string ReceiverDistrict { get; set; }

        /// <summary>
        /// 订单收货人邮箱
        /// </summary>
        public string ReceiverEmail { get; set; }

        /// <summary>
        /// 订单收货人手机
        /// </summary>
        public string ReceiverMobile { get; set; }

        /// <summary>
        /// 订单收货人姓名
        /// </summary>
        public string ReceiverName { get; set; }

        /// <summary>
        /// 订单收货人地址省份
        /// </summary>
        public string ReceiverState { get; set; }

        /// <summary>
        /// 订单收货人地址邮编
        /// </summary>
        public string ReceiverZip { get; set; }

        /// <summary>
        /// 场景编码
        /// </summary>
        public string SceneCode { get; set; }

        /// <summary>
        /// 卖家账户编号
        /// </summary>
        public string SellerAccountNo { get; set; }

        /// <summary>
        /// 卖家绑定银行卡号
        /// </summary>
        public string SellerBindBankcard { get; set; }

        /// <summary>
        /// 卖家绑定的银行卡的卡类型
        /// </summary>
        public string SellerBindBankcardType { get; set; }

        /// <summary>
        /// 卖家绑定手机号
        /// </summary>
        public string SellerBindMobile { get; set; }

        /// <summary>
        /// 卖家证件号码
        /// </summary>
        public string SellerIdentityNo { get; set; }

        /// <summary>
        /// 卖家证件类型
        /// </summary>
        public string SellerIdentityType { get; set; }

        /// <summary>
        /// 卖家真实姓名
        /// </summary>
        public string SellerRealName { get; set; }

        /// <summary>
        /// 卖家注册时间,格式为：yyyy-MM-dd。
        /// </summary>
        public string SellerRegDate { get; set; }

        /// <summary>
        /// 卖家注册Email
        /// </summary>
        public string SellerRegEmail { get; set; }

        /// <summary>
        /// 卖家注册手机号
        /// </summary>
        public string SellerRegMoile { get; set; }

        /// <summary>
        /// 订单物流方式
        /// </summary>
        public string TransportType { get; set; }

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
            return "alipay.security.risk.detect";
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
                { "buyer_account_no", BuyerAccountNo },
                { "buyer_bind_bankcard", BuyerBindBankcard },
                { "buyer_bind_bankcard_type", BuyerBindBankcardType },
                { "buyer_bind_mobile", BuyerBindMobile },
                { "buyer_grade", BuyerGrade },
                { "buyer_identity_no", BuyerIdentityNo },
                { "buyer_identity_type", BuyerIdentityType },
                { "buyer_real_name", BuyerRealName },
                { "buyer_reg_date", BuyerRegDate },
                { "buyer_reg_email", BuyerRegEmail },
                { "buyer_reg_mobile", BuyerRegMobile },
                { "buyer_scene_bankcard", BuyerSceneBankcard },
                { "buyer_scene_bankcard_type", BuyerSceneBankcardType },
                { "buyer_scene_email", BuyerSceneEmail },
                { "buyer_scene_mobile", BuyerSceneMobile },
                { "currency", Currency },
                { "env_client_base_band", EnvClientBaseBand },
                { "env_client_base_station", EnvClientBaseStation },
                { "env_client_coordinates", EnvClientCoordinates },
                { "env_client_imei", EnvClientImei },
                { "env_client_imsi", EnvClientImsi },
                { "env_client_ios_udid", EnvClientIosUdid },
                { "env_client_ip", EnvClientIp },
                { "env_client_mac", EnvClientMac },
                { "env_client_screen", EnvClientScreen },
                { "env_client_uuid", EnvClientUuid },
                { "item_quantity", ItemQuantity },
                { "item_unit_price", ItemUnitPrice },
                { "js_token_id", JsTokenId },
                { "order_amount", OrderAmount },
                { "order_category", OrderCategory },
                { "order_credate_time", OrderCredateTime },
                { "order_item_city", OrderItemCity },
                { "order_item_name", OrderItemName },
                { "order_no", OrderNo },
                { "partner_id", PartnerId },
                { "receiver_address", ReceiverAddress },
                { "receiver_city", ReceiverCity },
                { "receiver_district", ReceiverDistrict },
                { "receiver_email", ReceiverEmail },
                { "receiver_mobile", ReceiverMobile },
                { "receiver_name", ReceiverName },
                { "receiver_state", ReceiverState },
                { "receiver_zip", ReceiverZip },
                { "scene_code", SceneCode },
                { "seller_account_no", SellerAccountNo },
                { "seller_bind_bankcard", SellerBindBankcard },
                { "seller_bind_bankcard_type", SellerBindBankcardType },
                { "seller_bind_mobile", SellerBindMobile },
                { "seller_identity_no", SellerIdentityNo },
                { "seller_identity_type", SellerIdentityType },
                { "seller_real_name", SellerRealName },
                { "seller_reg_date", SellerRegDate },
                { "seller_reg_email", SellerRegEmail },
                { "seller_reg_moile", SellerRegMoile },
                { "transport_type", TransportType }
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
