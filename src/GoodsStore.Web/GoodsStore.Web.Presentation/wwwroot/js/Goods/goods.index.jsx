$(document).ready(function () {
    const typeDiscriminator = document.getElementById('parameters-column').getAttribute('data-type');
    const itemsUrl = new URL("Goods/" + typeDiscriminator, getSiteAddres()).toString();

    getDataCount();
    getInitialData();

    var catalogItemsBox = ReactDOM.render(<CatalogItemsBox itemsUrl={itemsUrl} />, document.getElementById('catalog-items-content'));
    var pageCounter = document.getElementsByClassName('current-page')[0];
    //var pagination = document.getElementsByClassName('goods-store-pagination')[0];

    $('#floating-button').click(function () {
        loadData();
    });

    $('.next-link').click(function () {
        var curentPage = Number(pageCounter.innerText);
        loadMoreData(++curentPage);
    });

    $('.preview-link').click(function () {
        var curentPage = Number(pageCounter.innerText);
        loadMoreData(--curentPage);
    });

    $('.selecteble-list-parametr').change(function () {
        loadDataCount();
    });

    $('.range-parametr').keyup(function (event) {
        loadDataCount();
    });

    $('.phrase-parametr').keyup(function (event) {
        loadDataCount();
    });



    function selectFilters(skip = 0) {
        var parametrsColumn = document.getElementById('parameters-column');

        var data =
        {
            TypeDiscriminator: parametrsColumn.getAttribute('data-type'),
            SkippingPages: skip,
            PhraseModelFilters: [],
            RangeModelFilters: [],
            GroupModelFilters: []
        }

        // forming list of phraseParametr
        var phraseParametrs = parametrsColumn.getElementsByClassName('phrase-parametr');
        for (var i = 0; i < phraseParametrs.length; i++) {
            var phraseModelFilters =
            {
                PropertyName: phraseParametrs[i].getAttribute('name'),
                Value: phraseParametrs[i].getElementsByTagName('input')[0].value
            };
            data.PhraseModelFilters[data.PhraseModelFilters.length] = phraseModelFilters;
        }

        // forming list of rangeParametr
        var rangeParametrs = parametrsColumn.getElementsByClassName('range-parametr');
        for (var i = 0; i < rangeParametrs.length; i++) {
            var rangeModelFilters =
            {
                PropertyName: rangeParametrs[i].getAttribute('name'),
                FromValue: rangeParametrs[i].getElementsByClassName('from-value')[0].value,
                ToValue: rangeParametrs[i].getElementsByClassName('to-value')[0].value
            };
            data.RangeModelFilters[data.RangeModelFilters.length] = rangeModelFilters;
        }

        // forming list of selectebleListParametr
        var selectebleListParametr = parametrsColumn.getElementsByClassName('selecteble-list-parametr');

        for (var i = 0; i < selectebleListParametr.length; i++) {
            var groupModelFilters =
            {
                PropertyName: selectebleListParametr[i].getAttribute('name')
                //Values: []
            };

            var checkBoxes = $(selectebleListParametr[i]).find("input[type=checkbox]");
            var isValueSet = false;
            for (var j = 0; j < checkBoxes.length; j++) {
                if (checkBoxes[j].checked) {
                    if (!isValueSet) {
                        groupModelFilters.Values = new Array();
                        isValueSet = true;
                    }
                    groupModelFilters.Values[groupModelFilters.Values.length] = parseInt(checkBoxes[j].value);
                }
            }
            data.GroupModelFilters[data.GroupModelFilters.length] = groupModelFilters;
        }
        return data;
    }

    function SetItems(data) {
        catalogItemsBox.setState({ data: data });
        $('.compare-block-button').click(function (event) {
            var itemId = $(event.currentTarget).parents(".goods-store-catalog-item")[0].getAttribute('data-id');
            AddToComparisonBasket(itemId, typeDiscriminator);
        });
    }

    function getInitialData() {
        try {
            $.ajax({
                url: new URL("/api/Catalog/CatalogItems/" + typeDiscriminator, getSiteAddres()),
                contentType: "application/json",
                method: "GET",
                success: function (data) {
                    if (data != null) {
                        SetItems(data);
                    }
                    var spiner = $('.loading-spiner').first();
                    spiner.removeClass();
                    spiner.hide();
                },
                failure: function (errMsg) {
                    alert(errMsg);
                }
            });
        } catch (err) {
            var spiner = $('.loading-spiner').first();
            spiner.removeClass();
            spiner.hide();
            throw err;
        }

    };

    function loadData() {
        var data = selectFilters();

        $.ajax({
            url: new URL("/api/Catalog/CatalogItems/", getSiteAddres()),
            contentType: "application/json",
            method: "POST",
            data: JSON.stringify(data),
            success: function (data) {
                SetItems(data);
            },
            failure: function (errMsg) {
                alert(errMsg);
            }
        });
    };

    function loadMoreData(page) {
        skipingPages = page - 1;
        var data = selectFilters(skipingPages);

        $.ajax({
            url: new URL("/api/Catalog/CatalogItems/", getSiteAddres()),
            contentType: "application/json",
            method: "POST",
            data: JSON.stringify(data),
            success: function (data) {
                if (data != null) {
                    SetItems(data);
                    if (data.length > 0) {
                        pageCounter.innerText = page;
                        $('html, body').animate({ scrollTop: 0 }, 'fast');
                    }
                }
            },
            failure: function (errMsg) {
                alert(errMsg);
            }
        });
    };

    function getDataCount() {

        $.ajax({
            url: new URL("api/Catalog/Count/" + typeDiscriminator, getSiteAddres()),
            contentType: "application/json",
            method: "GET",
            success: function (count) {
                $('.total-count').text(count);
            },
            failure: function (errMsg) {
                alert(errMsg);
            }
        });
    };

    function loadDataCount() {
        var data = selectFilters();

        $.ajax({
            url: new URL("api/Catalog/Count", getSiteAddres()),
            contentType: "application/json",
            method: "POST",
            data: JSON.stringify(data),
            success: function (count) {
                $('.total-count').text(count);
            },
            failure: function (errMsg) {
                alert(errMsg);
            }
        });
    };
});


