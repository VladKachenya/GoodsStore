$(document).ready(function () {

    //loadData();
    $('#floating-button').click(function () {
        loadData();
    });

    function loadData() {
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
            var phraseModelFilter =
            {
                PropertyName: phraseParametrs[i].getAttribute('name'),
                Value: phraseParametrs[i].getElementsByTagName('input')[0].value
            };
            data.PhraseModelFilters[data.PhraseModelFilters.length] = phraseModelFilter;
        }

        // forming list of rangeParametr
        var rangeParametrs = parametrsColumn.getElementsByClassName('range-parametr');
        for (var i = 0; i < rangeParametrs.length; i++) {
            var rangeParametrs =
            {
                PropertyName: rangeParametrs[i].getAttribute('name'),
                FromValue: rangeParametrs[i].getElementsByClassName('from-value')[0].value,
                ToValue: rangeParametrs[i].getElementsByClassName('to-value')[0].value
            };
            data.RangeModelFilters[data.PhraseModelFilters.length] = rangeParametrs;
        }



        $.ajax({
            url: "api/Catalog/GetCatalogItems",
            contentType: "application/json",
            method: "POST",
            data: JSON.stringify(data),
            success: function () {
                
            },
            failure: function (errMsg) {
                alert(errMsg);
            }
        });
    };
});