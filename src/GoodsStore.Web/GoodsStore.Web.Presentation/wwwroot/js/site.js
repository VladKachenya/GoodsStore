function getSiteAddres() {
    var currentUrl = document.URL;
    var pathArray = currentUrl.split('/');
    var protocol = pathArray[0];
    var host = pathArray[2];
    return protocol + '//' + host;
}