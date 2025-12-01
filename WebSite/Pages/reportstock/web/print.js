
    document.addEventListener("pagesloaded", function (e) {
        print({});
    });

document.addEventListener('textlayerrendered', function (event) {
    // was this the last page?
    if (event.detail.pageNumber === PDFViewerApplication.page) {
        print({});
    }
}, true);
