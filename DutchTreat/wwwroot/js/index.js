var x = 0;
var s = "";

console.log("hello mr. pinner")


var theForm = $("#theForm");
theForm.hide();

var button = $("#buyButton");
button.on("click", function () {
    alert("Buying Item");
});

var productinfo = $(".product-props li");