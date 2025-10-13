// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function ajaxRequest(method, url, data, onSuccess, onError) {
    fetch(url, {
        method: method,
        headers: {
            'Content-Type': 'application/json',
            'Accept': 'application/json'
        },
        body: JSON.stringify(data)
    })
    .then(response => {
        if (response.ok) {
            onSuccess && onSuccess();
        } else {
            response.json().then(err => {
                onError && onError(err.message || 'Error');
            }).catch(() => onError && onError('Error'));
        }
    })
    .catch((e) => {
        // If button is already replaced, do nothing
        onSuccess && onSuccess();
    });
}

function changeButtonToGoToCart(productId, button) {
    // Use event.target to get the button reliably
    if (!button) return;
    // If called from onclick, 'this' may not be the button, so try to get the active element
    if (!(button instanceof HTMLElement)) {
        button = document.activeElement;
    }
    if (!button || !button.parentNode) return;
    var link = document.createElement('a');
    link.type = "submit";
    link.className = "btn btn-primary m-2";
    link.href = "/Home/Cart";
    link.innerHTML = '<i class="bi-cart"></i> Go to Cart';
    button.parentNode.replaceChild(link, button);
}