


var searchArray = function (arr, regex) {
    var matches = [], i;
    for (i = 0; i < arr.length; i++) {
        if (arr[i].match(regex)) matches.push(i);
    }
    return matches;
};

var search = '';
$('#searchBarInput').on('focus', function (e) {
    fitAnimated();
});

$('#searchBarInput').on('keyup', function (e) {
    
    e.preventDefault();
    if (e.which == 13) {
        debugger;
        doSearch();
    }
});


$('#searchBar form').on('submit', function (e) {
    e.preventDefault();
    doSearch();
});

function doSearch() {
    debugger;
    search = $('#searchBarInput').val().toLowerCase();
    if (search.length > 0) {
        var reg = new RegExp(search);
        var result = searchArray(titlesList, reg);
        debugger;
        if (result.length > 0) {
            debugger;
            focusOnNode(nodesList[result[0]]);
        } else {
            fitAnimated();
        }
    }

    $('#searchBarInput').trigger('blur');

}

function fitAnimated() {
    network.fit({
        animation: {
            offset: {
                x: 0,
                y: 0
            },
            duration: 1000,
            easingFunction: 'easeInOutQuad'
        }
    });
}

function focusOnNode(id) {
    debugger;
    var options = {
        scale: 2,
        offset: {
            x: 0,
            y: 0
        },
        animation: {
            duration: 1500,
            easingFunction: 'easeInOutQuad'
        }
    };
    network.focus(id, options);
}