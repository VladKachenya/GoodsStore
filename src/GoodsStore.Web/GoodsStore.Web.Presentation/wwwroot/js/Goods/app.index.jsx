const typeDiscriminator = document.getElementById('parameters-column').getAttribute('data-type');
const url = "/api/Catalog/CatalogItems/" + typeDiscriminator;

ReactDOM.render(<CatalogItemsBox url={url} />, document.getElementById('catalog-items-content'));