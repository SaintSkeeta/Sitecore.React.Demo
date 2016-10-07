var SampleReactRendering = React.createClass({
    render: function() {
        return (
            <div>
                <h1 dangerouslySetInnerHTML={{__html: this.props.data.Title}}></h1>
                <div dangerouslySetInnerHTML={{__html: this.props.data.Text}}></div>
            </div>
        );
}
});