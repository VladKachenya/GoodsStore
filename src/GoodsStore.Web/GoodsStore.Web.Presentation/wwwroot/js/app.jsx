class CatalogItemsBox extends React.Component {
    constructor(props) {
        super(props);
        this.state = { data: [] };
    }
    componentWillMount() {
        const xhr = new XMLHttpRequest();
        xhr.open('get', this.props.url, true);
        xhr.onload = () => {
            const data = JSON.parse(xhr.responseText);
            this.setState({ data: data });
        };
        xhr.send();
    }
    render() {
        return (
            <div className="catalog-items-box">
                <CatalogItemList data={this.state.data} />
            </div>
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

//ReactDOM.render(<CommentBox />, document.getElementById('content'));
// @catalogItemModel.Brand @catalogItemModel.Model