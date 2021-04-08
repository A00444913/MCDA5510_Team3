class App extends React.Component {
    constructor(props) {
        super(props)
    }
    render() {
        return (
            <div>
                <img src="../images/header.png" />
                <img src="../images/hotel.png" width="1500px" />
            </div>
        )
    }
}
ReactDOM.render(<App />, document.getElementById("home"))