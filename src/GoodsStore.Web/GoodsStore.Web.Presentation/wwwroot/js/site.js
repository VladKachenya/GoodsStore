function getSiteAddres() {
    var currentUrl = document.URL;
    var pathArray = currentUrl.split('/');
    var protocol = pathArray[0];
    var host = pathArray[2];
    return protocol + '//' + host;
}

function AddToComparisonBasket(catalogItemId, typeDiscriminator) {
    var addres = new URL("/api/ComparisonBasket/BasketItem/" + catalogItemId, getSiteAddres());
    $.ajax({
        url: addres,
        contentType: "application/json",
        method: "POST",
        data: JSON.stringify(typeDiscriminator),
        success: function (count) {
            $('#comparison-basket-count').text(count);
        },
        failure: function (errMsg) {
            alert(errMsg);
        }
    });
}

$(document).ready(function () {
    var addres = new URL("/api/ComparisonBasket/ItemsCount", getSiteAddres());
    $.ajax({
        url: addres,
        contentType: "application/json",
        method: "GET",
        success: function (count) {
            $('#comparison-basket-count').text(count);
        },
        failure: function (errMsg) {
            alert(errMsg);
        }
    });

});
