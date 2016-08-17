var ShowTimeBox = React.createClass({
	getInitialState: function() {
		return {data: []};
	},

	componentWillMount: function() {
		this.loadShowtimesFromServer(null);
	},

	loadShowtimesFromServer: function(showtime) {
		if (!showtime) {
			showtime = "2016-08-17";
		}

		var xhr = new XMLHttpRequest();
		xhr.open('get', this.props.url, true);
		xhr.onload = function() {
			var data = JSON.parse(xhr.responseText);
			this.setState({ data: data });
		}.bind(this);
		xhr.send();
	},

	handleShowtimeDateSubmit: function(showtime) {
		var data = new FormData();
		data.append('dateOfShowings', showtime.showtimeDate);

		var xhr = new XMLHttpRequest();
		xhr.open('post', this.props.submitUrl, true);
		xhr.onload = function() {
			var data = JSON.parse(xhr.responseText);
			this.setState({ data: data });
		}.bind(this);
		xhr.send(data);
	},

render: function() {
return (
			<div className="showTimeBox">
				<h1>Film show times</h1>
				<FilmShowTimeForm onShowtimeDateSubmit={this.handleShowtimeDateSubmit} />
				<FilmShowTimeList data={this.state.data.movies} />
			</div>
		);
	}
});

var FilmShowTimeForm = React.createClass({
	handleSubmit: function(e) {
		e.preventDefault();
		var showtimeDate = this.refs.showtimeDate.value.trim();
		if (!showtimeDate) {
			return;
		}
		this.props.onShowtimeDateSubmit({showtimeDate: showtimeDate});
		this.refs.showtimeDate.value = '';
		return;
	},
	render: function() {
		return (
			<form className="showtime-form" onSubmit={this.handleSubmit}>
				<input type="date" ref="showtimeDate" />
				<input type="submit" value="Post" />
			</form>
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
<ShowTimeBox url="/ReactFilmShowTimes" submitUrl="/ReactFilmShowTimes/Date" />,
document.getElementById('content')
);