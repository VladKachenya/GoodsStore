class CatalogItemsBox extends React.Component {
    constructor(props) {
        super(props);
        this.state = { data: [] };
    }
    render() {
        return (
            <div className="catalog-items-box">
                <CatalogItemList data={this.state.data} />
            </div>
        );
    }
}

class PaginationBox extends React.Component {
    constructor(props) {
        super(props);
        this.state = { data: [] };
    }
    render() {
        return (
            <ul className="pagination">
                <li className="page-item">
                    <a className="page-link" href="#" aria-label="Previous">
                        <span aria-hidden="true">&laquo;</span>
                    </a>
                </li>
                <PaginationList data={this.state.data} />

                <li className="page-item">
                    <a className="page-link" href="#" aria-label="Next">
                        <span aria-hidden="true">&raquo;</span>
                    </a>
                </li>
            </ul>
        );
    }
}

class CatalogItemList extends React.Component {
    render() {
        const catalogItemNodes = this.props.data.map(ci => (
            <div key={ci.id} className="card m-1 p-1 catalog-item">
                <h5 className="card-header">{ci.unitName} {ci.brand} {ci.model}</h5>
                <div className="card-body row">
                    <img className="col-3" src={ci.pictureUri} alt="Card image cap" />
                    <div className="col-6">
                        <h5 className="card-title">{ci.price}</h5>
                        <p className="card-text">{ci.description}</p>
                        <a href="#" className="btn btn-primary">Details</a>
                    </div>
                    <div className="col-3">Some shops</div>
                </div>
            </div>
        ));
        return (<div className="catalog-item-list">{catalogItemNodes}</div>);
    }
}

class PaginationList extends React.Component {
    render() {
        var pageItemsCount = 6;
        var i = 1;
        var pages = [];
        while (i * pageItemsCount < this.props.data) {
            pages[i - 1] = i;
            i++;
        }
        i = 0;
        const pageItems = pages.map(p => (
            <li className="page-item" key={i++}><a className="page-link" href="#">{p}</a></li>
            ));
        return (<ul className="pagination">{pageItems}</ul>);
    }
}



