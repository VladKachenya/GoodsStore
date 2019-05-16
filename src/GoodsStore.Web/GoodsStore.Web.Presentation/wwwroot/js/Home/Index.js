$(document).ready(function() {
    $('.category-model').click(function () {
        var categoryId = $(this).attr('data-category-id');
        leaveOnly(categoryId);
    });

    function leaveOnly(categoryId) {
        var elements = document.getElementsByClassName('category-model-types');
        for (var i = 0; i < elements.length; i++) {
            if (elements[i].getAttribute('data-category-id') == categoryId) {
                elements[i].style.display = 'block';
            } else {
                elements[i].style.display = 'none';
            };
        }
    }
});