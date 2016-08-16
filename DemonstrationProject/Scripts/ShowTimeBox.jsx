var ShowTimeBox = React.createClass({
	getInitialState: function() {
		return {data: []};
	},

	componentWillMount: function() {
	var xhr = new XMLHttpRequest();
	xhr.open('get', this.props.url, true);
	xhr.onload = function() {
		var data = JSON.parse(xhr.responseText);
		this.setState({ data: data });
	}.bind(this);
	xhr.send();
},

render: function() {
return (
			<div className="showTimeBox">
				<h1>Film show times</h1>
				<FilmShowTimeList data={this.state.data.movies} />
			</div>
		);
	}
});

var FilmShowTimeList = React.createClass({
render: function() {
if (!!this.props.data) {
var filmNodes = this.props.data.map(function (dataFilm) {
	return (
		<Film title={dataFilm.title} director={dataFilm.director} longDesc={dataFilm.longDesc} />
	);
});
	return (
		<div className="filmList">
			{filmNodes}
		</div>
	);
} else
{
	return (
		<div></div>
	);
}
}
});

var Film = React.createClass({
	render: function() {
		return (
			<div className="film">
				<h2 className="film-title">
					{this.props.title}
				</h2>
				{this.props.director}
				<br></br>
				{this.props.longDesc}
			</div>
		);
	}
});

ReactDOM.render(
<ShowTimeBox url="/ReactFilmShowTimes" />,
document.getElementById('content')
);