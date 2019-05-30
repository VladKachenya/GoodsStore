$(document).ready(function () {
    const typeDiscriminator = document.getElementById('parameters-column').getAttribute('data-type');
    const getDataUrl = "/api/Catalog/CatalogItems/" + typeDiscriminator;


    getDataCount();
    getData();


    var catalogItemsBox = ReactDOM.render(<CatalogItemsBox url={getDataUrl} />, document.getElementById('catalog-items-content'));
    var itemPagginator = ReactDOM.render(<PaginationBox />, document.getElementById('nav-paggination'));



    $('#floating-button').click(function () {
        loadData();
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



    function selectFilters() {
        var parametrsColumn = document.getElementById('parameters-column');
        var catalogItemsColumn = document.getElementById('catalog-items-column');

        var data =
        {
            TypeDiscriminator: parametrsColumn.getAttribute('data-type'),
            LoadedCount: catalogItemsColumn.getElementsByClassName('catalog-item').length,
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

    function getData() {
        var data = selectFilters();

        $.ajax({
            url: "api/Catalog/CatalogItems/" + typeDiscriminator,
            contentType: "application/json",
            method: "GET",
            success: function (data) {
                catalogItemsBox.setState({ data: data });
            },
            failure: function (errMsg) {
                alert(errMsg);
            }
        });
    };

    function loadData() {
        var data = selectFilters();

        $.ajax({
            url: "api/Catalog/CatalogItems",
            contentType: "application/json",
            method: "POST",
            data: JSON.stringify(data),
            success: function (data) {
                catalogItemsBox.setState({ data: data });
            },
            failure: function (errMsg) {
                alert(errMsg);
            }
        });
    };

    function getDataCount() {

        $.ajax({
            url: "api/Catalog/Count/" + typeDiscriminator,
            contentType: "application/json",
            method: "GET",
            success: function (count) {
                $('.total-count').text(count);
                itemPagginator.setState({ data: count });
            },
            failure: function (errMsg) {
                alert(errMsg);
            }
        });
    };

    function loadDataCount() {
        var data = selectFilters();

        $.ajax({
            url: "api/Catalog/Count",
            contentType: "application/json",
            method: "POST",
            data: JSON.stringify(data),
            success: function (count) {
                $('.total-count').text(count);
                itemPagginator.setState({ data: count });
            },
            failure: function (errMsg) {
                alert(errMsg);
            }
        });
    };
});


