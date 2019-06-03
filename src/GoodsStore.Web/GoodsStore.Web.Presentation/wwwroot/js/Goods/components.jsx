class CatalogItemsBox extends React.Component {
    constructor(props) {
        super(props);
        this.state = { data: [] };
    }
    render() {
        return (
            <div className="catalog-items-box">
                <CatalogItemList data={this.state.data} itemsUrl={this.props.itemsUrl} />
            </div>
        );
    }
}

class CatalogItemList extends React.Component {
    render() {
        var ciUrl = this.props.itemsUrl;
        const catalogItemNodes = this.props.data.map(function (ci) {
            var itemUrl = ciUrl + "/" + ci.id;
            return (<div key={ci.id} className="card m-2 p-1 catalog-item">
                <h5 className="card-header">{ci.unitName} {ci.brand} {ci.model}</h5>
                <div className="card-body row">
                    <img className="col-3" src={ci.pictureUri} alt="Card image cap" />
                    <div className="col-6">
                        <h5 className="card-title goods-store-price">{ci.price}</h5>
                        <p className="card-text">{ci.description}</p>
                        <a href={itemUrl} className="btn btn-primary">Details</a>
                    </div>
                    <div className="col-3">Some shops</div>
                </div>
            </div>);
        });
        return (<div className="catalog-item-list">{catalogItemNodes}</div>);
    }
}
