$(function () {
    $("#tabs-api").tabs();
    setApiDemoTabs("#tabs-purchase-alipay");
    setApiDemoTabs("#tabs-purchase-wechatpay");
    setApiDemoTabs("#tabs-purchase-qpay");
    setApiDemoTabs("#tabs-purchase-jdpay");
    setApiDemoTabs("#tabs-purchase-unionpay");
    $(document).tooltip();
});

function setApiDemoTabs(selector) {
    $(selector).tabs({
        beforeLoad: function (event, ui) {
            ui.jqXHR.error(function () { ui.panel.html("加载中"); });
        }, load: function (event, ui) {
            $(".question").hide();
            $(".showFaqBtn").click(
                function () { $(".question").toggle(); });
        }
    }).addClass("ui-tabs-vertical ui-helper-clearfix");
    $(selector + " li").removeClass("ui-corner-top").addClass("ui-corner-left");
}